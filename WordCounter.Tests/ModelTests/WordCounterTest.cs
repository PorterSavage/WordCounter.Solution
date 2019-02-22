using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void IsWord_ChecksIfUserEntersAString()
        {
            WordCounterClass testWordCounterClass = new WordCounterClass("","",0);
            Assert.AreEqual(true, testWordCounterClass.IsUserInputAString("q"));
        }

        [TestMethod]
        public void IsSingleMatch_CheckIfWordMatchesWithSentence()
        {
            WordCounterClass testWordCounterClass = new WordCounterClass("","",0);
            Assert.AreEqual(true, testWordCounterClass.DoesWordAndSentenceHaveSingleMatch("q", "q"));
        }

        [TestMethod]
        public void IsDoubleMatch_CheckIfWordHasTwoMatchesWithSentence()
        {
            WordCounterClass testWordCounterClass = new WordCounterClass("","",0);
            Assert.AreEqual(true, testWordCounterClass.DoesWordAndSentenceHaveDoubleMatch("q", "q q"));

        }

        [TestMethod]
        public void MatchCount_KeepsScoreOfHowManyMatchesBetweenWordAndSentence()
        {
            string word = "to";
            string sentence = "I want to complete this my way";
            int result = new WordCounterClass("","",0).HowManyMatchesDoYouHave(word, sentence);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void IsMultiMatch_CheckIfWordHasMultipleMatchesWithSentence()
        {
            WordCounterClass testWordCounterClass = new WordCounterClass("","",0);
            Assert.AreEqual(true, testWordCounterClass.DoesWordAndSentenceHaveMultipleMatches("q", "you are q and they are q and we are all q"));
        }
    }
}