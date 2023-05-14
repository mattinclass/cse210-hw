using System;
using System.Collections.Generic;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = -1;
            Journal journal = new Journal();
            
            while (selection != 0)
            {
            Console.WriteLine($"Welcome to the Journal Program!\nSelect an Option:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n");
            Console.WriteLine("Choose what you would like to do. ");
            selection = Int16.Parse(Console.ReadLine());

            if (selection == 1)
            {
                Entry myEntry = new Entry();
                string date = myEntry.GetDate();
                string prompt = myEntry.RecordPrompt();
                Console.WriteLine($"Date: {date} - Prompt: {prompt}");
                string response = myEntry.RecordResponse();
                myEntry.StoreResponse(response);
                myEntry.StoreDate(date);
                myEntry.StorePrompt(prompt);

                journal.StoreEntry(myEntry);
                
            }
            if (selection == 2)
            {
                List<Entry> entries = journal.GetEntries();
                foreach (Entry entry in entries)
                {
                    string message 
                    = $"{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}\n";
                    Console.WriteLine(message);
                }
            }
            if (selection == 3)
            {
                File myFile = new File();
                myFile.LoadJournal();
            }
            if (selection == 4)
            {
                File myFile = new File();
                myFile.SaveJournal(journal);
            }
            if (selection == 5)
            {
                selection = 0;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            }
            ///Entry myEntry = new Entry();
            ///myEntry.StorePrompt("What's your name?");
            ///myEntry.StoreResponse("Matt");
            ///myEntry.StoreDate("8 May 2023");

            ///Journal journal = new Journal();
            ///journal.StoreEntry(myEntry);
            ///File myFile = new File();
            ///myFile.SaveJournal();

            ///List<Entry> entries = journal.GetEntries();
            ///foreach (Entry entry in entries)
            ///{
                ///string message 
                    ///= $"{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}\n";
                ///Console.WriteLine(message);

                
                
            ///}
            
        }
    }
}