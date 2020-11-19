namespace Napier_Bank_Coursework
{
    partial class Send
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
            this.txtMessageHeader = new System.Windows.Forms.TextBox();
            this.txtMessageBody = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtField1 = new System.Windows.Forms.TextBox();
            this.txtField2 = new System.Windows.Forms.TextBox();
            this.txtField3 = new System.Windows.Forms.TextBox();
            this.txtMessageBox = new System.Windows.Forms.TextBox();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblSubTitleSend = new System.Windows.Forms.Label();
            this.lblSubTitleReceived = new System.Windows.Forms.Label();
            this.lblField1 = new System.Windows.Forms.Label();
            this.lblField2 = new System.Windows.Forms.Label();
            this.lblField3 = new System.Windows.Forms.Label();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblField4 = new System.Windows.Forms.Label();
            this.txtField4 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtMessageHeader
            // 
            this.txtMessageHeader.Location = new System.Drawing.Point(110, 73);
            this.txtMessageHeader.Name = "txtMessageHeader";
            this.txtMessageHeader.Size = new System.Drawing.Size(382, 20);
            this.txtMessageHeader.TabIndex = 0;
            // 
            // txtMessageBody
            // 
            this.txtMessageBody.Location = new System.Drawing.Point(110, 158);
            this.txtMessageBody.Multiline = true;
            this.txtMessageBody.Name = "txtMessageBody";
            this.txtMessageBody.Size = new System.Drawing.Size(382, 231);
            this.txtMessageBody.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(609, 104);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(625, 340);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtField1
            // 
            this.txtField1.Location = new System.Drawing.Point(868, 73);
            this.txtField1.Name = "txtField1";
            this.txtField1.ReadOnly = true;
            this.txtField1.Size = new System.Drawing.Size(310, 20);
            this.txtField1.TabIndex = 4;
            // 
            // txtField2
            // 
            this.txtField2.Location = new System.Drawing.Point(868, 108);
            this.txtField2.Name = "txtField2";
            this.txtField2.ReadOnly = true;
            this.txtField2.Size = new System.Drawing.Size(310, 20);
            this.txtField2.TabIndex = 5;
            // 
            // txtField3
            // 
            this.txtField3.Location = new System.Drawing.Point(868, 147);
            this.txtField3.Name = "txtField3";
            this.txtField3.ReadOnly = true;
            this.txtField3.Size = new System.Drawing.Size(310, 20);
            this.txtField3.TabIndex = 6;
            // 
            // txtMessageBox
            // 
            this.txtMessageBox.Location = new System.Drawing.Point(868, 270);
            this.txtMessageBox.Multiline = true;
            this.txtMessageBox.Name = "txtMessageBox";
            this.txtMessageBox.ReadOnly = true;
            this.txtMessageBox.Size = new System.Drawing.Size(310, 158);
            this.txtMessageBox.TabIndex = 7;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Location = new System.Drawing.Point(110, 22);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(102, 13);
            this.lblPageTitle.TabIndex = 8;
            this.lblPageTitle.Text = "Message Send Test";
            // 
            // lblSubTitleSend
            // 
            this.lblSubTitleSend.AutoSize = true;
            this.lblSubTitleSend.Location = new System.Drawing.Point(113, 54);
            this.lblSubTitleSend.Name = "lblSubTitleSend";
            this.lblSubTitleSend.Size = new System.Drawing.Size(74, 13);
            this.lblSubTitleSend.TabIndex = 9;
            this.lblSubTitleSend.Text = "Test Message";
            // 
            // lblSubTitleReceived
            // 
            this.lblSubTitleReceived.AutoSize = true;
            this.lblSubTitleReceived.Location = new System.Drawing.Point(868, 23);
            this.lblSubTitleReceived.Name = "lblSubTitleReceived";
            this.lblSubTitleReceived.Size = new System.Drawing.Size(99, 13);
            this.lblSubTitleReceived.TabIndex = 10;
            this.lblSubTitleReceived.Text = "Received Message";
            // 
            // lblField1
            // 
            this.lblField1.AutoSize = true;
            this.lblField1.Location = new System.Drawing.Point(785, 74);
            this.lblField1.Name = "lblField1";
            this.lblField1.Size = new System.Drawing.Size(77, 13);
            this.lblField1.TabIndex = 11;
            this.lblField1.Text = "Message Type";
            // 
            // lblField2
            // 
            this.lblField2.AutoSize = true;
            this.lblField2.Location = new System.Drawing.Point(788, 114);
            this.lblField2.Name = "lblField2";
            this.lblField2.Size = new System.Drawing.Size(64, 13);
            this.lblField2.TabIndex = 12;
            this.lblField2.Text = "Message ID";
            // 
            // lblField3
            // 
            this.lblField3.AutoSize = true;
            this.lblField3.Location = new System.Drawing.Point(788, 153);
            this.lblField3.Name = "lblField3";
            this.lblField3.Size = new System.Drawing.Size(41, 13);
            this.lblField3.TabIndex = 13;
            this.lblField3.Text = "Sender";
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.AutoSize = true;
            this.lblMessageBox.Location = new System.Drawing.Point(776, 270);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(74, 13);
            this.lblMessageBox.TabIndex = 14;
            this.lblMessageBox.Text = "Message Text";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(609, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblField4
            // 
            this.lblField4.AutoSize = true;
            this.lblField4.Location = new System.Drawing.Point(788, 188);
            this.lblField4.Name = "lblField4";
            this.lblField4.Size = new System.Drawing.Size(43, 13);
            this.lblField4.TabIndex = 16;
            this.lblField4.Text = "Subject";
            // 
            // txtField4
            // 
            this.txtField4.Location = new System.Drawing.Point(868, 188);
            this.txtField4.Name = "txtField4";
            this.txtField4.ReadOnly = true;
            this.txtField4.Size = new System.Drawing.Size(310, 20);
            this.txtField4.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1224, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 95);
            this.listBox1.TabIndex = 18;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(1224, 188);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(247, 95);
            this.listBox2.TabIndex = 19;
            // 
            // Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtField4);
            this.Controls.Add(this.lblField4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMessageBox);
            this.Controls.Add(this.lblField3);
            this.Controls.Add(this.lblField2);
            this.Controls.Add(this.lblField1);
            this.Controls.Add(this.lblSubTitleReceived);
            this.Controls.Add(this.lblSubTitleSend);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.txtMessageBox);
            this.Controls.Add(this.txtField3);
            this.Controls.Add(this.txtField2);
            this.Controls.Add(this.txtField1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessageBody);
            this.Controls.Add(this.txtMessageHeader);
            this.Name = "Send";
            this.Text = "Send";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessageHeader;
        private System.Windows.Forms.TextBox txtMessageBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtField1;
        private System.Windows.Forms.TextBox txtField2;
        private System.Windows.Forms.TextBox txtField3;
        private System.Windows.Forms.TextBox txtMessageBox;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblSubTitleSend;
        private System.Windows.Forms.Label lblSubTitleReceived;
        private System.Windows.Forms.Label lblField1;
        private System.Windows.Forms.Label lblField2;
        private System.Windows.Forms.Label lblField3;
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblField4;
        private System.Windows.Forms.TextBox txtField4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}