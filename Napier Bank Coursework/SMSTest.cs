using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Napier_Bank_Coursework
{
    // Test class created to test the Tweet class.

    [TestClass]
    public class SMSTest
    {
        // Test the default constructor of the class.

        [TestMethod]
        public void defaultConstructorTest()
        {
            string message;                                                                 // String variable for storing data

            message = null;                                                                 // Set data for variable

            SMS sms = new SMS();                                                            // Create instance of object

            string expectedResult = message;                                                // String variable for testing
            string actualResult = sms.getMessage();                                         // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message type data is "Null"
        }

        // Test the Getter method for retreiving message type data of an instance.

        [TestMethod]
        public void getMessageType()
        {
            string messageType;                                                             // String variable for storing data
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageType = "SMS";                                                            // Set data for variable
            messageID = "S123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            SMS sms = new SMS(messageID, sender, message);                                  // Create instance of object

            string expectedResult = messageType;                                            // String variable for testing
            string actualResult = sms.getMessageType();                                     // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message type data is "SMS"
        }

        // Test the Setter method for defining message type data of an instance.

        [TestMethod]
        public void setMessageType()
        {
            string messageType;                                                             // String variable for storing data
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "S123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            SMS sms = new SMS(messageID, sender, message);                                  // Create instance of object

            messageType = "Test SMS";                                                       // Set data for variable
            sms.setMessageType(messageType);                                                // Set data for instance

            string expectedResult = messageType;                                            // String variable for testing
            string actualResult = sms.getMessageType();                                     // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message type data is "SMS"
        }

        // Test the Getter method for retreiving message type data of an instance.

        [TestMethod]
        public void getMessageIDTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "S123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            SMS sms = new SMS(messageID, sender,  message);                                 // Create instance of object

            string expectedResult = messageID;                                              // String variable for testing
            string actualResult = sms.getMessageID();                                       // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message ID data is "S123465789"
        }

        // Test the Setter method for defining message type data of an instance.

        [TestMethod]
        public void setMessageIDTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "";                                                                 // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            SMS sms = new SMS(messageID, sender,  message);                                 // Create instance of object

            messageID = "S123456789";                                                       // Set data for variable
            sms.setMessageID(messageID);                                                    // Set data for instance

            string expectedResult = messageID;                                              // String variable for testing
            string actualResult = sms.getMessageID();                                       // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message ID data is "S123465789"
        }

        // Test the Getter method for retreiving message type data of an instance.

        [TestMethod]
        public void getSenderTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "S123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            SMS sms = new SMS(messageID, sender,  message);                                 // Create instance of object

            string expectedResult = sender;                                                 // String variable for testing
            string actualResult = sms.getSender();                                          // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert sender data is "Test Sender"
        }

        // Test the Setter method for defining message type data of an instance.

        [TestMethod]
        public void setSenderTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "S123456789";                                                       // Set data for variable
            sender = "";                                                                    // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            SMS sms = new SMS(messageID, sender,message);                                   // Create instance of object

            sender = "Test Sender";                                                         // Set data for variable
            sms.setSender(sender);                                                          // Set data for instance

            string expectedResult = sender;                                                 // String variable for testing
            string actualResult = sms.getSender();                                          // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert sender data is "Test Sender"
        }

        // Test the Getter method for retreiving message type data of an instance.

        [TestMethod]
        public void getMessageTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "S123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            SMS sms = new SMS(messageID, sender, message);                                  // Create instance of object

            string expectedResult = message;                                                // String variable for testing
            string actualResult = sms.getMessage();                                         // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message data is "Test Message"
        }

        // Test the Setter method for defining message type data of an instance.

        [TestMethod]
        public void setMessageTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "S123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            message = "";                                                                   // Set data for variable

            SMS sms = new SMS(messageID, sender,  message);                                 // Create instance of object

            message = "Test Message";                                                       // Set data for variable
            sms.setMessage(message);                                                        // Set data for instance

            string expectedResult = message;                                                // String variable for testing
            string actualResult = sms.getMessage();                                         // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message data is "Test Message"
        }

    }
}
