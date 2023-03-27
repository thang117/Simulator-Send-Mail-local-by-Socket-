using AppMail.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AppMail.DAO
{
    public class ListMailReceivedDAO
    {
        private static ListMailReceivedDAO instance;

        public static ListMailReceivedDAO Instance
        {
            get { if (instance == null) instance = new ListMailReceivedDAO(); return instance; }
            private set { instance = value; }
        }

        private ListMailReceivedDAO() { }
        public List<ListMailReceived> GetListMailReceived(int id)//lấy danh sách billinfo dự vào id
        {
            List<ListMailReceived> ListMailReceived = new List<ListMailReceived>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.MailReceived WHERE id = " + id);

            foreach (DataRow item in data.Rows)
            {
                ListMailReceived info = new ListMailReceived(item);
                ListMailReceived.Add(info);
            }

            return ListMailReceived;
        }
        public string GetTimeReceivedByIDMail(int idMail)
        {
            string query = string.Format(" Select TimeReceive From dbo.MailReceived Where idMail = {0}  ", idMail);
            string result = DataProvider.Instance.ExecuteScalar(query).ToString();

            return result;

        }
        public bool InsertMailReceived(int idMail, string TimeReceived)
        {
            string query = string.Format(" INSERT dbo.MailReceived ( TimeReceive , idMail ) VALUES( N'{0}' , {1}  )", TimeReceived,idMail);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public void DeleteMailReceived(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE dbo.MailReceived WHERE idMail = " + id);
        }

    }
}
