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
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            if (Singleton.Instance.getMentionList().TryGetValue("@Student", out value))
            {
                Singleton.Instance.getMentionList()["@Student"] = value + 1;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.Hide();
            Send sendScreen = new Send(this);
            sendScreen.ShowDialog(this);
        }
    }
}
