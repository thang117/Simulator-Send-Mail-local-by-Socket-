using AppMail.DAO;
using AppMail.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMail
{
    public partial class Form1 : Form
    {
        [Obsolete]
        public Form1()
        {
            InitializeComponent();

            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        [Obsolete]
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (Login(userName, passWord))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);              
                FormMain2 f2 = new FormMain2(loginAccount);             
                f2.Text = f2.Text +" [" + loginAccount.UserName+"]";

                this.Hide();
                f2.ShowDialog();
                this.Show();
             
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
            
        }
        bool Login(string userName, string passWord)
        {


            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            fCreateNewAccount fCreateForm = new fCreateNewAccount();
            this.Hide();
            fCreateForm.ShowDialog();
            this.Show();
        }
    }
}
