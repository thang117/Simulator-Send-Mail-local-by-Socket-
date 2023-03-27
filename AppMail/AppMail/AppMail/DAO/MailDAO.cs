using AppMail.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AppMail.DAO
{
    public class MailDAO
    {
        private static MailDAO instance;

        public static MailDAO Instance
        {
            get { if (instance == null) instance = new MailDAO(); return instance; }
            private set { instance = value; }
        }

        private MailDAO() { }

        public List<Mail> GetListMail(string username)//lấy danh sách billinfo dự vào id
        {
            List<Mail> ListMail = new List<Mail>();

            string query = string.Format("SELECT * FROM dbo.Mail WHERE UserNameAccount = N'{0}' ", username);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Mail info = new Mail(item);
                ListMail.Add(info);
            }

            return ListMail;
        }
        public List<Mail> GetListMailReceived(string username)//lấy danh sách billinfo dự vào id
        {
            List<Mail> ListMail = new List<Mail>();

            string query = string.Format(" SELECT * FROM dbo.Mail as M , dbo.MailReceived as MR WHERE UserNameAccount = N'{0}' AND M.id = MR.idMail ORDER BY M.id DESC ", username);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Mail info = new Mail(item);
                ListMail.Add(info);
            }

            return ListMail;
        }
        public List<Mail> GetListMailSent(string username)//lấy danh sách billinfo dự vào id
        {
            List<Mail> ListMail = new List<Mail>();

            string query = string.Format(" SELECT * FROM dbo.Mail as M , dbo.MailSent as MS WHERE UserNameAccount = N'{0}' AND M.id = MS.idMail ORDER BY M.id DESC ", username);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Mail info = new Mail(item);
                ListMail.Add(info);
            }

            return ListMail;
        }

        public bool InsertMail( string strName, string strSubject, string strContent, string userNameAccount)
        {
            string query = string.Format(" INSERT dbo.Mail ( AddressSend , SubjectMail , ContentMail , UserNameAccount , status ) VALUES( N'{0}' , N'{1}' , N'{2}' , N'{3}' , 0 )", strName,strSubject,strContent,userNameAccount);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public int GetLastIdMail()
        {
            string query = " SELECT TOP 1 id  FROM dbo.Mail ORDER BY id DESC ";
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result;
        }
        public void UpdateMailStatus(int id,int status)
        {
            string query = string.Format(" UPDATE dbo.Mail SET status = N'{0}' WHERE id = {1}", status , id);
            DataProvider.Instance.ExecuteNonQuery(query);       
        }

        public void DeleteMaild(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE dbo.Mail WHERE id= " + id);
        }
    }
}
