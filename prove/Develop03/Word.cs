using System;
using System.Collections.Generic;

namespace Develop03
{
    public class Word
    {
        // A word represents the variables and methods that occur to a single word.
        private bool _wordIsActive;
        public string theWord;
        private char[] characters;
        private int characterCount = 0;
        
        private string blankSpace = "_";

        


        public List<Word> HideWord(List<Word> myWordList)
        {
            
            
            
            foreach (Word word in myWordList)
            {
                characters = word.theWord.ToCharArray();
                characterCount = word.theWord.Count();
                Random numberGenerator = new Random();
                int hideNumber = numberGenerator.Next(0,characterCount - 1);

                myWordList[hideNumber].theWord = "____";
            }
            

            //myWord.theWord = characters.ToString();
            

            return myWordList;
        }
        
    }
}