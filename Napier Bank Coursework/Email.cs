using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napier_Bank_Coursework
{
    class Email : Message
    {

        readonly string messageType = "Email";
        private string subject;


        public Email()
        {
          
        }

        public Email(string messageID, string sender, string subject, string message)
        {
            base.setMessageType(messageType);
            base.setMessageID(messageID);
            base.setSender(sender);
            this.subject = subject;
            base.setMessage(message);
        }

        public string getSubject()
        {
            return subject;
        }

        public void setSubject(string subject)
        {
            this.subject = subject;
        }

    }
}
