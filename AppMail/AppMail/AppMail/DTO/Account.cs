using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMail.DTO
{
    public class Account
    {
        public Account(string userName,string firstName, string lastName, string emailAddress,int type, string passWord = null)
        {
            this.UserName = userName;
            this.PassWord = passWord;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Type = type;
            this.EmailAddress = emailAddress;
        }

        public Account(DataRow row)
        {
            this.UserName = (string)row["userName"];
            this.FirstName = (string)row["firstName"];
            this.LastName = (string)row["lastName"];
            this.Type = (int)row["type"];
            this.PassWord = (string)row["passWord"];
        }

        private string userName;

        private string firstName;
        private string lastName;

        private string passWord;

        private string emailAddress;

        private int type;

        public string UserName 
        {
            get { return userName; }
            set { userName = value; } 
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public string LastName
        {
            get => lastName; 
            set => lastName = value; 
        }
        public string EmailAddress 
        { 
            get => emailAddress; 
            set => emailAddress = value; 
        }
    }
}
