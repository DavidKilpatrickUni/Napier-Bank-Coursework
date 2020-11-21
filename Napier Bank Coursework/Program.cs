using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Napier_Bank_Coursework
{
    // Program class
    // Laucher code that starts the application.
    // Creates the 'Home' form ready for user interaction
    static class Program
    { 
        [STAThread]
        static void Main()
        {
            Singleton.Instance.dataGen();                                              // Create instance of singleton that will be utilised during program runtime

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());                                               // Create new instance of 'Home' form 
        }
    }
}
