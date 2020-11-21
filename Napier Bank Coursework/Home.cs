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
    // Home class
    // Partial class of Form
    // Contains the code thats is executed to complete instructions from user interaction. 
    // Different Form events trigger said peices of code.
    // Results in on screen feedback or execution of code to fulfill a user request/interaction

    public partial class Home : Form                                                                            // Home partial Subclass inheriting from Form Superclass
    {
        // Constructors
        // Default

        // Constuctor for Home class. 
        public Home()
        {
            InitializeComponent();                                                                              // Create GUI of current Form
        }

        // Methods

        // Method called on_click of Form button - Hides current Form and opens instance linked to variable. (Takes user to 'Send')
        private void btnSend_Click(object sender, EventArgs e)
        {
            this.Hide();                                                                                        // Hide current Form. Home Form is where the program is run from, meaning it must remain open in the background
            Send sendScreen = new Send(this);                                                                   // Create new instance of Send Form with parameter of current Form
            sendScreen.Show();                                                                                  // Open defined Form - Displays Send screen to user
        }

        // Method called on_click of Form button - Hides current Form and opens instance linked to variable. (Takes user to 'Read')
        private void btnRead_Click(object sender, EventArgs e)
        {
            this.Hide();                                                                                        // Hide current Form. Home Form is where the program is run from, meaning it must remain open in the background
            Read readScreen = new Read(this);                                                                   // Create new instance of Read Form with parameter of current Form
            readScreen.Show();                                                                                  // Open defined Form - Displays Read screen to user
        }

        // Method called on_click of Form button - Hides current Form and opens instance linked to variable. (Takes user to 'ViewLists')
        private void btnList_Click(object sender, EventArgs e)
        {
            this.Hide();                                                                                        // Hide current Form. Home Form is where the program is run from, meaning it must remain open in the background
            ViewLists viewListsScreen = new ViewLists(this);                                                    // Create new instance of Read Form with parameter of current Form
            viewListsScreen.ShowDialog(this);                                                                   // Open defined Form - Displays View screen to user
        }

        // Method called on_click of Form button - Starts Window MessageBox asking for conformation of application exit. 
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;                                                // Create a Window MessageBox with Yes and No option buttons
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Program", buttons);   // Set varaible to user input from the MessageBox. 

            if (result == DialogResult.Yes)                                                                     // If statement comparing variable to one of the two possible user responses (Yes button pressed)
            {
                Application.Exit();                                                                             // True. Exit application
            }
        }


    }
}
