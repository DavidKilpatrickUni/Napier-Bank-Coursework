using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napier_Bank_Coursework
{
    // Singleton class 
    // Stores variables and methods in relation to Singleton
    // Can create and alter instances of the given object
    // Used to store the data lists utilised throughout the program
    // Singleton allows the creation of a single instnce of the class. Any new creation of an object instance is overridden and the original is used. 
    // Means that the lists used in this class can be used throughout the program and used in different forms without having to create new objects or passing objects around which is difficult.
    // Saves on duplication, alteration and creation errors that may occur.

    public sealed class Singleton
    {
        // Variables

        private IDictionary<String, int> quarantinedList = new Dictionary<string, int>();                       // Dictionary variable for storing quarantined website data. String Key, int value.
        private IDictionary<String, int> SIRList = new Dictionary<string, int>();                               // Dictionary variable for storing SIR report data. String Key, int value.
        private IDictionary<String, int> mentionList = new Dictionary<string, int>();                           // Dictionary variable for storing mentions data. String Key, int value.
        private IDictionary<String, int> trendingList = new Dictionary<string, int>();                          // Dictionary variable for storing trending hashtags data. String Key, int value.

        private static Singleton instance = null;

        // Singleton creation. If statement checks if an instance of Sigleton has been created. If true it returns that instance, if false creates the first and only instance.
        public static Singleton Instance
        {
            get
            {
                if (instance == null)                                                                           // If statement. If instance equals null
                {
                    instance = new Singleton();                                                                 // Create instance of singleton using constructor
                }   
                return instance;                                                                                // Return the instance of singleton
            }
        }

        // Methods

        // Method for executing other methods with the goal of creating and populating the data lists
        public void dataGen()
        {
            setTrendingList();                                                                                  // Call method to populate Dictionary
            setQuarantinedList();                                                                               // Call method to populate Dictionary
            setMentionList();                                                                                   // Call method to populate Dictionary
            setSIRList();                                                                                       // Call method to populate Dictionary
        }

        // Method for adding entries to the trending list dictionary
        public void setTrendingList()
        {
            trendingList.Add("#Edinburgh", 3);                                                                  // Add Key data and Value data to stated dictionary
            trendingList.Add("#Napier", 2);                                                                     // Add Key data and Value data to stated dictionary
            trendingList.Add("#Uni", 1);                                                                        // Add Key data and Value data to stated dictionary
        }

        // Method for retrieving the trending list dictionary
        public IDictionary<string, int> getTrendingList()
        {
            return trendingList;                                                                                // Return variable of current instance 
        }

        // Method for adding entries to the quarantined website dictionary
        public void setQuarantinedList()
        { 
            quarantinedList.Add("www.napier.com", 1);                                                           // Add Key data and Value data to stated dictionary
            quarantinedList.Add("www.napier.co.uk", 3);                                                         // Add Key data and Value data to stated dictionary
            quarantinedList.Add("http//www.napier.co.uk", 1);                                                   // Add Key data and Value data to stated dictionary
            quarantinedList.Add("https//www.napier.com", 2);                                                    // Add Key data and Value data to stated dictionary

        }

        // Method for retrieving the quarantined website dictionary
        public IDictionary<string, int> getQuarantinedList()
        {
            return quarantinedList;                                                                             // Return variable of current instance 
        }

        // Method for adding entries to the mention dictionary
        public void setMentionList()
        {
            mentionList.Add("@Student", 1);                                                                     // Add Key data and Value data to stated dictionary
            mentionList.Add("@Lecturer", 3);                                                                    // Add Key data and Value data to stated dictionary
            mentionList.Add("@Teacher", 2);                                                                     // Add Key data and Value data to stated dictionary
        }

        // Method for retrieving the mention dictionary
        public IDictionary<string, int> getMentionList()
        {
            return mentionList;                                                                                 // Return variable of current instance 
        }

        // Method for adding entries to the given dictionary
        public void setSIRList()
        {
            SIRList.Add("12-34-56 Theft", 1);                                                                   // Add Key data and Value data to stated dictionary
            SIRList.Add("98-76-54 Raid", 3);                                                                    // Add Key data and Value data to stated dictionary
            SIRList.Add("91-82-73 Terrorism", 2);                                                               // Add Key data and Value data to stated dictionary
        }

        // Method for retrieving the SIR report dictionary
        public IDictionary<string, int> getSIRList()
        {
            return SIRList;                                                                                     // Return variable of current instance 
        }
    
    }
}
