
namespace Develop04
{
    public class Listing : Exercises
    {
        public string _description = "Welcome to the listing activity! \n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        public string _type = "listing";

        public void BeginListing(int duration)
        {
            Console.Clear();
            
            Console.Write("Get ready");
            DisplayAnimation();
            Console.WriteLine();
            Thread.Sleep(2000);

            string myQuestion = ChooseListingQuestion();
            
            Console.Write($"---- {myQuestion} ----");
            Thread.Sleep(2000);
            
            Console.WriteLine();
            Console.WriteLine();

            
            
            
            Console.Write("You may begin in ");

            int countdownStart = 9;
            while (countdownStart > 0)
            {
            Console.Write(countdownStart);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            countdownStart = countdownStart - 1;
            }

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(duration);
            DateTime currentTime = DateTime.Now;
            
            List<string> myList = new List<string>();

            while (currentTime < futureTime)
            {
                Console.WriteLine("Add to the list: ");
                currentTime = DateTime.Now;
                string entry = Console.ReadLine();
                
                myList.Add(entry);
                currentTime = DateTime.Now;
            }
            int length = myList.Count();
            Console.WriteLine($"Your list is {length} entries long!");
            Thread.Sleep(3000);
        }

        public string ChooseListingQuestion()
        {
            List<string> questionList = new List<string> {"Who are the people that you appreciate?", "What are personal strengths of yours?", "Who are the people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
            Random numberSelector = new Random();
            int promptnumber = numberSelector.Next(0, 4);

            string question = questionList[promptnumber];
            
            return question;
        }
    }
}