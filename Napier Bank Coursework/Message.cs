using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napier_Bank_Coursework
{
    abstract class Message
    {

        private string messageType;
        private string messageID;
        private string sender;
        private string message;


        public string getMessageType()
        {
            return messageType;
        }

        public void setMessageType(string messageType)
        {
            this.messageType = messageType;
        }

        public string getMessageID()
        {
            return messageID;
        }

        public void setMessageID(string messageID)
        {
            this.messageID = messageID;
        }

        public string getSender()
        {
            return sender;
        }

        public void setSender(string sender)
        {
            this.sender = sender;
        }

        public string getMessage()
        {
            return message;
        }

        public void setMessage(string message)
        {
            this.message = message;
        }

    }
}
