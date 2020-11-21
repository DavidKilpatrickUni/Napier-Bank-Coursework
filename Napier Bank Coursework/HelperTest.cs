using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Napier_Bank_Coursework
{

    [TestClass]
    public class HelperTest
    {

        [TestMethod]
        public void isNumericTestTrue()
        {
            string testValue;

            testValue = "1234";

            bool expectedResult = true;
            bool actualResult = Helper.isNumeric(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void isNumericTestFalse()
        {
            string testValue;

            testValue = "Test";

            bool expectedResult = false;
            bool actualResult = Helper.isNumeric(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void checkHeaderLengthTrue()
        {
            string testValue;

            testValue = "E123456789";

            bool expectedResult = true;
            bool actualResult = Helper.checkHeaderLength(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void checkHeaderLengthFalse()
        {
            string testValue;

            testValue = "Wrong";

            bool expectedResult = false;
            bool actualResult = Helper.checkHeaderLength(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void checkSenderSymbolTrue()
        {
            string testValue;

            testValue = "Sender@";

            bool expectedResult = true;
            bool actualResult = Helper.checkSenderSymbol(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void checkSenderSymbolFalse()
        {
            string testValue;

            testValue = "Sender";

            bool expectedResult = false;
            bool actualResult = Helper.checkSenderSymbol(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void checkSenderEmailTrue1()
        {
            string testValue;

            testValue = "Test@test.com";

            bool expectedResult = true;
            bool actualResult = Helper.checkSenderEmail(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void checkSenderEmailTrue2()
        {
            string testValue;

            testValue = "Test@test.co.uk";

            bool expectedResult = true;
            bool actualResult = Helper.checkSenderEmail(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void checkSenderEmailFalse1()
        {
            string testValue;

            testValue = "Testtest";

            bool expectedResult = false;
            bool actualResult = Helper.checkSenderEmail(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void checkSenderEmailFalse2()
        {
            string testValue;

            testValue = "Test@test";

            bool expectedResult = false;
            bool actualResult = Helper.checkSenderEmail(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void checkSenderEmailFalse3()
        {
            string testValue;

            testValue = "Testtest.co.uk";

            bool expectedResult = false;
            bool actualResult = Helper.checkSenderEmail(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void checkSenderEmailFalse4()
        {
            string testValue;

            testValue = "Testtest.com";

            bool expectedResult = false;
            bool actualResult = Helper.checkSenderEmail(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void checkForSIRTrue()
        {
            string testValue;

            testValue = "Test SIR";

            bool expectedResult = true;
            bool actualResult = Helper.checkForSIR(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void checkForSIRFalse()
        {
            string testValue;

            testValue = "Test Wrong";

            bool expectedResult = false;
            bool actualResult = Helper.checkForSIR(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void checkSIRFormatTrue()
        {
            string testValue;

            testValue = "SIR 12/12/12";

            bool expectedResult = true;
            bool actualResult = Helper.checkSIRFormat(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void checkSIRFormatFalse1()
        {
            string testValue;

            testValue = "SIR ";

            bool expectedResult = false;
            bool actualResult = Helper.checkSIRFormat(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void checkSIRFormatFalse2()
        {
            string testValue;

            testValue = "SIR 12/12/";

            bool expectedResult = false;
            bool actualResult = Helper.checkSIRFormat(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void checkSIRFormatFalse3()
        {
            string testValue;

            testValue = "SIR 12/20/12";

            bool expectedResult = false;
            bool actualResult = Helper.checkSIRFormat(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void checkHeaderNumericTrue()
        {
            string testValue;

            testValue = "S123456789";

            bool expectedResult = true;
            bool actualResult = Helper.checkHeaderNumeric(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void checkHeaderNumericFalse()
        {
            string testValue;

            testValue = "S12345678G";

            bool expectedResult = false;
            bool actualResult = Helper.checkHeaderNumeric(testValue);

            Assert.AreEqual(expectedResult, actualResult);

        }

    }
}
