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
            this.btnHome = new System.Windows.Forms.Button();
            this.txtField1 = new System.Windows.Forms.TextBox();
            this.txtField2 = new System.Windows.Forms.TextBox();
            this.txtField3 = new System.Windows.Forms.TextBox();
            this.txtMessageBox = new System.Windows.Forms.TextBox();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblSubTitleReceived = new System.Windows.Forms.Label();
            this.lblField1 = new System.Windows.Forms.Label();
            this.lblField2 = new System.Windows.Forms.Label();
            this.lblField3 = new System.Windows.Forms.Label();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.lblField4 = new System.Windows.Forms.Label();
            this.txtField4 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtField5 = new System.Windows.Forms.TextBox();
            this.txtField6 = new System.Windows.Forms.TextBox();
            this.lblField5 = new System.Windows.Forms.Label();
            this.lblField6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessageHeader = new System.Windows.Forms.TextBox();
            this.txtMessageBody = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblSubTitleSend = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.blMessageBody = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(550, 550);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 30);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtField1
            // 
            this.txtField1.Location = new System.Drawing.Point(650, 110);
            this.txtField1.Name = "txtField1";
            this.txtField1.ReadOnly = true;
            this.txtField1.Size = new System.Drawing.Size(310, 20);
            this.txtField1.TabIndex = 4;
            this.txtField1.TabStop = false;
            // 
            // txtField2
            // 
            this.txtField2.Location = new System.Drawing.Point(650, 150);
            this.txtField2.Name = "txtField2";
            this.txtField2.ReadOnly = true;
            this.txtField2.Size = new System.Drawing.Size(310, 20);
            this.txtField2.TabIndex = 5;
            this.txtField2.TabStop = false;
            // 
            // txtField3
            // 
            this.txtField3.Location = new System.Drawing.Point(650, 190);
            this.txtField3.Name = "txtField3";
            this.txtField3.ReadOnly = true;
            this.txtField3.Size = new System.Drawing.Size(310, 20);
            this.txtField3.TabIndex = 6;
            this.txtField3.TabStop = false;
            // 
            // txtMessageBox
            // 
            this.txtMessageBox.Location = new System.Drawing.Point(650, 350);
            this.txtMessageBox.Multiline = true;
            this.txtMessageBox.Name = "txtMessageBox";
            this.txtMessageBox.ReadOnly = true;
            this.txtMessageBox.Size = new System.Drawing.Size(310, 160);
            this.txtMessageBox.TabIndex = 7;
            this.txtMessageBox.TabStop = false;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPageTitle.Location = new System.Drawing.Point(502, 10);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(255, 31);
            this.lblPageTitle.TabIndex = 8;
            this.lblPageTitle.Text = "Message Send Test";
            // 
            // lblSubTitleReceived
            // 
            this.lblSubTitleReceived.AutoSize = true;
            this.lblSubTitleReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitleReceived.Location = new System.Drawing.Point(550, 70);
            this.lblSubTitleReceived.Name = "lblSubTitleReceived";
            this.lblSubTitleReceived.Size = new System.Drawing.Size(172, 24);
            this.lblSubTitleReceived.TabIndex = 10;
            this.lblSubTitleReceived.Text = "Received Message";
            // 
            // lblField1
            // 
            this.lblField1.AutoSize = true;
            this.lblField1.Location = new System.Drawing.Point(550, 110);
            this.lblField1.Name = "lblField1";
            this.lblField1.Size = new System.Drawing.Size(77, 13);
            this.lblField1.TabIndex = 11;
            this.lblField1.Text = "Message Type";
            // 
            // lblField2
            // 
            this.lblField2.AutoSize = true;
            this.lblField2.Location = new System.Drawing.Point(550, 150);
            this.lblField2.Name = "lblField2";
            this.lblField2.Size = new System.Drawing.Size(64, 13);
            this.lblField2.TabIndex = 12;
            this.lblField2.Text = "Message ID";
            // 
            // lblField3
            // 
            this.lblField3.AutoSize = true;
            this.lblField3.Location = new System.Drawing.Point(550, 190);
            this.lblField3.Name = "lblField3";
            this.lblField3.Size = new System.Drawing.Size(41, 13);
            this.lblField3.TabIndex = 13;
            this.lblField3.Text = "Sender";
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.AutoSize = true;
            this.lblMessageBox.Location = new System.Drawing.Point(550, 350);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(74, 13);
            this.lblMessageBox.TabIndex = 14;
            this.lblMessageBox.Text = "Message Text";
            // 
            // lblField4
            // 
            this.lblField4.AutoSize = true;
            this.lblField4.Location = new System.Drawing.Point(550, 230);
            this.lblField4.Name = "lblField4";
            this.lblField4.Size = new System.Drawing.Size(43, 13);
            this.lblField4.TabIndex = 16;
            this.lblField4.Text = "Subject";
            // 
            // txtField4
            // 
            this.txtField4.Location = new System.Drawing.Point(650, 230);
            this.txtField4.Name = "txtField4";
            this.txtField4.ReadOnly = true;
            this.txtField4.Size = new System.Drawing.Size(310, 20);
            this.txtField4.TabIndex = 17;
            this.txtField4.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1000, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 147);
            this.listBox1.TabIndex = 18;
            this.listBox1.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(1000, 310);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(250, 147);
            this.listBox2.TabIndex = 19;
            this.listBox2.TabStop = false;
            // 
            // txtField5
            // 
            this.txtField5.Location = new System.Drawing.Point(650, 270);
            this.txtField5.Name = "txtField5";
            this.txtField5.ReadOnly = true;
            this.txtField5.Size = new System.Drawing.Size(311, 20);
            this.txtField5.TabIndex = 20;
            this.txtField5.TabStop = false;
            // 
            // txtField6
            // 
            this.txtField6.Location = new System.Drawing.Point(650, 310);
            this.txtField6.Name = "txtField6";
            this.txtField6.ReadOnly = true;
            this.txtField6.Size = new System.Drawing.Size(311, 20);
            this.txtField6.TabIndex = 21;
            this.txtField6.TabStop = false;
            // 
            // lblField5
            // 
            this.lblField5.AutoSize = true;
            this.lblField5.Location = new System.Drawing.Point(550, 270);
            this.lblField5.Name = "lblField5";
            this.lblField5.Size = new System.Drawing.Size(54, 13);
            this.lblField5.TabIndex = 22;
            this.lblField5.Text = "Sort Code";
            // 
            // lblField6
            // 
            this.lblField6.AutoSize = true;
            this.lblField6.Location = new System.Drawing.Point(550, 310);
            this.lblField6.Name = "lblField6";
            this.lblField6.Size = new System.Drawing.Size(94, 13);
            this.lblField6.TabIndex = 23;
            this.lblField6.Text = "Nature Of Incident";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1000, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "List Data";
            // 
            // txtMessageHeader
            // 
            this.txtMessageHeader.Location = new System.Drawing.Point(120, 110);
            this.txtMessageHeader.Name = "txtMessageHeader";
            this.txtMessageHeader.Size = new System.Drawing.Size(382, 20);
            this.txtMessageHeader.TabIndex = 0;
            // 
            // txtMessageBody
            // 
            this.txtMessageBody.Location = new System.Drawing.Point(120, 150);
            this.txtMessageBody.Multiline = true;
            this.txtMessageBody.Name = "txtMessageBody";
            this.txtMessageBody.Size = new System.Drawing.Size(380, 230);
            this.txtMessageBody.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(150, 410);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblSubTitleSend
            // 
            this.lblSubTitleSend.AutoSize = true;
            this.lblSubTitleSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitleSend.Location = new System.Drawing.Point(20, 70);
            this.lblSubTitleSend.Name = "lblSubTitleSend";
            this.lblSubTitleSend.Size = new System.Drawing.Size(128, 24);
            this.lblSubTitleSend.TabIndex = 9;
            this.lblSubTitleSend.Text = "Test Message";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(395, 410);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(20, 110);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(88, 13);
            this.lblHeader.TabIndex = 25;
            this.lblHeader.Text = "Message Header";
            // 
            // blMessageBody
            // 
            this.blMessageBody.AutoSize = true;
            this.blMessageBody.Location = new System.Drawing.Point(20, 150);
            this.blMessageBody.Name = "blMessageBody";
            this.blMessageBody.Size = new System.Drawing.Size(77, 13);
            this.blMessageBody.TabIndex = 26;
            this.blMessageBody.Text = "Message Body";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(675, 550);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearMessage
            // 
            this.btnClearMessage.Location = new System.Drawing.Point(250, 410);
            this.btnClearMessage.Name = "btnClearMessage";
            this.btnClearMessage.Size = new System.Drawing.Size(123, 23);
            this.btnClearMessage.TabIndex = 3;
            this.btnClearMessage.Text = "Clear Test Message";
            this.btnClearMessage.UseVisualStyleBackColor = true;
            this.btnClearMessage.Click += new System.EventHandler(this.btnClearMessage_Click);
            // 
            // Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.btnClearMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.blMessageBody);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblField6);
            this.Controls.Add(this.lblField5);
            this.Controls.Add(this.txtField6);
            this.Controls.Add(this.txtField5);
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
            this.Text = "Napier Bank - Message Send Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtField1;
        private System.Windows.Forms.TextBox txtField2;
        private System.Windows.Forms.TextBox txtField3;
        private System.Windows.Forms.TextBox txtMessageBox;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblSubTitleReceived;
        private System.Windows.Forms.Label lblField1;
        private System.Windows.Forms.Label lblField2;
        private System.Windows.Forms.Label lblField3;
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.Label lblField4;
        private System.Windows.Forms.TextBox txtField4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txtField5;
        private System.Windows.Forms.TextBox txtField6;
        private System.Windows.Forms.Label lblField5;
        private System.Windows.Forms.Label lblField6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessageHeader;
        private System.Windows.Forms.TextBox txtMessageBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblSubTitleSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label blMessageBody;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearMessage;
    }
}