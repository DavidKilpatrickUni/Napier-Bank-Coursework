using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napier_Bank_Coursework
{
    class Helper
    {

        public static bool checkHeaderLength(string header)
        {
            bool result;

            result = true;

            if (header.Length != 10)
            {
                result = false;
               
            }

            return result;
        }

    }
}
