using AppMail.DAO;
using AppMail.DTO;
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
    public partial class fEditAccountInfo : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public fEditAccountInfo(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;
            LoadInfo();
        }

        void LoadInfo()
        {
            lbUserName.Text = LoginAccount.UserName;
            txbFirstName.Text = LoginAccount.FirstName;
            txbLastName.Text = LoginAccount.LastName;
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
        void EditAccount(string userName, string firstName, string lastName, string password)
        {
            if (AccountDAO.Instance.UpdateAccountForUser(userName, firstName, lastName, password))
            {
                MessageBox.Show("Edit account success!");
            }
            else
            {
                MessageBox.Show("Edit account fail!");
            }
            
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        public class AccountEvent : EventArgs
        {
            private Account acc;

            public Account Acc
            {
                get { return acc; }
                set { acc = value; }
            }

            public AccountEvent(Account acc)
            {
                this.Acc = acc;
            }
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            string firstName = txbFirstName.Text;
            string lastName = txbLastName.Text;
            string password = hashPass(txbPassword.Text);
            string username = LoginAccount.UserName;
            if (firstName == "" || lastName == "" || password == "")
            {
                MessageBox.Show("Please input enought data!");
            }
            else
            {
                EditAccount(username, firstName, lastName, password);
                if (updateAccount != null)
                    updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(username)));
            }
        }
    }
}
