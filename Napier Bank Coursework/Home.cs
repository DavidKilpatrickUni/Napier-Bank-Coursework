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
    public partial class Home : Form
    {

        

        public Home()
        {
            InitializeComponent();
            

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewLists viewListsScreen = new ViewLists(this);
            viewListsScreen.ShowDialog(this);
            
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

        private void button1_Click(object sender, EventArgs e)
        {
         
            
            this.Hide();
            Read readScreen = new Read(this);
            readScreen.Show();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.Hide();
            Send sendScreen = new Send(this);
            sendScreen.Show();
        }

     

        private void Home_Load(object sender, EventArgs e)
        {

        }

      
    }
}
