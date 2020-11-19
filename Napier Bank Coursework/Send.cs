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

        private void btnSend_Click(object sender, EventArgs e)
        {

            messageID = txtMessageHeader.Text.ToUpper();

            if (!Helper.checkHeaderLength(messageID))
            {
                MessageBox.Show("Invalid Message Header");
                return;
            }
            
            if(!Helper.checkHeaderNumeric(messageID))
            {
                MessageBox.Show("Invalid Message Type (Not numeric characters)");
                return;
            }

            messageType = Helper.getHeaderType(messageID);
    
            if (messageType != "S" && messageType != "E" && messageType != "T")
            {
                MessageBox.Show("Invalid Message Type (Not SMS,Tweet or Email)");
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
                        MessageBox.Show("Invalid Phone Number (Number should contain 11 digits)");
                        return;
                    }

                    if (!Helper.checkSenderNumeric(messageBody))
                    {
                        MessageBox.Show("Invalid Phone Number (Number should contain 11 digits)");
                        return;
                    }

                    sender = Helper.getSender(messageBody);
 
                    if(!Helper.checkMessageText(messageBody, 1, 140))
                    {
                        MessageBox.Show("Invalid Message Text Length (Message Text Must Be Less Than 140 Characters");
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
                        MessageBox.Show("Invalid TwitterID (Number should contain max 15 characters)");
                        return;
                    }

                    sender = Helper.getSender(messageBody);

                    if (!Helper.checkSenderSymbol(sender))
                    {
                        MessageBox.Show("Invalid TwitterID (Does Not Conatain A @ Sign)");
                        return;
                    }

                    if (!Helper.checkMessageText(messageBody, 1, 140))
                    {
                        MessageBox.Show("Invalid Message Text Length (Message Text Must Be Less Than 140 Characters");
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

                    if (!Helper.checkSenderEmail(messageBody))
                    {
                        MessageBox.Show("Invalid Email Address (Does Not Contain Email Characteristics (@ symbol, .com, .co.uk etc)");
                        return;
                    }


                    if (!Helper.checkForSubject(messageBody))
                    {
                        MessageBox.Show("Invalid Email (No Subject Title)");
                        return;
                    }

                    if (!Helper.checkSubjectLength(messageBody))
                    {
                        MessageBox.Show("Invalid Email (No Subject Content)");
                        return;
                    }

                    if (!Helper.checkMessageText(messageBody, 1, 1028))
                    {
                        MessageBox.Show("Invalid Email Length (Message Text Must Be Less Than 1028 Characters");
                        return;
                    }

                    subject = Helper.getSubject(messageBody);
                    sender = Helper.getSender(messageBody);

                    messageText = Helper.getMessageText(messageBody);

                    displayWebsites = Helper.displayWebsites(messageText);
                    messageText = Helper.findWebsites(messageText);

                    Email email = new Email(messageID,sender,subject, messageText);

                    Helper.createJSONEmail(email);

                    displayEmail(email,displayWebsites);

                    break;


                default:

                    MessageBox.Show("Invalid Message Type (Not SMS,Tweet or Email)");
                    
                    break;

            }
        }

       

       

      

      
        private void displaySMS(SMS sms)
        {

            txtField1.Text = sms.getMessageType();
            txtField2.Text = sms.getMessageID();
            txtField3.Text = sms.getSender();
            txtMessageBox.Text = sms.getMessage();

            lblField4.Visible = false;
            txtField4.Visible = false;


        }

        private void displayTweet(Tweet tweet, IDictionary<String, int> hashTagsList, IDictionary<String, int> MentionsList)
        {

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


        }

        private void displayEmail(Email email, IDictionary<String, int> WebsitesList)
        {

            txtField1.Text = email.getMessageType();
            txtField2.Text = email.getMessageID();
            txtField3.Text = email.getSender();
            txtField4.Text = email.getSubject();

            txtMessageBox.Text = email.getMessage();

            foreach (var site in WebsitesList)
            {
                listBox1.Items.Add(site.Key + "   Blocked: " + site.Value + " time(s)");
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

            lblField4.Visible = true;
            txtField4.Visible = true;

        }
    }
}
