using System;

namespace WordCounter.Models
{
    public class WordCounterClass
    {
        // private string _word;
        // private string _sentence;
        // private int _match;
        // public WordCounterClass(string word, string sentence, int match)
        // {
        //     _word = word;
        //     _sentence = sentence;
        //     _match = match;
        // }
        // public string GetWord()
        // {
        //     return _word;
        // }
        // public string GetSentence()
        // {
        //     return _sentence;
        // }
        // public int GetMatch()
        // {
        //     return _match;
        // }
        public bool IsUserInputAString(string Word)
         {
             if (Word == "q")
             {
                 return true;
             }
             return false;
         }

        public bool DoesWordAndSentenceHaveSingleMatch(string word, string sentence)
        {
            if (word == sentence)
            {
                return true;
            }
            return false;
        }

        public bool DoesWordAndSentenceHaveDoubleMatch(string word, string sentence)
        {
            string[] sentenceSplit = sentence.Split(' ');
            foreach (var index in sentenceSplit)
            {
                if (word == index)
                {
                    return true;
                }   
            }
            return false;    
        }

        public bool DoesWordAndSentenceHaveMultipleMatches(string word, string sentence)
        {
            string[] sentenceSplit = sentence.Split(' ');
            foreach (var index in sentenceSplit)
            {
                if (word == index)
                {
                    return true;
                }
            }
            return false;
        }

        public int HowManyMatchesDoYouHave(string word, string sentence)
        {
            int matchScore = 0;
            string[] sentenceSplit = sentence.Split(' ');
            foreach(var index in sentenceSplit)
            {
                if (word == index)
                {
                    matchScore++;
                }
            }
            return matchScore;   
        }  
    }
}