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
            if (reference == "John 13:14")
            {
                _chosenScripture = "For God so loved the world";
            }
            if (reference == "Mike 22")
            {
                _chosenScripture = "Mike was happy";
            }
            if (reference == "Tony 22")
            {
                _chosenScripture = "Tony was happy";
            }
            return _chosenScripture;
        }

        public List<Word> SplitScripture()
        {
            wordStrings = _chosenScripture.Split(" ").ToList();
             foreach (string word in wordStrings)
            {
                Word myWord = new Word();
                myWord.theWord = word;
                words.Add(myWord);
            }
            return words;
        }

        public List<Word> GetWords()
        {
            return words;
        }
        
        
        
        
    }
}