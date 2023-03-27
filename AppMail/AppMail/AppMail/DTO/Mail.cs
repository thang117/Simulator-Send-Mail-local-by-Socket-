using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppMail.DTO
{
    public class Mail
    {
        private string strName;
        private int iD;
        private string strContent;
        private string strSubject;
        private int status;
        private string userNameAccount;
        public string StrName { get => strName; set => strName = value; }
        
        public string StrContent { get => strContent; set => strContent = value; }
        public string StrSubject { get => strSubject; set => strSubject = value; }
        public int Status { get => status; set => status = value; }
        public int ID { get => iD; set => iD = value; }
        public string UserNameAccount { get => userNameAccount; set => userNameAccount = value; }

        public Mail(int iD,int status, string strName, string strSubject, string strContent,string userNameAccount)
        {
            this.ID = iD;
            this.Status = status;
            this.StrName = strName;
            this.StrSubject = strSubject;
            this.StrContent = strContent;
            this.UserNameAccount = userNameAccount;
        }
        public Mail(DataRow row)
        {
            this.ID = (int)row["id"];
            this.StrName = (string)row["AddressSend"];
            this.StrSubject = (string)row["SubjectMail"];
            this.StrContent = (string)row["ContentMail"];
            this.Status = (int)row["status"];
            this.UserNameAccount = (string)row["UserNameAccount"];
        }
    }
}
