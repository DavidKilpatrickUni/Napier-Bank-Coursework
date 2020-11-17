using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napier_Bank_Coursework
{

   
    class SMS : Message
    {
        readonly string messageType = "SMS";

        public SMS()
        {
      
        }
        public SMS(string messageID, string sender, string message)
        {
            base.setMessageType(messageType);
            base.setMessageID(messageID);
            base.setSender(sender);
            base.setMessage(message);
        }

    }
}
