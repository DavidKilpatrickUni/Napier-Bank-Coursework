using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napier_Bank_Coursework
{
    // Tweet class 
    // Stores variables and methods in relation to tweets
    // Can create and alter instances of the given object

    class Tweet : Message                                                   // Tweet Subclass inheriting from Message Superclass
    {

        // Variables

        readonly string messageType = "Tweet";                              // Set read only variable. All instances of this object are of the 'Tweet' message type

        // Constructors
        // Default

        // Constructor for Tweet class with no parameters.
        public Tweet()
        {
      
        }

        // Overloaded

        // Constuctor for Tweet class with parameters for defining messageID, sender and message. Message type is predefined. Used for creating tweets
        public Tweet(string messageID, string sender, string message)
        {
            base.setMessageType(messageType);                               // Set data to parameter
            base.setMessageID(messageID);                                   // Set data to parameter using method from Superclass
            base.setSender(sender);                                         // Set data to parameter using method from Superclass
            base.setMessage(message);                                       // Set data to parameter using method from Superclass
        }

    }
}
