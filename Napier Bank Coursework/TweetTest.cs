using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Napier_Bank_Coursework
{
    // Test class created to test the Tweet class.

    [TestClass]
    public class TweetTest
    {
        // Test the default constructor of the class.

        [TestMethod]
        public void defaultConstructorTest()
        {
            string message;                                                                 // String variable for storing data

            message = null;                                                                 // Set data for variable

            Tweet tweet = new Tweet();                                                      // Create instance of object

            string expectedResult = message;                                                // String variable for testing
            string actualResult = tweet.getMessage();                                       // String variable for testing

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

            messageType = "Tweet";                                                          // Set data for variable
            messageID = "T123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            Tweet tweet = new Tweet(messageID, sender, message);                            // Create instance of object

            string expectedResult = messageType;                                            // String variable for testing
            string actualResult = tweet.getMessageType();                                   // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message type data is "Tweet"
        }

        // Test the Setter method for defining message type data of an instance.

        [TestMethod]
        public void setMessageType()
        {
            string messageType;                                                             // String variable for storing data
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "T123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            Tweet tweet = new Tweet(messageID, sender, message);                            // Create instance of object

            messageType = "Test Tweet";                                                     // Set data for variable
            tweet.setMessageType(messageType);                                              // Set data for instance

            string expectedResult = messageType;                                            // String variable for testing
            string actualResult = tweet.getMessageType();                                   // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message type data is "Test Tweet"
        }

        // Test the Getter method for retreiving message ID data of an instance.

        [TestMethod]
        public void getMessageIDTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "T123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            Tweet tweet = new Tweet(messageID, sender, message);                            // Create instance of object

            string expectedResult = messageID;                                              // String variable for testing
            string actualResult = tweet.getMessageID();                                     // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message ID data is "T123456789"
        }

        // Test the Setter method for defining message ID data of an instance.

        [TestMethod]
        public void setMessageIDTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "";                                                                 // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            message = "Test Message";                                                       // Set data for variable


            Tweet tweet = new Tweet(messageID, sender, message);                            // Create instance of object

            messageID = "T123456789";                                                       // Set data for variable
            tweet.setMessageID(messageID);                                                  // Set data for instance

            string expectedResult = messageID;                                              // String variable for testing
            string actualResult = tweet.getMessageID();                                     // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message ID data is "T123456789"
        }

        // Test the Getter method for retreiving sender data of an instance.

        [TestMethod]
        public void getSenderTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "T123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            Tweet tweet = new Tweet(messageID, sender, message);                            // Create instance of object

            string expectedResult = sender;                                                 // String variable for testing
            string actualResult = tweet.getSender();                                        // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert sender data is "Test Sender"
        }

        // Test the Setter method for defining sender data of an instance.

        [TestMethod]
        public void setSenderTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "T123456789";                                                       // Set data for variable
            sender = "";                                                                    // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            Tweet tweet = new Tweet(messageID, sender, message);                            // Create instance of object

            sender = "Test Sender";                                                         // Set data for variable
            tweet.setSender(sender);                                                        // Set data for instance

            string expectedResult = sender;                                                 // String variable for testing
            string actualResult = tweet.getSender();                                        // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert sender data is "Test Sender"
        }

        // Test the Getter method for retreiving message data of an instance.

        [TestMethod]
        public void getMessageTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "T123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            Tweet tweet = new Tweet(messageID, sender, message);                            // Create instance of object

            string expectedResult = message;                                                // String variable for testing
            string actualResult = tweet.getMessage();                                       // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message data is "Test Message"
        }

        // Test the Setter method for defining message data of an instance.

        [TestMethod]
        public void setMessageTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "T123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            message = "";                                                                   // Set data for variable

            Tweet tweet = new Tweet(messageID, sender, message);                            // Create instance of object

            message = "Test Message";                                                       // Set data for variable
            tweet.setMessage(message);                                                      // Set data for instance

            string expectedResult = message;                                                // String variable for testing
            string actualResult = tweet.getMessage();                                       // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message data is "Test Message"
        }

    }
}
