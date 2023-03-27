
namespace AppMail
{
    partial class fComposeMail2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fComposeMail2));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txbContentMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetNameAddress = new System.Windows.Forms.Panel();
            this.btnGetNameAddress2 = new System.Windows.Forms.Button();
            this.lbMailAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAddressSend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ntfIconServer = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel2.SuspendLayout();
            this.btnGetNameAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.txbContentMail);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 230);
            this.panel2.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.Location = new System.Drawing.Point(451, 187);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 39);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txbContentMail
            // 
            this.txbContentMail.AllowDrop = true;
            this.txbContentMail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbContentMail.Location = new System.Drawing.Point(113, 7);
            this.txbContentMail.Multiline = true;
            this.txbContentMail.Name = "txbContentMail";
            this.txbContentMail.Size = new System.Drawing.Size(459, 174);
            this.txbContentMail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "CONTENT:";
            // 
            // btnGetNameAddress
            // 
            this.btnGetNameAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGetNameAddress.Controls.Add(this.btnGetNameAddress2);
            this.btnGetNameAddress.Controls.Add(this.lbMailAddress);
            this.btnGetNameAddress.Controls.Add(this.label4);
            this.btnGetNameAddress.Controls.Add(this.txbSubject);
            this.btnGetNameAddress.Controls.Add(this.label2);
            this.btnGetNameAddress.Controls.Add(this.txbAddressSend);
            this.btnGetNameAddress.Controls.Add(this.label1);
            this.btnGetNameAddress.Location = new System.Drawing.Point(12, 12);
            this.btnGetNameAddress.Name = "btnGetNameAddress";
            this.btnGetNameAddress.Size = new System.Drawing.Size(577, 101);
            this.btnGetNameAddress.TabIndex = 2;
            // 
            // btnGetNameAddress2
            // 
            this.btnGetNameAddress2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetNameAddress2.Location = new System.Drawing.Point(546, 34);
            this.btnGetNameAddress2.Name = "btnGetNameAddress2";
            this.btnGetNameAddress2.Size = new System.Drawing.Size(26, 28);
            this.btnGetNameAddress2.TabIndex = 7;
            this.btnGetNameAddress2.Text = "☑";
            this.btnGetNameAddress2.UseVisualStyleBackColor = true;
            this.btnGetNameAddress2.Click += new System.EventHandler(this.btnGetNameAddress2_Click);
            // 
            // lbMailAddress
            // 
            this.lbMailAddress.AutoSize = true;
            this.lbMailAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMailAddress.Location = new System.Drawing.Point(113, 10);
            this.lbMailAddress.Name = "lbMailAddress";
            this.lbMailAddress.Size = new System.Drawing.Size(57, 19);
            this.lbMailAddress.TabIndex = 5;
            this.lbMailAddress.Text = "FROM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "FROM:";
            // 
            // txbSubject
            // 
            this.txbSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSubject.Location = new System.Drawing.Point(113, 66);
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.Size = new System.Drawing.Size(459, 26);
            this.txbSubject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "SUBJECT:";
            // 
            // txbAddressSend
            // 
            this.txbAddressSend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbAddressSend.Location = new System.Drawing.Point(113, 34);
            this.txbAddressSend.Name = "txbAddressSend";
            this.txbAddressSend.Size = new System.Drawing.Size(427, 26);
            this.txbAddressSend.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TO:";
            // 
            // ntfIconServer
            // 
            this.ntfIconServer.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfIconServer.Icon")));
            this.ntfIconServer.Text = "notifyIcon1";
            this.ntfIconServer.Visible = true;
            // 
            // fComposeMail2
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 349);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGetNameAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fComposeMail2";
            this.Text = "Compose Mail*";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fComposeMail2_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.btnGetNameAddress.ResumeLayout(false);
            this.btnGetNameAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txbContentMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel btnGetNameAddress;
        private System.Windows.Forms.Label lbMailAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAddressSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon ntfIconServer;
        private System.Windows.Forms.Button btnGetNameAddress2;
    }
}