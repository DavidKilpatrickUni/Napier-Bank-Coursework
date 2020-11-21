using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napier_Bank_Coursework
{
    // SMS class 
    // Stores variables and methods in relation to sms messages
    // Can create and alter instances of the given object

    class SMS : Message                                                     // Tweet Subclass inheriting from Message Superclass
    {       

        // Variables

        readonly string messageType = "SMS";                                // Set read only variable. All instances of this object are of the 'SMS' message type

        // Constructors
        // Default

        // Constructor for SMS class with no parameters.
        public SMS()
        {
      
        }

        // Overloaded

        // Constuctor for SMS class with parameters for defining messageID, sender and message. Message type is predefined. Used for creating sms messages
        public SMS(string messageID, string sender, string message)
        {
            base.setMessageType(messageType);                               // Set data to parameter
            base.setMessageID(messageID);                                   // Set data to parameter using method from Superclass
            base.setSender(sender);                                         // Set data to parameter using method from Superclass
            base.setMessage(message);                                       // Set data to parameter using method from Superclass
        }

    }
}
