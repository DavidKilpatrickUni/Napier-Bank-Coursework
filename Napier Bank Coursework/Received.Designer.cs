namespace Napier_Bank_Coursework
{
    partial class Received
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtMessageType = new System.Windows.Forms.TextBox();
            this.txtMessageID = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtMessageText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(627, 331);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(524, 331);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtMessageType
            // 
            this.txtMessageType.Location = new System.Drawing.Point(151, 89);
            this.txtMessageType.Name = "txtMessageType";
            this.txtMessageType.Size = new System.Drawing.Size(100, 20);
            this.txtMessageType.TabIndex = 2;
            // 
            // txtMessageID
            // 
            this.txtMessageID.Location = new System.Drawing.Point(151, 141);
            this.txtMessageID.Name = "txtMessageID";
            this.txtMessageID.Size = new System.Drawing.Size(256, 20);
            this.txtMessageID.TabIndex = 3;
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(151, 186);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(100, 20);
            this.txtSender.TabIndex = 4;
            // 
            // txtMessageText
            // 
            this.txtMessageText.Location = new System.Drawing.Point(151, 229);
            this.txtMessageText.Name = "txtMessageText";
            this.txtMessageText.Size = new System.Drawing.Size(100, 20);
            this.txtMessageText.TabIndex = 5;
            // 
            // Received
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMessageText);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.txtMessageID);
            this.Controls.Add(this.txtMessageType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHome);
            this.Name = "Received";
            this.Text = "Received";
            this.Load += new System.EventHandler(this.Received_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtMessageType;
        private System.Windows.Forms.TextBox txtMessageID;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtMessageText;
    }
}