using System;
using System.Collections.Generic;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Reference myReference = new Reference();
            //Console.Clear();
            //Reference myReference = new Reference();
            Scripture myScripture = new Scripture();
            
            string activeReference = myReference.ChooseReference();
            string activeScripture = myScripture.GetScripture(activeReference);
            Console.WriteLine($"{activeReference}  {activeScripture}.");
            
            
            
            string choice = "";
            
            while (choice != "quit")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Press Enter to hide words or type quit to quit.");
                choice = Console.ReadLine();

                if (choice == "")
                {
                    Console.Clear();//THIS IS WHERE YOU HIDE THE WORDS
                    List<Word> myString = myScripture.SplitScripture();
                    foreach (Word word in myString)
                    {
                        Console.WriteLine(word.theWord);
                    }
                }
                else if (choice == "quit")
                {

                }
                else
                {
                    Console.WriteLine("Invalid Input. Please try again");
                }
            }
            

            //List<Word> myString = myScripture.SplitScripture();

            //Console.WriteLine(myScripture._chosenScripture);
            
            //foreach (Word word in myString)
            //{
            //    Console.WriteLine(word.theWord);

            //}
            
            
            //foreach (Word word in myString)
            //{
                //Console.WriteLine(word.theWord);
                //word.HideWord(myString);
                
            //}
            
        }
    }
}