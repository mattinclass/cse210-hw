using System;
using System.Collections.Generic;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hasQuit = false;

            while (hasQuit == false)
            {
                Console.Clear();
                Console.WriteLine("Please select an exercise: \n1. Breathing Exercise \n2. Reflection Exercise \n3. Listing Exercise \n4. Quit");
                string selection = Console.ReadLine();

                if (selection == "1")
                {
                    Breathing myBreathing = new Breathing();
                    string displayMessage = myBreathing.DisplayMessage(myBreathing._description);
                    Console.WriteLine(displayMessage);
                    int duration = myBreathing.ChooseDuration();
                    myBreathing.BeginBreathing(duration);
                    myBreathing.Congratulate(duration, myBreathing._type);
                }
                else if (selection == "2")
                {
                    Reflection myReflection = new Reflection();
                    string displayMessage = myReflection.DisplayMessage(myReflection._description);
                    Console.WriteLine(displayMessage);
                    int duration = myReflection.ChooseDuration();
                    myReflection.BeginReflection(duration);
                    myReflection.Congratulate(duration, myReflection._type);
                    
                        
                    
                }
                else if (selection == "3")
                {
                    Listing myListing = new Listing();
                    string displayMessage = myListing.DisplayMessage(myListing._description);
                    Console.WriteLine(displayMessage);
                    int duration = myListing.ChooseDuration();
                    myListing.BeginListing(duration);
                    myListing.Congratulate(duration, myListing._type);
                }
                else if (selection == "4")
                {
                    hasQuit = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                    Thread.Sleep(1500);
                }
            }

            
        
            //Breathing myBreathing = new Breathing();
            //string displayMessage = myBreathing.DisplayMessage(myBreathing._description);
            //int goon = myBreathing.ChooseDuration();
            //Console.WriteLine(displayMessage);
            //Console.WriteLine(goon);
        }
        
    }
}