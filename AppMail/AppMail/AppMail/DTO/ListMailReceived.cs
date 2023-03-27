using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AppMail.DTO
{
    public class ListMailReceived
    {
        private string _TimeReceived;

        public string TimeReceived { get => _TimeReceived; set => _TimeReceived = value; }

        public ListMailReceived( string timeReceived)
        {
            this.TimeReceived = timeReceived;
        }

        public ListMailReceived(DataRow row)
        {
            this.TimeReceived = (string)row["TimeReceived"];
        }
    }
}
