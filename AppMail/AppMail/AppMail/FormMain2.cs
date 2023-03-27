using AppMail.DAO;
using AppMail.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AppMail
{
    public partial class FormMain2 : Form
    {
        #region declare
        private static int switchMethod;
        private static int mailID;
        private static string strName;
        private static string strTime;
        private static string strSubject;
        private static string strContent;
        private static string strIP;
        private string nameAddress;
        public static string StrName { get => strName; set => strName = value; }
        public static string StrTime { get => strTime; set => strTime = value; }
        public static string StrContent { get => strContent; set => strContent = value; }
        public static string StrSubject { get => strSubject; set => strSubject = value; }
        public static string StrIP { get => strIP; set => strIP = value; }
        public static int SwitchMethod { get => switchMethod; set => switchMethod = value; }
        public static int MailID { get => mailID; set => mailID = value; }

        public string NameAddress { get => nameAddress; set => nameAddress = value; }

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        



        #endregion

        [Obsolete]
        public FormMain2(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;

            toolStripTxbIP.Text = GetLocalIPAddress();

            btnMailListInfo.Enabled = false;
            closeConnectToolStripMenuItem.Enabled = false;

            LoadMailList(0);
        }


        void ChangeAccount(int type)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text += "(" + LoginAccount.FirstName + " " + LoginAccount.LastName + ")";
            if (type != 1)
                userToolStripMenuItemAccount.Enabled = false;
        }

            
        void LoadMailList(int c) //0: list receive , 1: list sent
        {
            string time = "";
            List<Mail> listMail = new List<Mail>();
            if(c == 0)
            {
                listMail = MailDAO.Instance.GetListMailReceived(LoginAccount.UserName);
                ResetColorButton();
                btnMailReceived.BackColor = Color.LimeGreen;
                btnMailListInfo.BackColor = Color.LimeGreen;
            }
               
            else
            {
                listMail = MailDAO.Instance.GetListMailSent(LoginAccount.UserName);
                ResetColorButton();
                btnSentMail.BackColor = Color.LimeGreen;
                btnMailListInfo.BackColor = Color.LimeGreen;
            }
            if(listMail != null) // check null
            {
                flpMailList.Controls.Clear();
                foreach (Mail item in listMail)
                {
                    Button btn = new Button() { Width = 540, Height = 50 };//tạo ra 1 button vs chiều dài và rộng chỉ định
                    if (c == 0)
                    {
                        time = ListMailReceivedDAO.Instance.GetTimeReceivedByIDMail(item.ID);
                        btn.Text =  " " + "[" + time + "] - " + item.StrName + " ✉: " + item.StrSubject;
                        btn.TextAlign = ContentAlignment.MiddleLeft;
                        switch (item.Status)
                        {
                            case 1:
                                btn.BackColor = Color.Azure; // Read
                                break;

                            default:
                                btn.BackColor = Color.Aqua; // not read
                                break;
                        }
                    }
                    else
                    {
                        time = ListMailSentDAO.Instance.GetTimeSentByIDMail(item.ID);
                        btn.Text = "○" + " [" + time + "] - " + item.UserNameAccount + " ✉: " + item.StrSubject;
                        btn.TextAlign = ContentAlignment.MiddleLeft;
                    }



                    btn.Click += btn_Click; // tạo event mỗi lần click vào

                    btn.Tag = item;// lưu thông tin vào button


                    flpMailList.Controls.Add(btn);
                }
           
            }
            else
            {
                Button btn = new Button() { Width = 540, Height = 50 };//tạo ra 1 button vs chiều dài và rộng chỉ định
                btn.Text = "No mail right now!";
                flpMailList.Controls.Add(btn);
            }
           
        }
        void btn_Click(object sender, EventArgs e)// hàm sự kiện click button
        {
            MailID = ((sender as Button).Tag as Mail).ID;// đánh tag cho button = maiID
            StrSubject = ((sender as Button).Tag as Mail).StrSubject;
            StrContent = ((sender as Button).Tag as Mail).StrContent;
            StrName = ((sender as Button).Tag as Mail).StrName;
            
            if(SwitchMethod == 0)
                StrTime = ListMailReceivedDAO.Instance.GetTimeReceivedByIDMail(MailID);
            else
                StrTime = ListMailSentDAO.Instance.GetTimeSentByIDMail(MailID);

            MailDAO.Instance.UpdateMailStatus(MailID, 1); // đặt lại trạng thái cho mail

            if(switchMethod == 0)
                LoadMailList(0);
            else 
                LoadMailList(1);

            #region event
            fShowMail fMail = new fShowMail();
            fMail.DeleteMail += FMail_DeleteMail; // event delete mail

           
            #endregion
            fMail.ShowDialog();

           
            
        }

       

        void ResetColorButton()
        {
            btnMailing.BackColor = Color.Transparent;
            btnMailReceived.BackColor = Color.Transparent;
            btnSentMail.BackColor = Color.Transparent;
            btnMailListInfo.BackColor = Color.Transparent;
        }
        #region event

        private void FMail_DeleteMail(object sender, EventArgs e)
        {
            LoadMailList(1);
        }
        private void FCompose_ReceiveMail(object sender, EventArgs e)
        {
            LoadMailList(0);
        }
        private void FCompose2_ReceiveMail(object sender, EventArgs e)
        {
            LoadMailList(0);
        }
        #endregion
        #region Method

        public static bool ServicePing(string address, int port) // check server exist
        {
            bool serviceOnline;

            TcpClient tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect(address, port);
                serviceOnline = true;     // Service is online. No exception thrown.
            }
            catch (Exception)
            {
                serviceOnline = false;    // Exception was thrown. Service is offline
            }

            return serviceOnline;
        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        [Obsolete]
        string GetIPLocal()
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST        
            // Get the IP
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            return myIP;
        }

        #endregion

        private void btnMailing_Click_1(object sender, EventArgs e)
        {
            StrIP = toolStripTxbIP.Text;
            if (ServicePing(StrIP, 9999) == true)// kiểm tra server có đang chạy
            {
                Connect();
                //btnMailListInfo.Enabled = true;

            }
            else
            {
                fComposeMail2 cMail = new fComposeMail2(LoginAccount); // server form(form soạn mail)
                this.Hide();             
                cMail.ShowDialog();            
                this.Show();
            }


        }

        private void btnMailReceived_Click_1(object sender, EventArgs e)
        {
            SwitchMethod = 0;
            LoadMailList(0);
        }
        
        

        private void btnSentMail_Click(object sender, EventArgs e)
        {
            SwitchMethod = 1;         
            LoadMailList(1);
        }
        private void FormMain2_FormClosed(object sender, FormClosedEventArgs e)
        {

           

        }

        private void userToolStripMenuItemAccount_Click(object sender, EventArgs e)
        {
            fAccountManager formAccManager = new fAccountManager();
            formAccManager.LoginAccount = LoginAccount;
            formAccManager.ShowDialog();
        }

        private void editAccountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fEditAccountInfo fe = new fEditAccountInfo(LoginAccount);
            fe.UpdateAccount += Fe_UpdateAccount;
            fe.ShowDialog();
        }

        private void Fe_UpdateAccount(object sender, fEditAccountInfo.AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "(" + LoginAccount.FirstName + " " + LoginAccount.LastName + ")";
        }

        private void btnMailListInfo_Click(object sender, EventArgs e)
        {
            //Connect();
            //Closeconnect();
            //btnMailListInfo.Enabled = false;
            //closeConnectToolStripMenuItem.Enabled = true;
        }

        #region Socket client

        IPEndPoint IP;
        Socket client;

        /// <summary>
        /// Ket noi toi server
        /// </summary>
        void Connect()
        {

            //ip địa chỉ của server
            IP = new IPEndPoint(IPAddress.Parse(StrIP), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
                SendIden(LoginAccount.UserName);
            }
            catch
            {
                MessageBox.Show("Ko the ket noi den server", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();

            
        }
        /// <summary>
        /// dong ket noi den server
        /// </summary>
        void Closeconnect()
        {
            client.Close();
        }

        /// <summary>
        /// gui tin
        /// </summary>
        public void Send(string name, string subject, string ConTentMail)
        {
            if (ConTentMail != string.Empty && name != string.Empty && subject != string.Empty)
            {
                client.Send(Serialize("NAME:" + name + "SUBJECT:" + subject));
                client.Send(Serialize("CONTENT: " + ConTentMail));
            }
        }
        public void SendIden(string name)
        {
            if (name != string.Empty)
            {
                client.Send(Serialize("IDENTITY: " + name));
            }
        }
        /// <summary>
        /// nhan tin
        /// </summary>
        void Receive()
        {

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
                        StrContent = FuntionGetNameSubjectContent(message, 2);
                        SaveMailReceived(StrName, StrSubject, StrContent);
                        

                    }
                    else if (message.Contains("IDENTITY:"))
                    {
                        NameAddress = FuntionGetNameSubjectContent(message, 3);

                    }


                }
            }
            catch
            {
                Close();
            }
        }

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
                        ntfIconClient.BalloonTipTitle = "You got Mail from " + FormMain2.StrName + "!";
                        ntfIconClient.BalloonTipText = strSubject;
                        ntfIconClient.BalloonTipIcon = ToolTipIcon.Info;
                        ntfIconClient.ShowBalloonTip(5000);
                    }
                }
                else
                {
                    MessageBox.Show("Cannot get id mail!");
                }

            }
        }


        #endregion

        #endregion

        private void closeConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Closeconnect();
            closeConnectToolStripMenuItem.Enabled = false;
        }

        private void FormMain2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the program?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
