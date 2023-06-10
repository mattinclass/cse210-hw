
namespace Develop04
{
    public class Reflection : Exercises
    {
        public string _description = "Welcome to the reflection activity! \n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        public string _type = "reflection";
        public void BeginReflection(int duration)
        {
            Console.Clear();
            
            Console.Write("Get ready");
            DisplayAnimation();
            Console.WriteLine();
            Thread.Sleep(2000);

            string myQuestion = ChooseFirstQuestion();
            
            Console.Write($"---- {myQuestion} ----");
            
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("When you have thought of an experience, please press Enter.");
            Console.ReadLine();
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(duration);
            DateTime currentTime = DateTime.Now;

            while (currentTime < futureTime)
            {
                string myFollowUp = ChooseFollowUp();
                Console.Write(myFollowUp);
                ShowSpinner();
                Console.WriteLine();
                currentTime = DateTime.Now;
            }

            
        }

        public string ChooseFirstQuestion()
        {
            List<string> questionList = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless.", "Think of a time when you overcame discouragement."};
            Random numberSelector = new Random();
            int promptnumber = numberSelector.Next(0, 4);

            string question = questionList[promptnumber];
            
            return question;
        }

        public string ChooseFollowUp()
        {
            List<string> followups = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself?", "How can you keep this experience in mind for the future?"};
            Random numberSelector = new Random();
            int promptnumber = numberSelector.Next(0, 7);

            string question = followups[promptnumber];
            
            return question;
        }
    }
}