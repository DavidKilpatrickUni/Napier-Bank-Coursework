namespace Napier_Bank_Coursework
{
    partial class ViewLists
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
            this.lstURL = new System.Windows.Forms.ListBox();
            this.lstHastags = new System.Windows.Forms.ListBox();
            this.lstSIR = new System.Windows.Forms.ListBox();
            this.lstMentions = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMentions = new System.Windows.Forms.Label();
            this.lblHashTags = new System.Windows.Forms.Label();
            this.lblSIR = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(320, 450);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 30);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lstURL
            // 
            this.lstURL.FormattingEnabled = true;
            this.lstURL.HorizontalScrollbar = true;
            this.lstURL.Location = new System.Drawing.Point(430, 300);
            this.lstURL.Name = "lstURL";
            this.lstURL.Size = new System.Drawing.Size(300, 108);
            this.lstURL.TabIndex = 6;
            // 
            // lstHastags
            // 
            this.lstHastags.FormattingEnabled = true;
            this.lstHastags.HorizontalScrollbar = true;
            this.lstHastags.Location = new System.Drawing.Point(430, 120);
            this.lstHastags.Name = "lstHastags";
            this.lstHastags.Size = new System.Drawing.Size(300, 108);
            this.lstHastags.TabIndex = 7;
            // 
            // lstSIR
            // 
            this.lstSIR.FormattingEnabled = true;
            this.lstSIR.HorizontalScrollbar = true;
            this.lstSIR.Location = new System.Drawing.Point(70, 300);
            this.lstSIR.Name = "lstSIR";
            this.lstSIR.Size = new System.Drawing.Size(300, 108);
            this.lstSIR.TabIndex = 8;
            // 
            // lstMentions
            // 
            this.lstMentions.FormattingEnabled = true;
            this.lstMentions.HorizontalScrollbar = true;
            this.lstMentions.Location = new System.Drawing.Point(70, 120);
            this.lstMentions.Name = "lstMentions";
            this.lstMentions.Size = new System.Drawing.Size(300, 108);
            this.lstMentions.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(340, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(122, 31);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "List Data";
            // 
            // lblMentions
            // 
            this.lblMentions.AutoSize = true;
            this.lblMentions.Location = new System.Drawing.Point(70, 100);
            this.lblMentions.Name = "lblMentions";
            this.lblMentions.Size = new System.Drawing.Size(50, 13);
            this.lblMentions.TabIndex = 11;
            this.lblMentions.Text = "Mentions";
            // 
            // lblHashTags
            // 
            this.lblHashTags.AutoSize = true;
            this.lblHashTags.Location = new System.Drawing.Point(430, 100);
            this.lblHashTags.Name = "lblHashTags";
            this.lblHashTags.Size = new System.Drawing.Size(83, 13);
            this.lblHashTags.TabIndex = 12;
            this.lblHashTags.Text = "Shared Hastags";
            // 
            // lblSIR
            // 
            this.lblSIR.AutoSize = true;
            this.lblSIR.Location = new System.Drawing.Point(70, 280);
            this.lblSIR.Name = "lblSIR";
            this.lblSIR.Size = new System.Drawing.Size(65, 13);
            this.lblSIR.TabIndex = 13;
            this.lblSIR.Text = "SIR Reports";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(430, 280);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(112, 13);
            this.lblURL.TabIndex = 14;
            this.lblURL.Text = "Quarantined Websites";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(420, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ViewLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblSIR);
            this.Controls.Add(this.lblHashTags);
            this.Controls.Add(this.lblMentions);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstMentions);
            this.Controls.Add(this.lstSIR);
            this.Controls.Add(this.lstHastags);
            this.Controls.Add(this.lstURL);
            this.Controls.Add(this.btnHome);
            this.Name = "ViewLists";
            this.Text = "Napier Bank - List Data";
 
            this.Load += new System.EventHandler(this.ViewLists_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ListBox lstURL;
        private System.Windows.Forms.ListBox lstHastags;
        private System.Windows.Forms.ListBox lstSIR;
        private System.Windows.Forms.ListBox lstMentions;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMentions;
        private System.Windows.Forms.Label lblHashTags;
        private System.Windows.Forms.Label lblSIR;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Button btnExit;
    }
}