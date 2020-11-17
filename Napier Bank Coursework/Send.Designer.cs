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
            // Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}