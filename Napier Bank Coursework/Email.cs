using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napier_Bank_Coursework
{
    // Email class 
    // Stores variables and methods in relation to emails
    // Can create and alter instances of the given object

    class Email : Message                                                           // Email Subclass inheriting from Message Superclass
    {
        // Variables

        readonly string messageType = "Email";                                      // Set read only variable. All instances of this object are of the 'Email' message type
        [JsonProperty]
        private string sortCode;                                                    // Variable for storing data. Can be used during JSON creation
        [JsonProperty]
        private string natureOfIncident;                                            // Variable for storing data. Can be used during JSON creation
        [JsonProperty]
        private string subject;                                                     // Variable for storing data. Can be used during JSON creation

        // Constructors
        // Default

        // Constructor for Email class with no parameters.
        public Email()
        {
          
        }

        // Overloaded

        // Constuctor for Email class with parameters for defining messageID, sender, subject and message. Message type is predefined. Used for creating emails with no SIR reports
        public Email(string messageID, string sender, string subject, string message)
        {
            base.setMessageType(messageType);                                       // Set data to read only variable using method from Superclass
            base.setMessageID(messageID);                                           // Set data to parameter using method from Superclass
            base.setSender(sender);                                                 // Set data to parameter using method from Superclass
            this.subject = subject;                                                 // Set data to parameter
            base.setMessage(message);                                               // Set data to parameter using method from Superclass
        }

        // Methods

        // Constuctor for Email class with parameters for defining messageID, sender, subject, sort code, nature of incident and message. Message type is predefined. Used for creating emails with SIR reports
        public Email(string messageID, string sender, string subject, string sortCode, string natureOfIncident, string message)
        {
            base.setMessageType(messageType);                                       // Set data to read only variable using method from Superclass
            base.setMessageID(messageID);                                           // Set data to parameter using method from Superclass
            base.setSender(sender);                                                 // Set data to parameter using method from Superclass
            this.subject = subject;                                                 // Set data to parameter
            this.sortCode = sortCode;                                               // Set data to parameter
            this.natureOfIncident = natureOfIncident;                               // Set data to parameter
            base.setMessage(message);                                               // Set data to parameter using method from Superclass
        }

        // Getter method for retreiving subject data of an instance.
        public string getSubject()
        {
            return subject;                                                         // Return variable of current instance 
        }

        // Setter method for defining subject data of an instance to parameter.
        public void setSubject(string subject)
        {
            this.subject = subject;                                                 // Set variable to parameter for current instance
        }

        // Getter method for retreiving sort code data of an instance.
        public string getSortCode()
        {
            return sortCode;                                                        // Return variable of current instance 
        }

        // Setter method for defining sort code data of an instance to parameter.
        public void setSortCode(string sortCode)
        {
            this.sortCode = sortCode;                                               // Set variable to parameter for current instance
        }

        // Getter method for retreiving nature of incident data of an instance.
        public string getNatureOfIncident()
        {
            return natureOfIncident;                                                // Return variable of current instance 
        }

        // Setter method for defining nature of incident data of an instance to parameter.
        public void setNatureOfIncident(string natureOfIncident)
        {
            this.natureOfIncident = natureOfIncident;                               // Set variable to parameter for current instance
        }

    }
}
