using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napier_Bank_Coursework
{

    // Abstract Message superclass 
    // Stores variables and methods that can be used by subclasses that inherit from current class
    // Cannot create instances 
    // Provides methods to retreive data and alter instances of subclass objects
    abstract class Message
    {
        // Variables

        [JsonProperty]
        private string messageType;                                                         // Variable for storing data. Can be used during JSON creation
        [JsonProperty]
        private string messageID;                                                           // Variable for storing data. Can be used during JSON creation
        [JsonProperty]
        private string sender;                                                              // Variable for storing data. Can be used during JSON creation
        [JsonProperty]
        private string message;                                                             // Variable for storing data. Can be used during JSON creation

        // Methods

        // Getter method for retreiving message type data of an instance.
        public string getMessageType()
        {
            return messageType;                                                             // Return variable of current instance 
        }

        // Setter method for defining message type data of an instance to parameter.
        public void setMessageType(string messageType)
        {
            this.messageType = messageType;                                                 // Set variable to parameter for current instance          
        }

        // Getter method for retreiving message ID of an instance.
        public string getMessageID()
        {
            return messageID;                                                               // Return variable of current instance 
        }

        // Setter method for defining message ID data of an instance to parameter.
        public void setMessageID(string messageID)
        {
            this.messageID = messageID;                                                     // Set variable to parameter for current instance
        }

        // Getter method for retreiving sender data of an instance.
        public string getSender()
        {
            return sender;                                                                  // Return variable of current instance 
        }

        // Setter method for defining sender data of an instance to parameter.
        public void setSender(string sender)
        {
            this.sender = sender;                                                           // Set variable to parameter for current instance
        }

        // Getter method for retreiving message data of an instance.
        public string getMessage()
        {
            return message;                                                                 // Return variable of current instance 
        }

        // Setter method for defining message data of an instance to parameter.
        public void setMessage(string message)
        {
            this.message = message;                                                         // Set variable to parameter for current instance
        }
    }
}
