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
    public partial class ViewLists : Form
    {
        private IDictionary<string, int> quarantinedList;
        private IDictionary<string, int> trendingList;
        private IDictionary<string, int> SIRList;
        private IDictionary<string, int> mentionList;

        private Home homepage;

        public ViewLists(Home homepage)
        {
            InitializeComponent();
            this.homepage = homepage;
           
        }

        private void txtTrending_TextChanged(object sender, EventArgs e)
        {          
        }

        private void ViewLists_Load(object sender, EventArgs e)
        {

            
            quarantinedList = Singleton.Instance.getQuarantinedList();
            foreach (var site in quarantinedList)
            {
                lstURL.Items.Add(site.Key + "   Blocked: " + site.Value + " times");
            }

            trendingList = Singleton.Instance.getTrendingList();
            foreach (var hashTag in trendingList)
            {
                lstHastags.Items.Add(hashTag.Key + "   Trending: "+ hashTag.Value + " times");
            }

            SIRList = Singleton.Instance.getSIRList();
            foreach (var bank in SIRList)
            {
                lstSIR.Items.Add(bank.Key + "   Reported: " + bank.Value + " times");
            }

            mentionList = Singleton.Instance.getMentionList();
            foreach (var person in mentionList)
            {
                lstMentions.Items.Add(person.Key + "   Mentioned: " + person.Value + " times");
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {


            this.Hide();
            homepage.Show();



        }
      
    }
}
