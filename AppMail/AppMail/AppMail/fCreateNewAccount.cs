using AppMail.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AppMail
{
    public partial class fCreateNewAccount : Form
    {
        public fCreateNewAccount()
        {
            InitializeComponent();

            LoadComboBox();
        }

        void LoadComboBox()
        {
            cbbType.Items.Add("Admin");
            cbbType.Items.Add("User");
            cbbType.SelectedIndex = 1;
           
        }

        private void btnEditAccountInfo_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string firstName = txbFirstName.Text;
            string lastName = txbLastName.Text;
            string password = hashPass(txbPassword.Text);
            int type;

            if (firstName == "") firstName = userName + "FirstName";
            if (lastName == "") lastName = userName + "LastName";

            if (string.Compare((string)cbbType.SelectedItem, "Admin") == 0) //kiểm tra acc dc thêm nếu là admin thì gán 1
            {
                type = 1;
            }
            else
            {
                type = 0;
            }

            if(AccountDAO.Instance.GetAccountByUserName(userName)==null)
            {
                AddAccount(userName, firstName, lastName, password, type);
            }
            else
            {
                MessageBox.Show("This username is already exist!");
            }
        }

        string hashPass(string p)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(p);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp); //băm password
            string hashPass = "";

            foreach (byte item in hashData)
            {
                hashPass += item;
            }
            return hashPass;
        }
        void AddAccount(string userName, string firstName, string lastName,string password , int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, firstName,lastName,password, type))
            {
                MessageBox.Show("Thêm tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại!");
            }
           
        }

      
    }
}
