using System.Collections.Generic;
using System.IO;
using System;

namespace Develop02
{
    public class File
    {
        public string journalName = "journal";
        public string journalContents = "";

        

        public void SaveJournal(Journal journal)
        {
            Console.WriteLine("What do you want to name your journal?");
            journalName = Console.ReadLine();
            Console.WriteLine(journalName);
            using (StreamWriter outputFile = new StreamWriter(journalName))
            {
                List<Entry> entries = journal.GetEntries();
                foreach (Entry entry in entries)
                {
                    string message 
                    = $"{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}\n";
                    outputFile.WriteLine(message);
                }
            }
            
        }
        public void LoadJournal()
        {
            Console.WriteLine("What is the name of the journal you want to upload?");
            journalName = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(journalName);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}