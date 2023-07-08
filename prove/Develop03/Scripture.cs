using System.Collections.Generic;
using System;

namespace Develop03
{
    public class Scripture
    {
        // A scripture is a list of words.
        public List<Word> words;
        List<string> wordStrings;
        public Scripture()
        {
            words = new List<Word>();
            
        }

        private string _scripture;
        public string _chosenScripture;

        public void StoreScripture(string scripture)
        {
            _scripture = scripture;
        }

        public string GetScripture(string reference)
        {
            if (reference == "John 13:34")
            {
                _chosenScripture = "A new commandment I give to you, that you love one another: just as I have love you, you also are to love one another.";
            }
            if (reference == "Matthew 11:28-30")
            {
                _chosenScripture = "Come to me, all who labor and are heavy laden, and I will give you rest. \nTake my yoke upon you, and learn from me; for I am gentle and lowly in hear, and you will find rest for your souls. \nFor my yoke is easy, and my burden is light.";
            }
            if (reference == "John 14:15")
            {
                _chosenScripture = "If ye love me, keep my commandments.";
            }
            return _chosenScripture;
        }

        public void SplitScripture()
        {
            wordStrings = _chosenScripture.Split(" ").ToList();
             foreach (string word in wordStrings)
            {
                Word myWord = new Word();
                myWord.theWord = word;
                words.Add(myWord);
            }
            
        }

        public List<Word> GetWords()
        {
            return words;
        }
        
         
        
        
        
    }
}