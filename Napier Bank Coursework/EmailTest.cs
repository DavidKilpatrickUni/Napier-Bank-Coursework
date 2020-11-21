using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Napier_Bank_Coursework
{
    // Test class created to test the Email class.

    [TestClass]
    public class EmailTest
    {
        // Test the default constructor of the class.

        [TestMethod]
        public void defaultConstructorTest()
        {
            string message;                                                                 // String variable for storing data

            message = null;                                                                 // Set data for variable

            Email email = new Email();                                                      // Create instance of object

            string expectedResult = message;                                                // String variable for testing
            string actualResult = email.getMessage();                                       // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message type data is "null"
        }

        // Test the Getter method for retreiving message type data of an instance.

        [TestMethod]
        public void getMessageType()
        {
            string messageType;                                                             // String variable for storing data
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string subject;                                                                 // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageType = "Email";                                                          // Set data for variable
            messageID = "E123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            subject = "Test Subject";                                                       // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            Email email = new Email(messageID, sender,subject, message);                    // Create instance of object

            string expectedResult = messageType;                                            // String variable for testing
            string actualResult = email.getMessageType();                                   // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message type data is "Email"
        }

        // Test the Setter method for defining message type data of an instance.

        [TestMethod]
        public void setMessageType()
        {
            string messageType;                                                             // String variable for storing data
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string subject;                                                                 // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "E123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            subject = "Test Subject";                                                       // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            Email email = new Email(messageID, sender,subject, message);                    // Create instance of object

            messageType = "Test Email";                                                     // Set data for variable
            email.setMessageType(messageType);                                              // Set data for instance

            string expectedResult = messageType;                                            // String variable for testing
            string actualResult = email.getMessageType();                                   // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message type data is "Test Email"
        }

        // Test the Getter method for retreiving message ID data of an instance.

        [TestMethod]
        public void getMessageIDTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string subject;                                                                 // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "E123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            subject = "Test Subject";                                                       // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            Email email = new Email(messageID, sender, subject, message);                   // Create instance of object

            string expectedResult = messageID;                                              // String variable for testing
            string actualResult = email.getMessageID();                                     // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message ID data is "E123456789"
        }

        // Test the Setter method for defining message ID data of an instance.

        [TestMethod]
        public void setMessageIDTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string subject;                                                                 // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "";                                                                 // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            subject = "Test Subject";                                                       // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            Email email = new Email(messageID, sender, subject, message);                   // Create instance of object

            messageID = "E123456789";                                                       // Set data for variable
            email.setMessageID(messageID);                                                  // Set data for instance

            string expectedResult = messageID;                                              // String variable for testing
            string actualResult = email.getMessageID();                                     // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message ID data is "E123456789"
        }

        // Test the Getter method for retreiving sender data of an instance.

        [TestMethod]
        public void getSenderTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string subject;                                                                 // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "E123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            subject = "Test Subject";                                                       // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            Email email = new Email(messageID, sender, subject, message);                   // Create instance of object

            string expectedResult = sender;                                                 // String variable for testing
            string actualResult = email.getSender();                                        // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert sender data is "Test Sender"
        }

        // Test the Setter method for defining sender data of an instance.

        [TestMethod]
        public void setSenderTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string subject;                                                                 // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "E123456789";                                                       // Set data for variable
            sender = "";                                                                    // Set data for variable
            subject = "Test Subject";                                                       // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            Email email = new Email(messageID, sender, subject, message);                   // Create instance of object

            sender = "Test Sender";                                                         // Set data for variable
            email.setSender(sender);                                                        // Set data for instance

            string expectedResult = sender;                                                 // String variable for testing
            string actualResult = email.getSender();                                        // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert sender data is "Test Sender"
        }

        // Test the Getter method for retreiving subject data of an instance.

        [TestMethod]
        public void getSubjectTest()
        {  
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string subject;                                                                 // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "E123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            subject = "Test Subject";                                                       // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            Email email = new Email(messageID,sender,subject,message);                      // Create instance of object

            string expectedResult = subject;                                                // String variable for testing
            string actualResult = email.getSubject();                                       // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert subject data is "Test Subject"
        }

        // Test the Setter method for defining subject data of an instance.

        [TestMethod]
        public void setSubjectTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string subject;                                                                 // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "E123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            subject = "";                                                                   // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            Email email = new Email(messageID, sender, subject, message);                   // Create instance of object

            subject = "Test Subject";                                                       // Set data for variable
            email.setSubject(subject);                                                      // Set data for instance

            string expectedResult = subject;                                                // String variable for testing
            string actualResult = email.getSubject();                                       // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert subject data is "Test Subject"
        }

        // Test the Getter method for retreiving message data of an instance.

        [TestMethod]
        public void getMessageTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string subject;                                                                 // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "E123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            subject = "Test Subject";                                                       // Set data for variable
            message = "Test Message";                                                       // Set data for variable

            Email email = new Email(messageID, sender, subject, message);                   // Create instance of object

            string expectedResult = message;                                                // String variable for testing
            string actualResult = email.getMessage();                                       // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message data is "Test Message"
        }

        // Test the Setter method for defining message data of an instance.

        [TestMethod]
        public void setMessageTest()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string subject;                                                                 // String variable for storing data
            string message;                                                                 // String variable for storing data

            messageID = "E123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            subject = "Test Subject";                                                       // Set data for variable
            message = "";                                                                   // Set data for variable

            Email email = new Email(messageID, sender, subject, message);                   // Create instance of object

            message = "Test Message";                                                       // Set data for variable
            email.setMessage(message);                                                      // Set data for instance

            string expectedResult = message;                                                // String variable for testing
            string actualResult = email.getMessage();                                       // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert message data is "Test Message"
        }

        // Test the Getter method for retreiving sort code data of an instance.

        [TestMethod]
        public void getSortCode()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string subject;                                                                 // String variable for storing data
            string message;                                                                 // String variable for storing data
            string sortCode;                                                                // String variable for storing data
            string natureOfIncident;                                                        // String variable for storing data

            messageID = "E123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            subject = "Test Subject";                                                       // Set data for variable
            message = "Test Message";                                                       // Set data for variable
            sortCode = "Test Sort Code";                                                    // Set data for variable
            natureOfIncident = "Test Nature of Incident";                                   // Set data for variable

            Email email = new Email(messageID, sender, subject,sortCode,natureOfIncident,message);  // Create instance of object

            string expectedResult = sortCode;                                               // String variable for testing
            string actualResult = email.getSortCode();                                      // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert sort code data is "Test Sort Code"
        }

        // Test the Setter method for defining sort code data of an instance.

        [TestMethod]
        public void setSortCode()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string subject;                                                                 // String variable for storing data
            string message;                                                                 // String variable for storing data
            string sortCode;                                                                // String variable for storing data
            string natureOfIncident;                                                        // String variable for storing data

            messageID = "E123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            subject = "Test Subject";                                                       // Set data for variable
            message = "Test Message";                                                       // Set data for variable
            sortCode = "";                                                                  // Set data for variable
            natureOfIncident = "Test Nature of Incident";                                   // Set data for variable

            Email email = new Email(messageID, sender, subject, sortCode, natureOfIncident, message);   // Create instance of object

            sortCode = "Test Sort Code";                                                    // Set data for variable
            email.setSortCode(sortCode);                                                    // Set data for instance

            string expectedResult = sortCode;                                               // String variable for testing
            string actualResult = email.getSortCode();                                      // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert sort code data is "Test Sort Code"
        }

        // Test the Getter method for retreiving nature of incident data of an instance.

        [TestMethod]
        public void getNatureOfIncident()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string subject;                                                                 // String variable for storing data
            string message;                                                                 // String variable for storing data
            string sortCode;                                                                // String variable for storing data
            string natureOfIncident;                                                        // String variable for storing data

            messageID = "E123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            subject = "Test Subject";                                                       // Set data for variable
            message = "Test Message";                                                       // Set data for variable
            sortCode = "Test Sort Code";                                                    // Set data for variable
            natureOfIncident = "Test Nature of Incident";                                   // Set data for variable

            Email email = new Email(messageID, sender, subject, sortCode, natureOfIncident, message);   // Create instance of object

            string expectedResult = natureOfIncident;                                       // String variable for testing
            string actualResult = email.getNatureOfIncident();                              // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert nature of incident data is "Test Nature Of Incident"
        }

        // Test the Setter method for defining nature of incident data of an instance.

        [TestMethod]
        public void setNatureOfIncident()
        {
            string messageID;                                                               // String variable for storing data
            string sender;                                                                  // String variable for storing data
            string subject;                                                                 // String variable for storing data
            string message;                                                                 // String variable for storing data
            string sortCode;                                                                // String variable for storing data
            string natureOfIncident;                                                        // String variable for storing data

            messageID = "E123456789";                                                       // Set data for variable
            sender = "Test Sender";                                                         // Set data for variable
            subject = "Test Subject";                                                       // Set data for variable
            message = "Test Message";                                                       // Set data for variable
            sortCode = "Test Sort Code";                                                    // Set data for variable
            natureOfIncident = "";                                                          // Set data for variable

            Email email = new Email(messageID, sender, subject, sortCode, natureOfIncident, message);   // Create instance of object

            natureOfIncident = "Test Nature of Incident";                                   // Set data for variable
            email.setNatureOfIncident(natureOfIncident);                                    // Set data for instance

            string expectedResult = natureOfIncident;                                       // String variable for testing
            string actualResult = email.getNatureOfIncident();                              // String variable for testing

            Assert.AreEqual(expectedResult, actualResult);                                  // Assert nature of incident data is "Test Nature Of Incident"
        }

    }
}
