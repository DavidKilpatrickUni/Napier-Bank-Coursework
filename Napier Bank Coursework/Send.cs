using LumenWorks.Framework.IO.Csv;
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
    public partial class Send : Form

       
    {

        private Home homepage;

        private string messageType;

        





        public Send(Home homepage)
        {
            InitializeComponent();
            this.homepage = homepage;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            this.Hide();
            homepage.Show();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            

            if (!Helper.checkHeaderLength(txtMessageHeader.Text))
            {
                MessageBox.Show("Invalid Message Header");
                return;
            }
            
            if(!checkHeaderNumeric(txtMessageHeader.Text))
            {
                return;
            }

            messageType = getHeaderType(txtMessageHeader.Text);

            if (txtMessageHeader.Text != "E" || txtMessageHeader.Text != "S" || txtMessageHeader.Text != "T")
            {
                return;
            }

           
            processMessageBody(messageType, txtMessageBody.Text);
        }


   

        private string getHeaderType(string header)
        {
            string firstLetter;
            firstLetter = header.Substring(0, 1).ToUpper();

      switch(firstLetter)
            {
                case "S":
                    return "S";
                   

                case "T":
                    return "T";
                
                   
                case "E":
                    return "E";
                   

                default:
                    MessageBox.Show("Invalid Message Type (Not SMS,Tweet or Email)");
                    return null;
                 
            }

        }

        private bool checkHeaderNumeric(string header)
        {
            string remainingtLetters;
            int numberOutput;
            bool result;

            remainingtLetters = header.Substring(1, 9);
            numberOutput = 0;

            result = int.TryParse(remainingtLetters, out numberOutput);

            if(!result)
            {
                MessageBox.Show("Invalid Message Type (Not numeric characters)");
            }

            return result;



        }

        private void processMessageBody(string messageType, string messageBody)
        {
            switch (messageType)
            {
                case "S":
                    getSender(messageBody);
                    break;


                case "T":
                    getSender(messageBody);
                    break;


                case "E":
                    getSender(messageBody);
                    break;


                default:
                    MessageBox.Show("Invalid Message Type (Not SMS,Tweet or Email)");
                    break;

            }
        }

        private void getSender(string messageBody)
        {
            string findSender = "Sender:";
            string findMessage = "Message Text:";
            int messageLength = messageBody.Length + 1;

            int firstSender = messageBody.IndexOf(findSender);
            int firstMessage = messageBody.IndexOf(findMessage);

            int lengthOfSender = firstMessage - (firstSender + 9);
            string returnSender = messageBody.Substring(firstSender + 8, lengthOfSender);

            int lengthOfMessage = messageLength - (firstMessage);
            string returnMessage1 = messageBody.Substring(firstMessage + 14, lengthOfMessage);

            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"C:\Users\Random\Desktop\Uni - Software Engineering\textwords.csv")), true))
            {
                csvTable.Load(csvReader);
                for (int i = 0; i < csvTable.Rows.Count; i++)
                {
                    // string Column1 = csvTable.Columns[i].ToString();
                    string Row1 = csvTable.Rows[i][0].ToString();
                    //MessageBox.Show(Row1);


                    returnMessage1 = returnMessage1.Replace(Row1, Row1 + " <" + csvTable.Rows[i][1].ToString() + ">");

                }
            }

        }

    }
}
