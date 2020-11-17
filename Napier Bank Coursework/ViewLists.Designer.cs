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
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(352, 363);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lstURL
            // 
            this.lstURL.FormattingEnabled = true;
            this.lstURL.Location = new System.Drawing.Point(414, 238);
            this.lstURL.Name = "lstURL";
            this.lstURL.Size = new System.Drawing.Size(262, 95);
            this.lstURL.TabIndex = 6;
            // 
            // lstHastags
            // 
            this.lstHastags.FormattingEnabled = true;
            this.lstHastags.Location = new System.Drawing.Point(414, 71);
            this.lstHastags.Name = "lstHastags";
            this.lstHastags.Size = new System.Drawing.Size(262, 95);
            this.lstHastags.TabIndex = 7;
            // 
            // lstSIR
            // 
            this.lstSIR.FormattingEnabled = true;
            this.lstSIR.Location = new System.Drawing.Point(88, 238);
            this.lstSIR.Name = "lstSIR";
            this.lstSIR.Size = new System.Drawing.Size(247, 95);
            this.lstSIR.TabIndex = 8;
            // 
            // lstMentions
            // 
            this.lstMentions.FormattingEnabled = true;
            this.lstMentions.Location = new System.Drawing.Point(88, 71);
            this.lstMentions.Name = "lstMentions";
            this.lstMentions.Size = new System.Drawing.Size(261, 95);
            this.lstMentions.TabIndex = 9;
            // 
            // ViewLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMentions);
            this.Controls.Add(this.lstSIR);
            this.Controls.Add(this.lstHastags);
            this.Controls.Add(this.lstURL);
            this.Controls.Add(this.btnHome);
            this.Name = "ViewLists";
            this.Text = "ViewLists";
            this.Load += new System.EventHandler(this.ViewLists_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ListBox lstURL;
        private System.Windows.Forms.ListBox lstHastags;
        private System.Windows.Forms.ListBox lstSIR;
        private System.Windows.Forms.ListBox lstMentions;
    }
}