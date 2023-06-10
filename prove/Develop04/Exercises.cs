
namespace Develop04
{
    public class Exercises
    {
        public string description;
        public int duration;

        public float dividedDuration;

        public string DisplayMessage(string description)
        {
            Console.Clear();
            return description;
        }

        public int ChooseDuration()
        {
            
            Console.WriteLine("How long do you want this exercise to be? Select between 10 and 120 seconds: ");
            duration = Int32.Parse(Console.ReadLine());
            return duration;
        }
        public void DisplayAnimation()
        {

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(5);

            Thread.Sleep(500);

            DateTime currentTime = DateTime.Now;
            if (currentTime < futureTime)
            {
                
            
                Console.Write(".");
                Thread.Sleep(500);
            
                Console.Write(".");
                Thread.Sleep(500);

                Console.Write(".");
                Thread.Sleep(500);

                Console.Write("\b \b\b \b\b");

                Console.Write(".");
                Thread.Sleep(500);
            
                Console.Write(".");
                Thread.Sleep(500);

                Console.Write(".");
                Thread.Sleep(500);
                        
            }
            
        }

        public void ShowSpinner()
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(7);

            Thread.Sleep(500);

            DateTime currentTime = DateTime.Now;
            while (currentTime < futureTime)
            {
                
            
                Console.Write("|");
                Thread.Sleep(250);

                Console.Write("\b \b");
            
                Console.Write("/");
                Thread.Sleep(250);

                Console.Write("\b \b");

                Console.Write("-");
                Thread.Sleep(250);

                Console.Write("\b \b");

                Console.Write(@"\");
                Thread.Sleep(250);

                Console.Write("\b \b");
                currentTime = DateTime.Now;
            
            }
        }

        public void Congratulate(int duration, string type)
        {
            Console.WriteLine($"Well Done! You have completed {duration} seconds of the {type} activity!");
            Thread.Sleep(3000);
        }
    }
}