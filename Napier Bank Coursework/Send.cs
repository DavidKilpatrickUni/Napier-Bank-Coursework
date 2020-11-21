using LumenWorks.Framework.IO.Csv;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Napier_Bank_Coursework
{
    public partial class Send : Form
  
    {
        private Home homePage;
        private string messageID;
        private string messageType;

        public Send(Home homePage)
        {
            InitializeComponent();
            this.homePage = homePage;
        }

        private void btnHome_Click(object sender, EventArgs e)
        { 
            this.Close();
            homePage.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Program", buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            clearReceivedMessage();

            messageID = txtMessageHeader.Text.ToUpper();

            if(!Helper.processHeader(messageID))
            {
                return;
            }

            messageType = Helper.getHeaderType(messageID);

            if (messageType != "S" && messageType != "E" && messageType != "T")
            {
                return;
            }

            processMessageBody(messageType,messageID, txtMessageBody.Text);
        }

     

        private void processMessageBody(string messageType, string messageID, string messageBody)
        {
            string sender;
            string messageText;

            switch (messageType)
            {
                case "S":

                    if (!Helper.checkSenderLength(messageBody, 11, 11))
                    {
                        return;
                    }

                    if (!Helper.checkSenderNumeric(messageBody))
                    {
                        return;
                    }

                    sender = Helper.getSender(messageBody);
 
                    if(!Helper.checkMessageText(messageBody, 1, 140))
                    {   
                        return;
                    }

                    messageText = Helper.getMessageText(messageBody);
                 
                    SMS sms = new SMS(messageID, sender, messageText);

                    Helper.createJSONSMS(sms);

                    displaySMS(sms);

                    break;

                case "T":

                    IDictionary<String, int> displayHashtags;
                    IDictionary<String, int> displayMentions;

                    if (!Helper.checkSenderLength(messageBody, 2, 15))
                    {   
                        return;
                    }

                    sender = Helper.getSender(messageBody);

                    if (!Helper.checkSenderSymbol(sender))
                    {    
                        return;
                    }

                    if (!Helper.checkMessageText(messageBody, 1, 140))
                    {
                        return;
                    }

                    messageText = Helper.getMessageText(messageBody);

                    Helper.findHashTags(messageText);
                    displayHashtags = Helper.displayHashTags(messageText);

                    Helper.findMentions(messageText);
                    displayMentions = Helper.displayMentions(messageText);

                    Tweet tweet = new Tweet(messageID, sender, messageText);

                    Helper.createJSONTweet(tweet);

                    displayTweet(tweet,displayHashtags,displayMentions);

                    break;

                case "E":

                    IDictionary<String, int> displayWebsites;

                    string subject;
                    string SIRRecord;

                    SIRRecord = "";

                    if (!Helper.checkSenderEmail(messageBody))
                    {
                        return;
                    }

                    if (!Helper.checkForSubject(messageBody))
                    {
                        return;
                    }

                    if (!Helper.checkSubjectLength(messageBody))
                    {     
                        return;
                    }

                    if (!Helper.checkMessageText(messageBody, 1, 1028))
                    {     
                        return;
                    }

                    subject = Helper.getSubject(messageBody);

                    if (!Helper.checkForSIR(subject))
                    {    
                        sender = Helper.getSender(messageBody);
                        messageText = Helper.getMessageText(messageBody);

                        displayWebsites = Helper.displayWebsites(messageText);
                        messageText = Helper.findWebsites(messageText);

                        Email email = new Email(messageID, sender, subject, messageText);

                        Helper.createJSONEmail(email);

                        displayEmail(email, displayWebsites, SIRRecord);
                    }
                    else
                    {
                        string natureOfIncident;
                        string sortCode;

                        if (!Helper.checkSIRFormat(subject))
                        {
                            return;
                        }

                        if (!Helper.checkForSortCode(messageBody))
                        { 
                            return;
                        }

                        if (!Helper.checkSortCodeLength(messageBody))
                        { 
                            return;
                        }

                        if (!Helper.checkSortCodeFormat(messageBody))
                        {    
                            return;
                        }

                        if (!Helper.checkForNatureOfIncident(messageBody))
                        { 
                            return;
                        }

                        if (!Helper.checkNatureOfIncident(messageBody))
                        {     
                            return;
                        }

                        natureOfIncident = Helper.getNatureOfIncident(messageBody);
                        sortCode = Helper.getSortCode(messageBody);
                        subject = Helper.getSubject(messageBody);
                        sender = Helper.getSender(messageBody);
                        messageText = Helper.getRemainingMessageText(messageBody);

                        SIRRecord = sortCode + " " + natureOfIncident;

                        displayWebsites = Helper.displayWebsites(messageText);
                        messageText = Helper.findWebsites(messageText);

                        Helper.addSIRRecord(SIRRecord);
                       
                        Email email = new Email(messageID, sender, subject, sortCode, natureOfIncident, messageText);

                        Helper.createJSONEmail(email);

                        displayEmail(email, displayWebsites, SIRRecord);
                    }
         
                    break;

                default:
       
                    break;
            }
        }

        private void displaySMS(SMS sms)
        {
            clearReceivedMessage();
            txtField1.Text = sms.getMessageType();
            txtField2.Text = sms.getMessageID();
            txtField3.Text = sms.getSender();
            txtMessageBox.Text = sms.getMessage();

            lblField4.Visible = false;
            txtField4.Visible = false;
            lblField5.Visible = false;
            txtField5.Visible = false;
            lblField6.Visible = false;
            txtField6.Visible = false;
        }

        private void displayTweet(Tweet tweet, IDictionary<String, int> hashTagsList, IDictionary<String, int> MentionsList)
        {
            clearReceivedMessage();
            txtField1.Text = tweet.getMessageType();
            txtField2.Text = tweet.getMessageID();
            txtField3.Text = tweet.getSender();
            txtMessageBox.Text = tweet.getMessage();

            foreach (var hashTag in hashTagsList)
            {
                listBox1.Items.Add(hashTag.Key + "   Trending: " + hashTag.Value + " time(s)");
            }

            foreach (var mention in MentionsList)
            {
                listBox2.Items.Add(mention.Key + "   Mentioned: " + mention.Value + " time(s)");
            }

            lblField4.Visible = false;
            txtField4.Visible = false;
            lblField5.Visible = false;
            txtField5.Visible = false;
            lblField6.Visible = false;
            txtField6.Visible = false;
        }

        private void displayEmail(Email email, IDictionary<String, int> WebsitesList, string SIRRecord)
        {
            clearReceivedMessage();
            txtField1.Text = email.getMessageType();
            txtField2.Text = email.getMessageID();
            txtField3.Text = email.getSender();
            txtField4.Text = email.getSubject();

            txtField5.Text = email.getSortCode();
            txtField6.Text = email.getNatureOfIncident();

            txtMessageBox.Text = email.getMessage();

            foreach (var site in WebsitesList)
            {
                listBox1.Items.Add(site.Key + "   Blocked: " + site.Value + " time(s)");
            }

            if (SIRRecord != "")
            {
                listBox2.Items.Add(SIRRecord + "   Reported: 1 time");
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            

            txtMessageHeader.Clear();
            txtMessageBody.Clear();

            txtMessageBox.Clear();
            txtField1.Clear();
            txtField2.Clear();
            txtField3.Clear();
            txtField4.Clear();
            txtField5.Clear();
            txtField6.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            lblField4.Visible = true;
            txtField4.Visible = true;
            lblField5.Visible = true;
            txtField5.Visible = true; 
            lblField6.Visible = true;
            txtField6.Visible = true;
        }

        private void btnClearMessage_Click(object sender, EventArgs e)
        {
            txtMessageHeader.Clear();
            txtMessageBody.Clear();
        }
        private void clearReceivedMessage()
        {
            txtMessageBox.Clear();
            txtField1.Clear();
            txtField2.Clear();
            txtField3.Clear();
            txtField4.Clear();
            txtField5.Clear();
            txtField6.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            lblField4.Visible = true;
            txtField4.Visible = true;
            lblField5.Visible = true;
            txtField5.Visible = true;
            lblField6.Visible = true;
            txtField6.Visible = true;
        }

        private void clearAll()
        {

            txtMessageHeader.Clear();
            txtMessageBody.Clear();
            txtMessageBox.Clear();
            txtField1.Clear();
            txtField2.Clear();
            txtField3.Clear();
            txtField4.Clear();
            txtField5.Clear();
            txtField6.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            lblField4.Visible = true;
            txtField4.Visible = true;
            lblField5.Visible = true;
            txtField5.Visible = true;
            lblField6.Visible = true;
            txtField6.Visible = true;
        }



     
    }
}
