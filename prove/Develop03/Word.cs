using System;
using System.Collections.Generic;

namespace Develop03
{
    public class Word
    {
        // A word represents the variables and methods that occur to a single word.
        private bool _wordIsActive =true;
        public string theWord;
        private char[] characters;
        private int characterCount = 0;
        

        


        public List<Word> HideWord(List<Word> myWordList)
        {
            
            
            
            foreach (Word word in myWordList)
            {
                characters = word.theWord.ToCharArray();
                characterCount = word.theWord.Count();
                Random numberGenerator = new Random();
                int hideNumber = numberGenerator.Next(0,characterCount - 1);

                myWordList[hideNumber].theWord = "____";
                word.DeactivateWord(false);
            }
            

            //myWord.theWord = characters.ToString();
            

            return myWordList;
        }
        public void DeactivateWord(bool isActive)
        {
            _wordIsActive = isActive;
        }
        public bool GetStatus()
        {
            return _wordIsActive;
        }

       public Word ConvertToUnderscore(Word word)
        {
            Word convertedWord = new Word();
            convertedWord.theWord = string.Empty;
            

            foreach (char letter in word.theWord)
            {
                
                convertedWord.theWord += "_";
            }
            word.DeactivateWord(false);
            return convertedWord;
        }
    }
}