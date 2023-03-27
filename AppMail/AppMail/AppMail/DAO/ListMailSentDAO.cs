using AppMail.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AppMail.DAO
{
    public class ListMailSentDAO
    {
        private static ListMailSentDAO instance;

        public static ListMailSentDAO Instance
        {
            get { if (instance == null) instance = new ListMailSentDAO(); return instance; }
            private set { instance = value; }
        }

        private ListMailSentDAO() { }
        public List<ListMailSent> GetListMailReceived(int id)//lấy danh sách billinfo dự vào id
        {
            List<ListMailSent> ListMailSent = new List<ListMailSent>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.MailSent WHERE id = " + id);

            foreach (DataRow item in data.Rows)
            {
                ListMailSent info = new ListMailSent(item);
                ListMailSent.Add(info);
            }

            return ListMailSent;
        }

        public bool InsertMailSent(int idMail, string TimeSend)
        {
            string query = string.Format(" INSERT dbo.MailSent ( TimeSend  , idMail ) VALUES( N'{0}' , {1} ) ", TimeSend, idMail);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public string GetTimeSentByIDMail(int idMail)
        {
            string query = string.Format(" Select TimeSend From dbo.MailSent Where idMail = {0}  ", idMail);
            string result = DataProvider.Instance.ExecuteScalar(query).ToString();

            return result;

        }


        public void DeleteMailSent(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE dbo.MailSent WHERE idMail = " + id);
        }
    }
}
