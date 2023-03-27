using AppMail.DAO;
using AppMail.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppMail
{
    public partial class fAccountManager : Form
    {
        BindingSource accountList = new BindingSource();

        private int switchButton;
        public Account LoginAccount;
        public fAccountManager()
        {
            InitializeComponent();

            loadData();
        }

        void loadData()
        {
            dtgvAccount.DataSource = accountList;

            LoadComboBox();
            LoadAccount();
            AddAccountBinding();

            btnShowAccount.BackColor = Color.LimeGreen;
            btnConfirm.Enabled = false;
           

        }
        void LoadComboBox()
        {
            cbAccountType.Items.Add("Admin");
            cbAccountType.Items.Add("User");
            cbAccountType.SelectedIndex = 1;

        }
        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbFirstName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "FirstName", true, DataSourceUpdateMode.Never));
            txbLastName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "LastName", true, DataSourceUpdateMode.Never));
            

        }
        void ResetColorButton()
        {
            btnEditAccountInfo.BackColor = Color.Transparent;
            btnDeleteAccount.BackColor = Color.Transparent;
            btnEditAccount.BackColor = Color.Transparent;
            btnShowAccount.BackColor = Color.Transparent;
            btnConfirm.BackColor = Color.Transparent;

        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void AddAccount(string userName, string firstName, string lastName,  int type)
        {
            if (AccountDAO.Instance.InsertAccountForAdmin(userName,  firstName,  lastName, type))
            {
                MessageBox.Show("Add account success!");
            }
            else
            {
                MessageBox.Show("Add account fail!");
            }

        }
        void EditAccount(string userName, string firstName, string lastName, int type)
        {
            if (AccountDAO.Instance.UpdateAccountForAdmin(userName, firstName,lastName, type))
            {
                MessageBox.Show("Edit account success!");
            }
            else
            {
                MessageBox.Show("Edit account fail!");
            }
            LoadAccount();
        }

        void DeleteAccount(string userName)
        {

            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Delete account success!");
            }
            else
            {
                MessageBox.Show("Delete account fail!");
            }
            LoadAccount();
        }

        void ResetPassword(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Reset password success!");
            }
            else
            {
                MessageBox.Show("Reset password fail");
            }
        }
        void SwitchEnableTextBox(bool username,bool firstname,bool lastname)
        {
            txbUserName.ReadOnly = username;
            txbFirstName.ReadOnly = firstname;
            txbLastName.ReadOnly = lastname;
        }
        private void btnEditAccountInfo_Click(object sender, EventArgs e)
        {
            switchButton = 0;
            SwitchEnableTextBox(false, false, false);//turn off read only

            ResetColorButton();
            btnEditAccountInfo.BackColor = Color.LimeGreen;
            btnConfirm.Enabled = true;
            btnResetPassword.Enabled = false;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            switchButton = 1;
            SwitchEnableTextBox(true, true, true);//turn off read only

            ResetColorButton();
            btnDeleteAccount.BackColor = Color.LimeGreen;
            btnConfirm.Enabled = true;
            btnResetPassword.Enabled = false;
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            switchButton = 2;
            SwitchEnableTextBox(true, false, false);

            ResetColorButton();
            btnEditAccount.BackColor = Color.LimeGreen;
            btnConfirm.Enabled = true;
            btnResetPassword.Enabled = false;
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            SwitchEnableTextBox(true, true, true);//turn on read only


            btnShowAccount.BackColor = Color.LimeGreen;
            btnConfirm.Enabled = false;
            btnResetPassword.Enabled = true;

            LoadAccount();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            btnResetPassword.BackColor = Color.LimeGreen;

            string userName = txbUserName.Text;
            if (MessageBox.Show("Are you sure want reset this password account?", "Confirm!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                ResetPassword(userName);
            }

            btnResetPassword.BackColor = Color.Transparent;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnConfirm.BackColor = Color.LimeGreen;
            
            string userName = txbUserName.Text;
            string firstName = txbFirstName.Text;
            string lastName = txbLastName.Text;

            if (firstName == "") firstName = userName + "FirstName";
            if (lastName == "") lastName = userName + "LastName";
            int type;
            if (string.Compare((string)cbAccountType.SelectedItem, "Admin") == 0) //kiểm tra acc dc thêm nếu là admin thì gán 1
            {
                type = 1;
            }
            else
            {
                type = 0;
            }
            #region Add
            if (switchButton == 0)
            {
                if (txbUserName.Text != "")
                {                

                    if (AccountDAO.Instance.GetAccountByUserName(userName) == null)
                    {
                        AddAccount(userName, firstName, lastName, type);
                    }
                    else
                    {
                        MessageBox.Show("This username is already exist!");
                    }
                }
                else
                {
                    MessageBox.Show("Please input username!");
                }
            }
            #endregion

            #region Delete
            else if (switchButton == 1)
            {
                if (LoginAccount.UserName.Equals(userName)) // kiểm tra xem tài khoản muốn xóa có trùng với tài khoản đang log in hay ko
                {
                    MessageBox.Show("Cannot delete account still log in!");
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure about that?", "Warning!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        DeleteAccount(userName);
                    }
                }
            }
            #endregion

            #region Edit
            else if (switchButton == 2)
            {
                if (MessageBox.Show("Are you sure?", "Confirm!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    EditAccount(userName, firstName,lastName, type);
                }
            }
            #endregion
            btnConfirm.BackColor = Color.Transparent;
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            if (dtgvAccount.SelectedCells.Count > 0 && dtgvAccount.SelectedCells[0].OwningRow.Cells["Type"].Value != null)
            {
                int id = (int)dtgvAccount.SelectedCells[0].OwningRow.Cells["Type"].Value;
                if (id == 1)
                {
                    cbAccountType.SelectedIndex = 0;
                }
                else
                {
                    cbAccountType.SelectedIndex = 1;
                }

            }
        }
    }
    
}
