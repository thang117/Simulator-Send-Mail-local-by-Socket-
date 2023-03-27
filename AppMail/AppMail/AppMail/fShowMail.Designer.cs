
namespace AppMail
{
    partial class fShowMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fShowMail));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRecallMail = new System.Windows.Forms.Button();
            this.txbContentMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbMailAddress = new System.Windows.Forms.Label();
            this.lbFromTo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRecallMail);
            this.panel2.Controls.Add(this.txbContentMail);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 236);
            this.panel2.TabIndex = 3;
            // 
            // btnRecallMail
            // 
            this.btnRecallMail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRecallMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecallMail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRecallMail.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRecallMail.Location = new System.Drawing.Point(24, 202);
            this.btnRecallMail.Name = "btnRecallMail";
            this.btnRecallMail.Size = new System.Drawing.Size(84, 23);
            this.btnRecallMail.TabIndex = 5;
            this.btnRecallMail.Text = "Recall Mail";
            this.btnRecallMail.UseVisualStyleBackColor = false;
            this.btnRecallMail.Click += new System.EventHandler(this.btnRecallMail_Click);
            // 
            // txbContentMail
            // 
            this.txbContentMail.AllowDrop = true;
            this.txbContentMail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbContentMail.Location = new System.Drawing.Point(113, 10);
            this.txbContentMail.Multiline = true;
            this.txbContentMail.Name = "txbContentMail";
            this.txbContentMail.ReadOnly = true;
            this.txbContentMail.Size = new System.Drawing.Size(459, 215);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbSubject);
            this.panel1.Controls.Add(this.lbMailAddress);
            this.panel1.Controls.Add(this.lbFromTo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 79);
            this.panel1.TabIndex = 2;
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSubject.Location = new System.Drawing.Point(113, 44);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(52, 19);
            this.lbSubject.TabIndex = 6;
            this.lbSubject.Text = "subject";
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
            // lbFromTo
            // 
            this.lbFromTo.AutoSize = true;
            this.lbFromTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFromTo.Location = new System.Drawing.Point(24, 10);
            this.lbFromTo.Name = "lbFromTo";
            this.lbFromTo.Size = new System.Drawing.Size(63, 19);
            this.lbFromTo.TabIndex = 4;
            this.lbFromTo.Text = "FROM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "SUBJECT:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTime.Location = new System.Drawing.Point(385, 349);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(34, 19);
            this.lbTime.TabIndex = 8;
            this.lbTime.Text = "time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(323, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "TIME:";
            // 
            // fShowMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 377);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fShowMail";
            this.Text = "Mail";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbContentMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbMailAddress;
        private System.Windows.Forms.Label lbFromTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRecallMail;
    }
}