using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napier_Bank_Coursework
{
    class Message
    {

        [JsonProperty]
        private string messageType;
        [JsonProperty]
        private string messageID;
        [JsonProperty]
        private string sender;
        [JsonProperty]
        private string message;

        public Message()
        {

        }

        public Message(string messageType, string messageID, string sender, string message)
        {
            this.messageType = messageType;
            this.messageID = messageID;
            this.sender = sender;
            this.message = message;
        }
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
