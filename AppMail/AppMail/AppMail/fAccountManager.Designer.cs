
namespace AppMail
{
    partial class fAccountManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAccountManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel23 = new System.Windows.Forms.Panel();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnEditAccountInfo = new System.Windows.Forms.Button();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.panel26 = new System.Windows.Forms.Panel();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel29 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.panel23);
            this.panel1.Controls.Add(this.panel24);
            this.panel1.Controls.Add(this.panel29);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 408);
            this.panel1.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnConfirm.Location = new System.Drawing.Point(535, 8);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 46);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "✔️";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.btnShowAccount);
            this.panel23.Controls.Add(this.btnEditAccount);
            this.panel23.Controls.Add(this.btnDeleteAccount);
            this.panel23.Controls.Add(this.btnEditAccountInfo);
            this.panel23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel23.Location = new System.Drawing.Point(5, 3);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(321, 53);
            this.panel23.TabIndex = 9;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Location = new System.Drawing.Point(243, 4);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(75, 46);
            this.btnShowAccount.TabIndex = 3;
            this.btnShowAccount.Text = "Show";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(166, 4);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(75, 46);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.Text = "Edit";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(85, 4);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(75, 46);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnEditAccountInfo
            // 
            this.btnEditAccountInfo.Location = new System.Drawing.Point(4, 4);
            this.btnEditAccountInfo.Name = "btnEditAccountInfo";
            this.btnEditAccountInfo.Size = new System.Drawing.Size(75, 46);
            this.btnEditAccountInfo.TabIndex = 0;
            this.btnEditAccountInfo.Text = "Add";
            this.btnEditAccountInfo.UseVisualStyleBackColor = true;
            this.btnEditAccountInfo.Click += new System.EventHandler(this.btnEditAccountInfo_Click);
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.panel2);
            this.panel24.Controls.Add(this.btnResetPassword);
            this.panel24.Controls.Add(this.panel26);
            this.panel24.Controls.Add(this.panel27);
            this.panel24.Controls.Add(this.panel28);
            this.panel24.Location = new System.Drawing.Point(328, 60);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(286, 345);
            this.panel24.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbLastName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 44);
            this.panel2.TabIndex = 6;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(131, 11);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(140, 23);
            this.txbLastName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "LastName:";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetPassword.Location = new System.Drawing.Point(134, 203);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(139, 38);
            this.btnResetPassword.TabIndex = 5;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.cbAccountType);
            this.panel26.Controls.Add(this.label11);
            this.panel26.Location = new System.Drawing.Point(3, 153);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(279, 44);
            this.panel26.TabIndex = 4;
            // 
            // cbAccountType
            // 
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Location = new System.Drawing.Point(131, 11);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(139, 23);
            this.cbAccountType.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Type:";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.txbFirstName);
            this.panel27.Controls.Add(this.label12);
            this.panel27.Location = new System.Drawing.Point(4, 53);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(279, 44);
            this.panel27.TabIndex = 3;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(131, 11);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(140, 23);
            this.txbFirstName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(3, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "FirstName:";
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.txbUserName);
            this.panel28.Controls.Add(this.label13);
            this.panel28.Location = new System.Drawing.Point(4, 3);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(279, 44);
            this.panel28.TabIndex = 2;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(131, 11);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(140, 23);
            this.txbUserName.TabIndex = 1;
            this.txbUserName.TextChanged += new System.EventHandler(this.txbUserName_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(3, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "UserName:";
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.dtgvAccount);
            this.panel29.Location = new System.Drawing.Point(5, 60);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(321, 345);
            this.panel29.TabIndex = 7;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(3, 2);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowTemplate.Height = 25;
            this.dtgvAccount.Size = new System.Drawing.Size(314, 338);
            this.dtgvAccount.TabIndex = 0;
            // 
            // fAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 432);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAccountManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Manager";
            this.panel1.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnEditAccountInfo;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
    }
}