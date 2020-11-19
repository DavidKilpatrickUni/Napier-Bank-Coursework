using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napier_Bank_Coursework
{
    public sealed class Singleton
    {

        private IDictionary<String, int> quarantinedList = new Dictionary<string, int>();
        private IDictionary<String, int> SIRList = new Dictionary<string, int>();
        private IDictionary<String, int> mentionList = new Dictionary<string, int>();
        private IDictionary<String, int> trendingList = new Dictionary<string, int>();

        private static Singleton instance = null;

 
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        public void dataGen()
        {
            setTrendingList();
            setQuarantinedList();
            setMentionList();
            setSIRList();
        }


        public void setTrendingList()
        {
            trendingList.Add("#Edinburgh", 3);
            trendingList.Add("#Napier", 2);
            trendingList.Add("#Uni", 1);
        }

        public IDictionary<string, int> getTrendingList()
        {

            return trendingList;

        }

        public void setQuarantinedList()
        {
           
            quarantinedList.Add("www.edinburgh.com", 1);
            quarantinedList.Add("www.edinburgh.co.uk", 3);
            quarantinedList.Add("http//www.edinburgh.co.uk", 1);
            quarantinedList.Add("https//www.edinburgh.com", 1);
            quarantinedList.Add("www.napier.co.uk", 2);
            quarantinedList.Add("www.napier.com", 2);
            quarantinedList.Add("http//www.napier.co.uk", 3);
            quarantinedList.Add("https//www.napier.com", 1);

        }

        public IDictionary<string, int> getQuarantinedList()
        {
    
            return quarantinedList;

        }

        public void setMentionList()
        {

            mentionList.Add("@Student", 1);
            mentionList.Add("@Lecturer", 3);
            mentionList.Add("@Teacher", 2);
          

        }

        public IDictionary<string, int> getMentionList()
        {

            return mentionList;

        }

        public void setSIRList()
        {

            SIRList.Add("12-34-56 Theft", 1);
            SIRList.Add("98-76-54 Raid", 3);
            SIRList.Add("91-82-73 Terrorism", 2);


        }

        public IDictionary<string, int> getSIRList()
        {

            return SIRList;

        }
    
    }
}
