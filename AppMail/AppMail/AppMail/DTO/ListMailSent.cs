using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AppMail.DTO
{
    public class ListMailSent
    {
        private string _TimeSent;

        public string TimeSent { get => _TimeSent; set => _TimeSent = value; }

        public ListMailSent(string timeSent)
        {
            this.TimeSent = timeSent;
        }
        public ListMailSent(DataRow row)
        {
            this.TimeSent = (string)row["TimeSent"];
        }
    }
}
