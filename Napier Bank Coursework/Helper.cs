using LumenWorks.Framework.IO.Csv;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Napier_Bank_Coursework
{
    class Helper
    {
        readonly static string filePath = @"C:\Users\Random\Desktop\Uni - Software Engineering\Bank.json";

       
        public static bool isNumeric(string inputString)
        {

            int numberOutput;
            bool result;
            

            numberOutput = 0;

            result = int.TryParse(inputString, out numberOutput);

            return result;
        }

    

    public static bool checkHeaderLength(string header)
        {
            bool result;

            result = true;

            if (header.Length != 10)
            {
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

            lengthOfBody = messageBody.Length + 1;
            lengthOfSender = firstIndexMessage - (firstIndexSender + 9);

            if (lengthOfSender < minLength || lengthOfSender > maxLength)
            {
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
                return false;
            }

            return true;

        }

        public static bool checkSenderSymbol(string sender)
        {
            if (!sender.Contains("@"))
            {
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

            

            if (firstIndexSubject < firstIndexMessage)
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

            Console.WriteLine("index: " + firstIndexSubject);

            if (firstIndexSubject < firstIndexMessage && firstIndexSubject > 0)
            {
                return true;
            }

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

            if (lengthOfSubject < 1)
            {
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




    }
}
