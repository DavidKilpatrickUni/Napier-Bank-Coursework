using LumenWorks.Framework.IO.Csv;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Napier_Bank_Coursework
{
    class Helper
    {
        readonly static string filePath = @"C:\Users\Random\Desktop\Bank.json";

        public static bool processHeader(string messageID)
        {
            bool checkComplete;

            checkComplete = false;

            if (!Helper.checkHeaderLength(messageID))
            {
                
                return checkComplete;
            }

            if (!Helper.checkHeaderNumeric(messageID))
            {

                return checkComplete;
            }

            checkComplete = true;

            return checkComplete;

        }

  

        public static bool isNumeric(string inputString)
        {

            Int64 numberOutput;
            bool result;
            
            numberOutput = 0;

            result = Int64.TryParse(inputString, out numberOutput);

            return result;
        }

    

    public static bool checkHeaderLength(string header)
        {
            bool result;

            result = true;

           

            if (header.Length != 10)
            {
                MessageBox.Show("Invalid Message Header (MessageID Must Be 10 Characters)", "Error");
                result = false;
                
            }

            return result;
        }

        public static string textSpeakConverter(string messageText)
        {
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"C:\Users\Random\Desktop\Uni - Software Engineering\textwords.csv")), true))
            {
                csvTable.Load(csvReader);
                for (int i = 0; i < csvTable.Rows.Count; i++)
                {
                   
                    string rowData = csvTable.Rows[i][0].ToString();
 
                    messageText = messageText.Replace(rowData, rowData + " <" + csvTable.Rows[i][1].ToString() + ">");

                }
            }
 
            return messageText;
        }

        public static void createJSONSMS(SMS record)
        {
            string path;
            string JSONResult;


            path = filePath;
            JSONResult = JsonConvert.SerializeObject(record);

            if (File.Exists(path))
            {
             
                using (var sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(JSONResult.ToString());

                    sw.Close();

                }
            }
            else if (!File.Exists(path))
            {
                using (var sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(JSONResult.ToString());

                    sw.Close();
                }
            }


        }

        public static void createJSONTweet(Tweet record)
        {
            string path;
            string JSONResult;


            path = filePath;
            JSONResult = JsonConvert.SerializeObject(record);

            if (File.Exists(path))
            {

                using (var sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(JSONResult.ToString());

                    sw.Close();

                }
            }
            else if (!File.Exists(path))
            {
                using (var sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(JSONResult.ToString());

                    sw.Close();
                }
            }


        }

        public static void createJSONEmail(Email record)
        {
            string path;
            string JSONResult;


            path = filePath;
            JSONResult = JsonConvert.SerializeObject(record);

            if (File.Exists(path))
            {

                using (var sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(JSONResult.ToString());

                    sw.Close();

                }
            }
            else if (!File.Exists(path))
            {
                using (var sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(JSONResult.ToString());

                    sw.Close();
                }
            }


        }

        public static bool checkSenderLength(string messageBody, int minLength, int maxLength)
        {
            string findSender;
            string findMessage;

            int firstIndexSender;
            int firstIndexMessage;

            int lengthOfBody;
            int lengthOfSender;


            findSender = "Sender:";
            findMessage = "Message Text:";

            firstIndexSender = messageBody.IndexOf(findSender);
            firstIndexMessage = messageBody.IndexOf(findMessage);

            Console.WriteLine(firstIndexSender);
            Console.WriteLine(firstIndexMessage);
            lengthOfBody = messageBody.Length + 1;
            lengthOfSender = firstIndexMessage - (firstIndexSender + 9);

            Console.WriteLine(lengthOfSender);

            if (lengthOfSender < minLength || lengthOfSender > maxLength )
            {
                MessageBox.Show("Invalid Sender (Check Rules For MessageType)", "Error");
                return false;
            }

            return true;

        }

        public static bool checkSenderNumeric(string messageBody)
        {
            string findSender;
            string findMessage;

            int firstIndexSender;
            int firstIndexMessage;

            int lengthOfBody;
            int lengthOfSender;

            string returnSender;

            findSender = "Sender:";
            findMessage = "Message Text:";

            firstIndexSender = messageBody.IndexOf(findSender);
            firstIndexMessage = messageBody.IndexOf(findMessage);

            lengthOfBody = messageBody.Length + 1;
            lengthOfSender = firstIndexMessage - (firstIndexSender + 9);

            returnSender = messageBody.Substring(firstIndexSender + 8, lengthOfSender);

            if (!Helper.isNumeric(returnSender))
            {
   
                MessageBox.Show("Invalid Sender (Phone Number Should Only Contain Digits)", "Error");
                return false;
            }

            return true;

        }

        public static bool checkSenderSymbol(string sender)
        {
            if (!sender.Contains("@"))
            {
                MessageBox.Show("Invalid TwitterID (Does Not Conatain A @ Symbol)", "Error");
                return false;
            }

            return true;
        }

        public static bool checkSenderEmail(string sender)
        {
            bool emailFound;

            emailFound = false;

            MatchCollection mc = Regex.Matches(sender, @"\b@\S*com\b|\b@\S*co.uk\b");
            foreach (Match m in mc)
            {
                emailFound = true;
            }

            if (!emailFound)
            {
                MessageBox.Show("Invalid Email Address (Does Not Contain Email Characteristics (@ symbol, .com, .co.uk etc)", "Error");
                return false;
            }

            return true;

        }

        public static string getSender(string messageBody)
        {
            string findSender;
            string findSubject;
            string findMessage;

            int firstIndexSender;
            int firstIndexSubject;
            int firstIndexMessage;

            int lengthOfBody;
            int lengthOfSender;

            string returnSender;

            int firstIndexCompare;

            findSender = "Sender:";
            findSubject = "Subject:";
            findMessage = "Message Text:";

            firstIndexSender = messageBody.IndexOf(findSender);
            firstIndexSubject = messageBody.IndexOf(findSubject);
            firstIndexMessage = messageBody.IndexOf(findMessage);

            

            if (firstIndexSubject < firstIndexMessage && firstIndexSubject > 0)
            {
                firstIndexCompare = firstIndexSubject;
            }
            else
            {
                firstIndexCompare = firstIndexMessage;
            }

            lengthOfBody = messageBody.Length + 1;
            lengthOfSender = firstIndexCompare - (firstIndexSender + 9);

            returnSender = messageBody.Substring(firstIndexSender + 8, lengthOfSender);

            return returnSender;

        }


        public static bool checkForSubject(string messageBody)
        {
            string findSubject;
   
            string findMessage;

            int firstIndexSubject;
           
            int firstIndexMessage;

            findSubject = "Subject:";
            
            findMessage = "Message Text:";

            firstIndexSubject = messageBody.IndexOf(findSubject);

            firstIndexMessage = messageBody.IndexOf(findMessage);



            if (firstIndexSubject < firstIndexMessage && firstIndexSubject > 0)
            {
               
                return true;
            }
            MessageBox.Show("Invalid Email (No Subject Title)", "Error");
            return false;
        }

        public static bool checkSubjectLength(string messageBody)
        {
            string findSubject;

            string findMessage;

            int firstIndexSubject;

            int firstIndexMessage;

            int lengthOfSubject;

            findSubject = "Subject:";

            findMessage = "Message Text:";

            firstIndexSubject = messageBody.IndexOf(findSubject);

            firstIndexMessage = messageBody.IndexOf(findMessage);

            lengthOfSubject = firstIndexMessage - (firstIndexSubject + 10);

            if (lengthOfSubject < 1 || lengthOfSubject > 19)
            {
                MessageBox.Show("Invalid Email (Subject Character Count)", "Error");
                return false;
            }

            return true;
        }

        public static string getSubject(string messageBody)
        {
            string findSubject;
           
            string findMessage;

            int firstIndexSubject;
      
            int firstIndexMessage;

   
            int lengthOfSubject;

            string returnSubject;


            findSubject = "Subject:";
          
            findMessage = "Message Text:";

            firstIndexSubject = messageBody.IndexOf(findSubject);
   
            firstIndexMessage = messageBody.IndexOf(findMessage);        

          
            lengthOfSubject = firstIndexMessage - (firstIndexSubject + 10);

            returnSubject = messageBody.Substring(firstIndexSubject + 9, lengthOfSubject);

            return returnSubject;
        }
        public static bool checkForSIR(string messageSubject)
        {

            string findSir;

            findSir = "SIR";

            if (messageSubject.Contains(findSir))
            { 
                return true;
            }

            return false;
        }

        public static bool checkSIRFormat(string messageSubject)
        {
            DateTime dateTime;
            bool correctFormat;
     
            string date;

           

            date = messageSubject.Remove(0,4);

            correctFormat = DateTime.TryParseExact(date, "dd/MM/yy",null, DateTimeStyles.None, out dateTime);

            if (correctFormat)
            {
                return true;
            }
            MessageBox.Show("Wrong SIR Format:", "Error");
            return false;

        }

        public static bool checkForSortCode(string messageBody)
        {
            string findSortCode;

            int firstIndexSortCode;

            int messageBodyLength;

            findSortCode = "Sort Code:";

            messageBodyLength = messageBody.Length;
        

            firstIndexSortCode = messageBody.IndexOf(findSortCode);


            if (firstIndexSortCode < messageBodyLength && firstIndexSortCode > 0)
            {
                return true;
            }
            MessageBox.Show("No Sort Code:", "Error");
            return false;
        }

        public static bool checkSortCodeLength(string messageBody)
        {
            string findSortCode;
            string findNatureOfIncident;

            int firstIndexSortCode;
            int firstIndexNatureOfIncident;

            int lengthOfSortCode;
            

            findSortCode = "Sort Code:";
            findNatureOfIncident = "Nature Of Incident:";

            firstIndexSortCode = messageBody.IndexOf(findSortCode);
            firstIndexNatureOfIncident = messageBody.IndexOf(findNatureOfIncident);

            lengthOfSortCode = (firstIndexNatureOfIncident - (firstIndexSortCode + 12));

            if (lengthOfSortCode != 8)
            {
                MessageBox.Show("Invalid Sort Code (Length)", "Error");
                return false;
            }

            return true;
        }

        public static bool checkSortCodeFormat(string messageBody)
        {
            string findSortCode;

         

            int firstIndexSortCode;




            int lengthOfSortCode;

            string returnSortCode;

            bool correctFormat;


            findSortCode = "Sort Code:";

 

            firstIndexSortCode = messageBody.IndexOf(findSortCode);

            


            lengthOfSortCode = 8;

            returnSortCode = messageBody.Substring(firstIndexSortCode + 11, lengthOfSortCode);
    

            correctFormat = Regex.IsMatch(returnSortCode, @"[0-9][0-9]\-[0-9][0-9]\-[0-9][0-9]");

            if (correctFormat)
            {
                return true;
            }
            MessageBox.Show("Invalid Sort Code (Wrong Format)", "Error");
            return false;
        }

        public static string getSortCode(string messageBody)
        {
            string findSortCode;

            int firstIndexSortCode;

            int lengthOfSortCode;

            string returnSortCode;


            findSortCode = "Sort Code:";

            firstIndexSortCode = messageBody.IndexOf(findSortCode);

            lengthOfSortCode = 8;

            returnSortCode = messageBody.Substring(firstIndexSortCode + 11, lengthOfSortCode);

            return returnSortCode;
        }

        public static bool checkForNatureOfIncident(string messageBody)
        {
            string findNatureOfIncident;

        

            int firstIndexNatureOfIncident;
            int messageBodyLength;


            findNatureOfIncident = "Nature Of Incident:";
            messageBodyLength = messageBody.Length;


            firstIndexNatureOfIncident = messageBody.IndexOf(findNatureOfIncident);

          



            if (firstIndexNatureOfIncident < messageBodyLength && firstIndexNatureOfIncident > 0)
            {
                return true;
            }
            MessageBox.Show("No Nature Of Incident", "Error");
            return false;
        }
        public static bool checkNatureOfIncident(string messageBody)
        {
            string findNatureOfIncident;

            int firstIndexNatureOfIncident;

            int lengthOfNatureOfIncident;

            string returnNatureOfIncident;

            findNatureOfIncident = "Nature Of Incident:";

            firstIndexNatureOfIncident = messageBody.IndexOf(findNatureOfIncident);

            lengthOfNatureOfIncident = 10;

            returnNatureOfIncident = (messageBody.Substring(firstIndexNatureOfIncident + 20, lengthOfNatureOfIncident));

            string[] typesOfIncidentList = { "Theft", "Raid", "Bomb" };


            for (int i = 0; i < typesOfIncidentList.Length; i++)
            {
                if (returnNatureOfIncident.Contains(typesOfIncidentList[i]))
                {
                    //MessageBox.Show("nature of incident: " + typesOfIncidentList[i]);
                    returnNatureOfIncident = typesOfIncidentList[i];
                    return true;
                }
            }
            MessageBox.Show("No Nature Of Incident That Kind", "Error");
            return false;
        }
        public static string getNatureOfIncident(string messageBody)
        {
            string findNatureOfIncident;


            int firstIndexNatureOfIncident;


            int lengthOfNatureOfIncident;

            string returnNatureOfIncident;

            findNatureOfIncident = "Nature Of Incident:";

            firstIndexNatureOfIncident = messageBody.IndexOf(findNatureOfIncident);

            lengthOfNatureOfIncident = 10;

            returnNatureOfIncident = (messageBody.Substring(firstIndexNatureOfIncident + 20, lengthOfNatureOfIncident));

            string[] typesOfIncidentList = { "Theft", "Raid", "Bomb" };


            for (int i = 0; i < typesOfIncidentList.Length; i++)
            {
                if (returnNatureOfIncident.Contains(typesOfIncidentList[i]))
                {
                    //MessageBox.Show("nature of incident: " + typesOfIncidentList[i]);
                    returnNatureOfIncident = typesOfIncidentList[i];

                }
            }

            return returnNatureOfIncident;
        }


        public static bool checkMessageText(string messageBody, int minLength, int maxLength)
        {

            string findMessage;


            int firstIndexMessage;

            int lengthOfBody;
            int lengthOfMessageText;

            findMessage = "Message Text:";

            firstIndexMessage = messageBody.IndexOf(findMessage);

            lengthOfBody = messageBody.Length + 1;




            lengthOfMessageText = lengthOfBody - (firstIndexMessage + 15);

            if (lengthOfMessageText < minLength || lengthOfMessageText > maxLength)
            {
                MessageBox.Show("Invalid Message Text Length (Message Text Must Be Greater the " + minLength + " And Less Than " + maxLength + " Characters", "Error");
                return false;
            }

            return true;

        }

        public static string getMessageText(string messageBody)
        {

            string findMessage;


            int firstIndexMessage;

            int lengthOfBody;
            int lengthOfMessageText;

            string returnMessageText;


            findMessage = "Message Text:";

            firstIndexMessage = messageBody.IndexOf(findMessage);

            lengthOfBody = messageBody.Length + 1;

            lengthOfMessageText = lengthOfBody - (firstIndexMessage + 15);

            returnMessageText = messageBody.Substring(firstIndexMessage + 14, lengthOfMessageText);

            returnMessageText = Helper.textSpeakConverter(returnMessageText);

            return returnMessageText;

        }

        public static string getRemainingMessageText(string messageBody)
        {

            string findNatureOfIncident;


            int firstIndexNatureOfIncident;

            int lengthOfBody;
            int lengthOfRemainingMessageText;

            string returnRemainingMessageText;


            findNatureOfIncident = "Nature Of Incident:";

            firstIndexNatureOfIncident = messageBody.IndexOf(findNatureOfIncident);

            lengthOfBody = messageBody.Length + 1;

            lengthOfRemainingMessageText = lengthOfBody - (firstIndexNatureOfIncident + 26);

            returnRemainingMessageText = messageBody.Substring(firstIndexNatureOfIncident + 25, lengthOfRemainingMessageText);

            returnRemainingMessageText = Helper.textSpeakConverter(returnRemainingMessageText);

            return returnRemainingMessageText;

        }

        public static string getHeaderType(string header)
        {
            string firstLetter;
            firstLetter = header.Substring(0, 1);

            switch (firstLetter)
            {
                case "S":
                    return "S";


                case "T":
                    return "T";


                case "E":
                    return "E";


                default:
                    MessageBox.Show("Invalid Message Type (Not SMS,Tweet or Email)", "Error");
                    return null;

            }

        }

        public static bool checkHeaderNumeric(string header)
        {
            string remainingtLetters;
            int numberOutput;
            bool result;

            remainingtLetters = header.Substring(1, 9);
            numberOutput = 0;

            result = int.TryParse(remainingtLetters, out numberOutput);

            if (!result)
            {
                MessageBox.Show("Invalid Message Type (Not numeric characters)", "Error");
            }

            return result;



        }
        public static void findHashTags(string messageText)
        {
            IDictionary<String, int> hashTagList = Singleton.Instance.getTrendingList();

            MatchCollection mc = Regex.Matches(messageText, @"#\S*\b");
            foreach (Match m in mc)
            {

                if (!hashTagList.ContainsKey(m.ToString()))
                {
                    hashTagList.Add(m.ToString(), 1);
                }
                else
                {
                    int count;

                    if (hashTagList.TryGetValue(m.ToString(), out count))
                    {
                        hashTagList[m.ToString()] = count + 1;
                    }
                }

            }

        }

        public static IDictionary<string, int> displayHashTags(string messageText)
        {
            IDictionary<String, int> displayHashTagList = new Dictionary<string, int>();

            MatchCollection mc = Regex.Matches(messageText, @"#\S*\b");
            foreach (Match m in mc)
            {

                if (!displayHashTagList.ContainsKey(m.ToString()))
                {
                    displayHashTagList.Add(m.ToString(), 1);
                }
                else
                {
                    int count;

                    if (displayHashTagList.TryGetValue(m.ToString(), out count))
                    {
                        displayHashTagList[m.ToString()] = count + 1;
                    }
                }

            }
            return displayHashTagList;

        }

        public static void findMentions(string messageText)
        {
            IDictionary<String, int> mentionList = Singleton.Instance.getMentionList();

            MatchCollection mc = Regex.Matches(messageText, @"@\S*\b");
            foreach (Match m in mc)
            {

                if (!mentionList.ContainsKey(m.ToString()))
                {
                    mentionList.Add(m.ToString(), 1);
                }
                else
                {
                    int count;

                    if (mentionList.TryGetValue(m.ToString(), out count))
                    {
                        mentionList[m.ToString()] = count + 1;
                    }
                }

            }

        }

        public static IDictionary<string, int> displayMentions(string messageText)
        {
            IDictionary<String, int> displayMentionList = new Dictionary<string, int>();

            MatchCollection mc = Regex.Matches(messageText, @"@\S*\b");
            foreach (Match m in mc)
            {

                if (!displayMentionList.ContainsKey(m.ToString()))
                {
                    displayMentionList.Add(m.ToString(), 1);
                }
                else
                {
                    int count;

                    if (displayMentionList.TryGetValue(m.ToString(), out count))
                    {
                        displayMentionList[m.ToString()] = count + 1;
                    }
                }

            }
            return displayMentionList;

        }


        public static string findWebsites(string messageText)
        {
            IDictionary<String, int> quarantinedList = Singleton.Instance.getQuarantinedList();


            MatchCollection mc = Regex.Matches(messageText, @"\bhttp\S*|\bhttps\S*|\bwww\S|\S*com\b|\S*co.uk\b");
                    foreach (Match m in mc)
                    {
               
                    messageText = messageText.Replace(m.ToString(), "<URL Quarantined>");

                        if (!quarantinedList.ContainsKey(m.ToString()))
                        {
                            quarantinedList.Add(m.ToString(), 1);
                        }
                        else
                        {
                            int count;

                            if (quarantinedList.TryGetValue(m.ToString(), out count))
                            {
                                quarantinedList[m.ToString()] = count + 1;
                            }
                        }

                    }

            return messageText;
        }

        public static IDictionary<string, int> displayWebsites(string messageText)
        {
            IDictionary<String, int> displayWebsiteList = new Dictionary<string, int>();

            MatchCollection mc = Regex.Matches(messageText, @"\bhttp\S*|\bhttps\S*|\bwww\S|\S*com\b|\S*co.uk\b");
            foreach (Match m in mc)
            {

                if (!displayWebsiteList.ContainsKey(m.ToString()))
                {
                    displayWebsiteList.Add(m.ToString(), 1);
                }
                else
                {
                    int count;

                    if (displayWebsiteList.TryGetValue(m.ToString(), out count))
                    {
                        displayWebsiteList[m.ToString()] = count + 1;
                    }
                }

            }
            return displayWebsiteList;

        }

        public static void addSIRRecord(string SIRRecord)
        {
            IDictionary<String, int> SIRList = Singleton.Instance.getSIRList();

            

                if (!SIRList.ContainsKey(SIRRecord.ToString()))
                {
                    SIRList.Add(SIRRecord.ToString(), 1);
                }
                else
                {
                    int count;

                    if (SIRList.TryGetValue(SIRRecord.ToString(), out count))
                    {
                        SIRList[SIRRecord.ToString()] = count + 1;
                    }
                }

            
        }





      

     


    }
}
