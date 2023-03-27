
namespace AppMail
{
    partial class FormMain2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain2));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSentMail = new System.Windows.Forms.Button();
            this.btnMailReceived = new System.Windows.Forms.Button();
            this.btnMailing = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpMailList = new System.Windows.Forms.FlowLayoutPanel();
            this.adminToolStripMenuItem = new System.Windows.Forms.MenuStrip();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTxbIP = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editAccountInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItemAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMailListInfo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ntfIconClient = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.adminToolStripMenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSentMail);
            this.panel2.Controls.Add(this.btnMailReceived);
            this.panel2.Controls.Add(this.btnMailing);
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 126);
            this.panel2.TabIndex = 5;
            // 
            // btnSentMail
            // 
            this.btnSentMail.AutoSize = true;
            this.btnSentMail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSentMail.Location = new System.Drawing.Point(3, 84);
            this.btnSentMail.Name = "btnSentMail";
            this.btnSentMail.Size = new System.Drawing.Size(190, 36);
            this.btnSentMail.TabIndex = 2;
            this.btnSentMail.Text = "▐ 📨 Sent Mail";
            this.btnSentMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSentMail.UseVisualStyleBackColor = true;
            this.btnSentMail.Click += new System.EventHandler(this.btnSentMail_Click);
            // 
            // btnMailReceived
            // 
            this.btnMailReceived.AutoSize = true;
            this.btnMailReceived.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMailReceived.Location = new System.Drawing.Point(3, 43);
            this.btnMailReceived.Name = "btnMailReceived";
            this.btnMailReceived.Size = new System.Drawing.Size(190, 36);
            this.btnMailReceived.TabIndex = 1;
            this.btnMailReceived.Text = "▐ 📩 Mail Received";
            this.btnMailReceived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMailReceived.UseVisualStyleBackColor = true;
            this.btnMailReceived.Click += new System.EventHandler(this.btnMailReceived_Click_1);
            // 
            // btnMailing
            // 
            this.btnMailing.AutoSize = true;
            this.btnMailing.BackColor = System.Drawing.Color.Transparent;
            this.btnMailing.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMailing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMailing.Location = new System.Drawing.Point(3, 3);
            this.btnMailing.Name = "btnMailing";
            this.btnMailing.Size = new System.Drawing.Size(190, 36);
            this.btnMailing.TabIndex = 0;
            this.btnMailing.Text = "▐ ✉️ Mailing";
            this.btnMailing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMailing.UseVisualStyleBackColor = false;
            this.btnMailing.Click += new System.EventHandler(this.btnMailing_Click_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.flpMailList);
            this.panel1.Location = new System.Drawing.Point(204, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 328);
            this.panel1.TabIndex = 4;
            // 
            // flpMailList
            // 
            this.flpMailList.AutoScroll = true;
            this.flpMailList.BackColor = System.Drawing.Color.Azure;
            this.flpMailList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpMailList.Location = new System.Drawing.Point(4, 3);
            this.flpMailList.Name = "flpMailList";
            this.flpMailList.Size = new System.Drawing.Size(581, 319);
            this.flpMailList.TabIndex = 0;
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.adminToolStripMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.userToolStripMenuItemAccount});
            this.adminToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(806, 24);
            this.adminToolStripMenuItem.TabIndex = 3;
            this.adminToolStripMenuItem.Text = "menuStrip1";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTxbIP,
            this.toolStripSeparator1,
            this.editAccountInfoToolStripMenuItem,
            this.closeConnectToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "✦Info";
            // 
            // toolStripTxbIP
            // 
            this.toolStripTxbIP.Name = "toolStripTxbIP";
            this.toolStripTxbIP.Size = new System.Drawing.Size(100, 23);
            this.toolStripTxbIP.Text = "192.168.1.150";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // editAccountInfoToolStripMenuItem
            // 
            this.editAccountInfoToolStripMenuItem.Name = "editAccountInfoToolStripMenuItem";
            this.editAccountInfoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.editAccountInfoToolStripMenuItem.Text = "Edit Account Info";
            this.editAccountInfoToolStripMenuItem.Click += new System.EventHandler(this.editAccountInfoToolStripMenuItem_Click);
            // 
            // closeConnectToolStripMenuItem
            // 
            this.closeConnectToolStripMenuItem.Name = "closeConnectToolStripMenuItem";
            this.closeConnectToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.closeConnectToolStripMenuItem.Text = "Close connect";
            this.closeConnectToolStripMenuItem.Click += new System.EventHandler(this.closeConnectToolStripMenuItem_Click);
            // 
            // userToolStripMenuItemAccount
            // 
            this.userToolStripMenuItemAccount.AccessibleDescription = "";
            this.userToolStripMenuItemAccount.Name = "userToolStripMenuItemAccount";
            this.userToolStripMenuItemAccount.Size = new System.Drawing.Size(74, 20);
            this.userToolStripMenuItemAccount.Text = "📓Account";
            this.userToolStripMenuItemAccount.ToolTipText = "Account Manager for account type admin\r\n";
            this.userToolStripMenuItemAccount.Click += new System.EventHandler(this.userToolStripMenuItemAccount_Click);
            // 
            // btnMailListInfo
            // 
            this.btnMailListInfo.AutoSize = true;
            this.btnMailListInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMailListInfo.Location = new System.Drawing.Point(204, 29);
            this.btnMailListInfo.Name = "btnMailListInfo";
            this.btnMailListInfo.Size = new System.Drawing.Size(592, 36);
            this.btnMailListInfo.TabIndex = 7;
            this.btnMailListInfo.Text = "List Mail                                                      ⬇⬇⬇";
            this.btnMailListInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMailListInfo.UseVisualStyleBackColor = true;
            this.btnMailListInfo.Click += new System.EventHandler(this.btnMailListInfo_Click);
            // 
            // ntfIconClient
            // 
            this.ntfIconClient.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfIconClient.Icon")));
            this.ntfIconClient.Text = "notifyIcon1";
            this.ntfIconClient.Visible = true;
            // 
            // FormMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 408);
            this.Controls.Add(this.btnMailListInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminToolStripMenuItem);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain2";
            this.Text = "Mail App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain2_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.adminToolStripMenuItem.ResumeLayout(false);
            this.adminToolStripMenuItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSentMail;
        private System.Windows.Forms.Button btnMailReceived;
        private System.Windows.Forms.Button btnMailing;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpMailList;
        private System.Windows.Forms.MenuStrip adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItemAccount;
        private System.Windows.Forms.ToolStripTextBox toolStripTxbIP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnMailListInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem editAccountInfoToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon ntfIconClient;
        private System.Windows.Forms.ToolStripMenuItem closeConnectToolStripMenuItem;
    }
}