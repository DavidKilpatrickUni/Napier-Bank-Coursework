using Newtonsoft.Json;
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

        [JsonProperty]
        private string sortCode;

        [JsonProperty]
        private string natureOfIncident;

        [JsonProperty]
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

        public Email(string messageID, string sender, string subject, string sortCode, string natureOfIncident, string message)
        {
            base.setMessageType(messageType);
            base.setMessageID(messageID);
            base.setSender(sender);
            this.subject = subject;
            this.sortCode = sortCode;
            this.natureOfIncident = natureOfIncident;
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
        public string getSortCode()
        {
            return sortCode;
        }

        public void setSortCode(string sortCode)
        {
            this.sortCode = sortCode;
        }
        public string getNatureOfIncident()
        {
            return natureOfIncident;
        }

        public void setNatureOfIncident(string natureOfIncident)
        {
            this.natureOfIncident = natureOfIncident;
        }
    }
}
