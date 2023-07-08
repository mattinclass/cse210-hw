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
            Console.WriteLine($"{activeReference},  {activeScripture}.");
            myScripture.SplitScripture();
            List<string> selectedWords = new List<string>();
            int count = 0;
            
            string choice = "";
            
            while (choice != "quit")
            {
                
                Console.WriteLine();
                Console.WriteLine("Press Enter to hide words or type quit to quit.");
                choice = Console.ReadLine();

                if (choice == "")
                {
                    //THIS IS WHERE YOU HIDE THE WORDS
                    Console.Clear();
                    
                    count = 0;
                    
                    Random randomGenerator = new Random();
                    int wordNumber = randomGenerator.Next(0, myScripture.words.Count());
                    int wordNumber2 = randomGenerator.Next(0, myScripture.words.Count());
                    int wordNumber3 = randomGenerator.Next(0, myScripture.words.Count());

                    
                    if (!selectedWords.Contains(myScripture.words[wordNumber].theWord))
                    {
                        
                        selectedWords.Add(myScripture.words[wordNumber].theWord);
                    }
                    
                    
                    myScripture.words[wordNumber] = myScripture.words[wordNumber].ConvertToUnderscore(myScripture.words[wordNumber]);
                    myScripture.words[wordNumber2] = myScripture.words[wordNumber2].ConvertToUnderscore(myScripture.words[wordNumber2]);
                    myScripture.words[wordNumber3] = myScripture.words[wordNumber3].ConvertToUnderscore(myScripture.words[wordNumber3]);
                        
                
                    Console.Write($"{activeReference}, ");
                    foreach (Word word in myScripture.words)
                    {
                        
                        Console.Write($"{word.theWord} ");
                        
                        if (word.GetStatus() == false)
                        {
                            count +=1;
                            
                        }
                    } 
                    
                    
                    //Console.WriteLine();
                    //if (selectedWords.Count() > myScripture.words.Count())
                    //{
                      //  choice = "quit";
                    //}
                    
                }
                else if (choice == "quit")
                {

                }
                else
                {
                    Console.WriteLine("Invalid Input. Please try again");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
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