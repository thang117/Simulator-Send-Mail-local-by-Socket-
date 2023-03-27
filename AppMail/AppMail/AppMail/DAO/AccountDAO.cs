using AppMail.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppMail.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }


        public bool Login(string userName,string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp); //băm password

            string hashPass = "";

            foreach(byte item in hashData)
            {
                hashPass += item;
            }
            // 1962026656160185351301320480154111117132155 là hash  md5 của 1
           

            string query = " USP_Login @userName , @passWord "; // sử dụng đoạn lệnh đã tạo trong SQL_query_AppMail để xác thực 

            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] {userName,hashPass/*passWord*/});


            return result.Rows.Count > 0;
        }

       
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName , FirstName , LastName , Type FROM Account ");
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account WHERE userName = '" + userName + "'");

            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public bool InsertAccount(string userName, string firstName, string lastName , string password , int type)
        {
            string query = string.Format(" INSERT dbo.Account ( userName , password , firstName , lastName , type  ) VALUES( N'{0}', N'{1}' , N'{2}' , N'{3}' , {4} ) ", 
                userName, password , firstName, lastName , type );
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //mật khẩu của tài khoản dc Admin tạo luôn là 1
        public bool InsertAccountForAdmin(string userName, string firstName, string lastName, int type)
        {
            string query = string.Format(" INSERT dbo.Account ( userName , password , firstName , lastName , type  ) VALUES( N'{0}', N'{1}' , N'{2}' , N'{3}' , {4} ) ", 
                userName, "1962026656160185351301320480154111117132155", firstName, lastName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateAccountForAdmin( string userName, string firstName, string lastName, int type)
        {
            string query = string.Format(" UPDATE dbo.Account SET  FirstName = N'{0}' , LastName = N'{1}' , Type = {2}  WHERE userName = N'{3}' ", 
                firstName,lastName,type,userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateAccountForUser(string userName, string firstName, string lastName, string password)
        {
            string query = string.Format(" UPDATE dbo.Account SET  FirstName = N'{0}' , LastName = N'{1}' , Password = N'{2}'  WHERE userName = N'{3}' ", 
                firstName, lastName, password, userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteAccount(string userName)
        {
            
            string queryDeMailRe = string.Format("DELETE dbo.MailReceived  from dbo.Mail as M , dbo.MailReceived as MR where MR.idMail = M.id and M.UserNameAccount = N'{0}' ", userName);
            string queryDeMailSe = string.Format("DELETE dbo.MailSent from dbo.Mail as M , dbo.MailSent as MS  where MS.idMail = M.id and M.UserNameAccount = N'{0}' ", userName);
            string queryDeMail = string.Format("DELETE dbo.Mail WHERE UserNameAccount = N'{0}' ", userName);
            string query = string.Format("DELETE dbo.Account WHERE userName = N'{0}' ", userName);
            DataProvider.Instance.ExecuteNonQuery(queryDeMailRe);
            DataProvider.Instance.ExecuteNonQuery(queryDeMailSe);
            DataProvider.Instance.ExecuteNonQuery(queryDeMail);


            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string userName)
        {
            string query = string.Format("Update dbo.Account SET password = N'1962026656160185351301320480154111117132155' WHERE userName = N'{0}' ", userName); //password là 1
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
