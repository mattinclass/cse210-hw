using System.Collections.Generic;
using System;

namespace Develop02
{
    public class Prompt
    {
        public string RandomPrompt = "";
        public int promptnumber = 0;
        

        public string GiveRandomPrompt()
        {
            Random randomGenerator = new Random();
            int promptnumber = randomGenerator.Next(0, 4);

            if (promptnumber == 0)
            {
                RandomPrompt = "What was the funniest part of the day?";
            }
            if (promptnumber == 1)
            {
               RandomPrompt = "What was the most boring part of the day?"; 
            }
            if (promptnumber == 2)
            {
                RandomPrompt = "What would you change about today if you could do it over?";
            }
            if (promptnumber == 3)
            {
                RandomPrompt = "What is the most exciting thing that you did today?";
            }
            if (promptnumber == 4)
            {
                RandomPrompt = "What made you feel grateful today?";
            }
            return RandomPrompt;
        }
    }
}