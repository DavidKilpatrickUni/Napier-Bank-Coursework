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
    // ViewLists class
    // Partial class of Form
    // Contains the code thats is executed to complete instructions from user interaction. 
    // Different Form events trigger said peices of code.
    // Results in on screen feedback or execution of code to fulfill a user request/interaction

    public partial class ViewLists : Form                                                           // ViewLists partial Subclass inheriting from Form Superclass
    {
        // Variables

        private IDictionary<string, int> quarantinedList;                                           // Dictionary variable for storing data.
        private IDictionary<string, int> trendingList;                                              // Dictionary variable for storing data.
        private IDictionary<string, int> SIRList;                                                   // Dictionary variable for storing data.
        private IDictionary<string, int> mentionList;                                               // Dictionary variable for storing data.

        private Home homepage;                                                                      // Home variable to store current instance of Home so it can be recalled when required. (Return to Homepage)

        // Constructors
        // Overloaded

        // Constuctor for ViewLists class with parameters for defining homepage data. 
        public ViewLists(Home homepage)                     
        {
            InitializeComponent();                                                                  // Create GUI of current Form
            this.homepage = homepage;                                                               // Set variable to parameter
        }

        // Methods

        // Method on Form load for populating the Form with appropriate information. Sets variables to different defined dictionaries so the data they contain can be visualised.
        private void ViewLists_Load(object sender, EventArgs e)
        {  
            quarantinedList = Singleton.Instance.getQuarantinedList();                              // Set variable to instance of dictionary - quarantined website list

            foreach (var site in quarantinedList)                                                   // Loop through each item in variable
            {
                lstURL.Items.Add(site.Key + "   Blocked: " + site.Value + " time(s)");              // Display item in listbox with extra text for context
            }

            trendingList = Singleton.Instance.getTrendingList();                                    // Set variable to instance of dictionary - trending list

            foreach (var hashTag in trendingList)                                                   // Loop through each item in variable
            {
                lstHastags.Items.Add(hashTag.Key + "   Trending: "+ hashTag.Value + " time(s)");    // Display item in listbox with extra text for context
            }

            SIRList = Singleton.Instance.getSIRList();                                              // Set variable to instance of dictionary - SIR Reports list

            foreach (var bank in SIRList)                                                           // Loop through each item in variable
            {
                lstSIR.Items.Add(bank.Key + "   Reported: " + bank.Value + " time(s)");             // Display item in listbox with extra text for context
            }

            mentionList = Singleton.Instance.getMentionList();                                      // Set variable to instance of dictionary - Mention list

            foreach (var person in mentionList)                                                     // Loop through each item in variable
            {
                lstMentions.Items.Add(person.Key + "   Mentioned: " + person.Value + " time(s)");   // Display item in listbox with extra text for context
            }
        }

        // Method called on_click of Form button - Closes current Form and opens instance linked to variable. (Takes user to 'Home')
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();                                                                           // Close current Form
            homepage.Show();                                                                        // Open defined Form - Displays Home screen to user
        }

        // Method called on_click of Form button - Starts Window MessageBox asking for conformation of application exit. 
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;                                                    // Create a Window MessageBox with Yes and No option buttons
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Program", buttons);       // Set varaible to user input from the MessageBox. 

            if (result == DialogResult.Yes)                                                                         // If statement comparing variable to one of the two possible user responses (Yes button pressed)
            {
                Application.Exit();                                                                                 // True. Exit application
            }
        }

    }
}
