using AppMail.DAO;
using AppMail.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AppMail
{
    public partial class fComposeMail2 : Form
    {
        private string strName;
        private string strTime;
        private string strSubject;
        private string strContent;
        private string nameAddress;
        public string StrName { get => strName; set => strName = value; }
        public string StrTime { get => strTime; set => strTime = value; }
        public string StrContent { get => strContent; set => strContent = value; }
        public string StrSubject { get => strSubject; set => strSubject = value; }
        public string NameAddress { get => nameAddress; set => nameAddress = value; }

        IPEndPoint IP;
        Socket server;
        Socket clientAcc;
        public List<Socket> clientlist;


        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        

        private void ChangeAccount(object type)
        {
            lbMailAddress.Text = LoginAccount.FirstName + " " + LoginAccount.LastName;
        }

        public fComposeMail2(){ }
        public fComposeMail2(Account acc)
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            this.LoginAccount = acc;

            Connect();
        }



        
        private void btnSend_Click(object sender, EventArgs e)
        {
            //foreach (Socket item in clientlist) // send all client in list
            //{
            //    Send(item, LoginAccount.UserName, txbSubject.Text, txbContentMail.Text);
            //    SaveMailSent(txbAddressSend.Text, txbSubject.Text, txbContentMail.Text, LoginAccount.UserName);
            //}

            Send(clientAcc, LoginAccount.UserName, txbSubject.Text, txbContentMail.Text);
            SaveMailSent(txbAddressSend.Text, txbSubject.Text, txbContentMail.Text, LoginAccount.UserName);

        }
        #region Socket
        /// <summary>
        /// Ket noi toi server
        /// </summary>
        public void Connect()
        {
            clientlist = new List<Socket>();
            //ip địa chỉ của server
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(10);
                        Socket client = server.Accept();
                        //clientlist.Add(client); // Add client to list client

                        clientAcc = client;
                        SendIden( clientAcc,LoginAccount.UserName);// send name of address

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);

                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }

            });

            Listen.IsBackground = true;
            Listen.Start();
        }
        /// <summary>
        /// dong ket noi den server
        /// </summary>
        void Closeconnect()
        {
            server.Close();
        }
        /// <summary>
        /// gui tin
        /// </summary>
        void Send(Socket client, string name, string subject, string ConTentMail)
        {
            if (client != null && ConTentMail != string.Empty && name != string.Empty && subject != string.Empty)
            {
                client.Send(Serialize("NAME:" + name + "SUBJECT:" + subject));
                client.Send(Serialize("CONTENT: " + ConTentMail));
            }
        }
        public void SendIden(Socket client, string name)
        {
            if (name != string.Empty)
            {
                client.Send(Serialize("IDENTITY: " + name));
            }
        }


        /// <summary>
        /// nhan tin
        /// </summary>
        void Receive(object obj)
        {
           

            Socket client = obj as Socket;
            try
            {

                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);

                    if (message.Contains("NAME:"))
                    {
                        StrName = FuntionGetNameSubjectContent(message, 1);
                        StrSubject = FuntionGetNameSubjectContent(message, 0);
                        StrTime = DateTime.Now.ToString();                     
                    }
                    else if (message.Contains("CONTENT:"))
                    {
                        StrContent = FuntionGetNameSubjectContent(message,2);                      
                        SaveMailReceived(StrName, StrSubject, StrContent);
                       

                    }
                    else if (message.Contains("IDENTITY:"))
                    {
                        NameAddress = FuntionGetNameSubjectContent(message, 3);                     
                    }

                    //gửi cho toàn bộ các client còn lại
                    //
                    //foreach (Socket item in clientlist)
                    //{
                    //    if (item != null && item != client)
                    //        item.Send(Serialize(message));
                    //}

                   

                }
            }
            catch
            {
                clientlist.Remove(client);
                //client.Close();
            }

        }


        /// <summary>
        /// thêm messaga vào khung chat
        /// </summary>
        /// <param name="s"></param>

    
        /// <summary>
        /// phân mảng 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        byte[] Serialize(Object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        /// <summary>
        /// gộp mảng
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);

        }
        /// <summary>
        /// đóng kết nói khi đóng form server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        #endregion

        #region Method
        public string FuntionGetNameSubjectContent(string s, int t)
        {
            string sString = " ";
            if (t == 1)// t== 1 sẽ trả về NAME:
            {
                int i = s.IndexOf("SUBJECT");
                if (i >= 0) sString = s.Substring(5, i - 5); // cắt chuỗi để lấy nội dung của NAME              
            }
            else if (t == 0)//t == 0 sẽ trả về Subject:
            {
                int i = s.IndexOf("SUBJECT");
                if (i >= 0) sString = s.Substring(i + 8); // cắt chuỗi để lấy nội dung của SUBJECT
            }
            else if (t == 2)
            {
                int i = s.IndexOf("CONTENT");
                if (i >= 0) sString = s.Substring(8);
            }
            else
            {
                int i = s.IndexOf("IDENTITY");
                if (i >= 0) sString = s.Substring(9);
            }
            return sString;
        }

        void SaveMailReceived(string strName, string strSubject, string strContent)
        {
            int idCurrentMail = 0;
            if (MailDAO.Instance.InsertMail(strName, strSubject, strContent, LoginAccount.UserName))
            {
                idCurrentMail = MailDAO.Instance.GetLastIdMail();
                if (idCurrentMail > 0)
                {
                    if (ListMailReceivedDAO.Instance.InsertMailReceived(idCurrentMail, DateTime.Now.ToString()))
                    {
                    ntfIconServer.BalloonTipTitle = "You got Mail!";
                    ntfIconServer.BalloonTipText = strSubject;
                    ntfIconServer.BalloonTipIcon = ToolTipIcon.Info;
                    ntfIconServer.ShowBalloonTip(5000);
                    }
                }
                else
                {
                    MessageBox.Show("Cannot get id mail!");
                }
            }
        }
        void SaveMailSent(string strAddressSend, string strSubject, string strContent, string strMailOwner)
        {
            int idCurrentMail = 0;
            if (MailDAO.Instance.InsertMail(strAddressSend, strSubject, strContent, strMailOwner))
            {
                idCurrentMail = MailDAO.Instance.GetLastIdMail();
                if (idCurrentMail > 0)
                {
                    if (ListMailSentDAO.Instance.InsertMailSent(idCurrentMail, DateTime.Now.ToString())) { }

                }
            }
        }
        #endregion
     
        private void btnGetNameAddress2_Click(object sender, EventArgs e)
        {
            txbAddressSend.Text = NameAddress;
        }
        private void fComposeMail2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Closeconnect();
          
        }

       
    }
}
