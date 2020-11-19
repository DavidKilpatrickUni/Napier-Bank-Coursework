using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Napier_Bank_Coursework
{
    public partial class Received : Form
    {


        private Home homePage;
        private string messageType;
        private Object recievedMessage;
        public Received(Home homePage, string messageType, Object recievedMessage )
        {
            InitializeComponent();

            this.homePage = homePage;
            this.recievedMessage = recievedMessage;
            this.messageType = messageType;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Send sendScreen = new Send(homePage);
            sendScreen.Show();
        }

        private void Received_Load(object sender, EventArgs e)
        {
            switch (messageType)
            {
                case "S":
                   recievedMessage = recievedMessage as SMS;
                    
                break;


                case "T":

                    break;


                case "E":

                    break;


                default:
                  
                    break;

            }
        }
    }
}
