namespace WordCounter
{
    public class WordCounterClass
    {
        public bool IsUserInputAString(string userWord)
        {
            if (userWord == "q")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DoesWordAndSentenceHaveSingleMatch(string word, string sentence)
        {
            if (word == sentence)
            {
                return true;
            }
            else
            {
                return false;
            }
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
                else
                {
                    return false;
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
                else
                {
                    return false;
                }
            }
            return false;
        }  
    }
}