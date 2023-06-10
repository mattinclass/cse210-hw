
namespace Develop04
{
    public class Breathing : Exercises
    {
        public string _description = "Welcome to the breathing activity!\n\nThis activity will help you relax by walking you through a breathing exercise. Focus on your breathing and follow the prompts.";

        public string _type = "breathing";
        public void BeginBreathing(int duration)
        {
            Console.Clear();
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(duration);

            Console.Write("Get ready");
            DisplayAnimation();
            Console.WriteLine();
            Thread.Sleep(2000);

            DateTime currentTime = DateTime.Now;
            while (currentTime < futureTime)
            {
            
            Console.Write("Breathe in...");
            DisplayCountdown();
            Console.WriteLine();
            Console.Write("And breathe out..."); 
            DisplayCountdown();
            Console.WriteLine();
            currentTime = DateTime.Now;
            }
 
            
        }

        public void DisplayCountdown()
        {
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }

    }

}