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
    public partial class fShowMail : Form
    {

        public fShowMail()
        {
            InitializeComponent();

            this.MailID = FormMain2.MailID;
            LoadMail(FormMain2.StrTime, FormMain2.StrName, FormMain2.StrSubject, FormMain2.StrContent);

            showBtnRecallMail(FormMain2.SwitchMethod);
            SwitchFromTo(FormMain2.SwitchMethod);
        }

        
        private int mailID;
        private string strName;
        private string strTime;
        private string strContent;
        private string strSubject;

        public string StrName { get => strName; set => strName = value; }
        public string StrTime { get => strTime; set => strTime = value; }
        public string StrContent { get => strContent; set => strContent = value; }
        public string StrSubject { get => strSubject; set => strSubject = value; }
        public int MailID { get => mailID; set => mailID = value; }

        void showBtnRecallMail(int s)
        {
            if (s == 0)
                btnRecallMail.Visible = false;
            else
                btnRecallMail.Visible = true;

        }

        void SwitchFromTo(int s)
        {
            if(s==0)
            {
                lbFromTo.Text = "FROM:";
            }
            else
            {
                lbFromTo.Text = "TO:";
            }
        }

        void LoadMail(string strTime, string strName, string strSubject, string strContent)
        {
            lbMailAddress.Text = strName;
            lbSubject.Text = strSubject;
            txbContentMail.Text = strContent;
            lbTime.Text = strTime;
        }

        private void btnRecallMail_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want recall this mail?", "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                ListMailReceivedDAO.Instance.DeleteMailReceived(MailID);
                ListMailSentDAO.Instance.DeleteMailSent(MailID);
                MailDAO.Instance.DeleteMaild(MailID);
                if (deleteMail != null)
                    deleteMail(this, new EventArgs());

                MessageBox.Show("This mail have been recall");
            }
            
        }
        private event EventHandler deleteMail;
        public event EventHandler DeleteMail
        {
            add { deleteMail += value; }
            remove { deleteMail -= value; }
        }

    }

}
