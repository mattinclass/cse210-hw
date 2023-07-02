using System;

class Program
{
    static void Main(string[] args)
    {
        
        Goals thegoal = new Goals();
    
        bool _hasQuit = false;

        while (_hasQuit == false)
        {
            
            Console.WriteLine("Menu options:\n1. Create new goal\n2. Display goals\n3. Save goals\n4. Load goals\n5. Record Event\n6. View Total Points\n7. Remove Goal\n8. Quit");
            string selection = Console.ReadLine();
            if (selection == "1")
            {
                thegoal.CreateGoal();
            }
            else if (selection == "2")
            {
                thegoal.DisplayGoals();
            }
            else if (selection == "3")
            {
                thegoal.SaveGoals();
            }
            else if (selection == "4")
            {
                thegoal.LoadGoals();
            }
            else if (selection == "5")
            {
                thegoal.RecordEvent();
            }
            else if (selection == "6")
            {
                Console.WriteLine($"Total Score: {thegoal.GetTotalScore()}");
                Thread.Sleep(2000);
            }
            else if (selection == "7")
            {
                thegoal.RemoveGoal();
            }
            else
            {
                _hasQuit = true;
            }

        }

        
    }
}