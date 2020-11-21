﻿using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Napier_Bank_Coursework
{
    public partial class Read : Form
    {

        private Home homePage;

        string path;
        string[] lines;
     
        int lastLine;
        int count;

        string messageID;
        string messageBody;


        public Read(Home homePage)
        {
            InitializeComponent();

            this.homePage = homePage;
        }

 

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (count < lastLine - 1)
            {
                txtField1.Clear();

                count = count + 1;
               
                messageID = lines[count].Substring(0, lines[count].IndexOf(" ")).ToUpper();
                messageBody = lines[count].Remove(0, lines[count].IndexOf(" ") + 1);

                txtHeader.Text = messageID;
                txtMessageBody.Text = messageBody;

                txtRecordCount.Text = (count).ToString();
                txtRecordTotal.Text = (lastLine-1).ToString();

                string messageType;

                if (!Helper.processHeader(messageID))
                {
                    return;
                }

                messageType = Helper.getHeaderType(messageID);

                if (messageType != "S" && messageType != "E" && messageType != "T")
                {
                    return;
                }

                txtField1.Text = messageID;

                processMessageBody(messageType, messageID, txtMessageBody.Text);
            }
            else
                {
                MessageBox.Show("No further messages");
            }
        }

      

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\Random\Desktop\Uni - Software Engineering",
                Title = " Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true

            };


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;

                lines = File.ReadAllLines(path);

                count = -1;

                lastLine = lines.Length;

                txtFilePath.Text = path;
                //foreach(var record in lines)
                //{

                //messageID = lines[.Substring(0, 10);
                // messageBody = record.Remove(0, 11);



                //}



            }
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

                    if (!Helper.checkMessageText(messageBody, 1, 140))
                    {

                        return;
                    }

                    messageText = Helper.getMessageText(messageBody);

                    SMS sms = new SMS(messageID, sender, messageText);

                    Helper.createJSONSMS(sms);

                    displaySMS(sms);

                    break;


                case "T":

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
               
                    Helper.findMentions(messageText);

                    Tweet tweet = new Tweet(messageID, sender, messageText);

                    Helper.createJSONTweet(tweet);

                    displayTweet(tweet);

                    break;


                case "E":

           
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

  
                        messageText = Helper.findWebsites(messageText);

                        Email email = new Email(messageID, sender, subject, messageText);

                        Helper.createJSONEmail(email);

                        displayEmail(email);
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
                      
                        messageText = Helper.findWebsites(messageText);

                        Helper.addSIRRecord(SIRRecord);


                        Email email = new Email(messageID, sender, subject, sortCode, natureOfIncident, messageText);

                        Helper.createJSONEmail(email);

                        displayEmail(email);


                    }


                    break;


                default:



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
            lblField5.Visible = false;
            txtField5.Visible = false;
            lblField6.Visible = false;
            txtField6.Visible = false;

            MessageBox.Show("SMS created sucessfully", "Success");
        }

        private void displayEmail(Email email)
        {
   
            txtField1.Text = email.getMessageType();
            txtField2.Text = email.getMessageID();
            txtField3.Text = email.getSender();
            txtField4.Text = email.getSubject();

            txtField5.Text = email.getSortCode();
            txtField6.Text = email.getNatureOfIncident();

            txtMessageBox.Text = email.getMessage();

            MessageBox.Show("Email created sucessfully", "Success");


        }

        private void displayTweet(Tweet tweet)
        {
            
            txtField1.Text = tweet.getMessageType();
            txtField2.Text = tweet.getMessageID();
            txtField3.Text = tweet.getSender();
            txtMessageBox.Text = tweet.getMessage();


            lblField4.Visible = false;
            txtField4.Visible = false;
            lblField5.Visible = false;
            txtField5.Visible = false;
            lblField6.Visible = false;
            txtField6.Visible = false;

            MessageBox.Show("Tweet created sucessfully", "Success");
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
    }
}
