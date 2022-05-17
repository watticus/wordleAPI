using System;
using System.IO;
using NUnit.Framework;
using WordleAPI.WordHelper;

namespace WordleTest
{
    [TestFixture]
    
    public class WordHelperTests
    {
        public WordHelper wordHelper = new WordHelper();
        string[] wordList = File.ReadAllLines(@"C:\Code\GitLab\wordle-react\src\wordList.txt");

        [SetUp]
        public void Setup()
        {
            wordHelper = new WordHelper();
        }

        [Test]
        public void Test_TestWordReturned()
        {
            var isTestTrue = wordHelper.GetWordleReturn(true);
            Assert.IsTrue(isTestTrue.CompareTo("wordl") == 0, "The returned word should equal: 'wordl' , But was: " + isTestTrue);
            var isTestFalse = wordHelper.GetWordleReturn(false);
            Assert.IsFalse(isTestFalse.CompareTo("wordl") == 0, "The returned word should not equal: 'wordl' , But was: " + isTestFalse);
        }

        [Test]
        public void Test_GetRandomWordReturnsString()
        {
            Assert.IsInstanceOf(typeof(String), wordHelper.GetRandomWord());
        }

        [Test]
        public void Test_GetRandeomWordReturnsRandom()
        {
            var word1 = wordHelper.GetRandomWord();
            var word2 = wordHelper.GetRandomWord();
            if (word1 == word2)
            {
                word2 = wordHelper.GetRandomWord();
            }
            Assert.AreNotEqual(word1, word2);
        }

        [Test]
        public void Test_ValidateGetWordReturn()
        {
            for (int index = 0; index < wordList.Length; index++)
            {
                Assert.IsTrue(wordHelper.GetWord(index).CompareTo(wordList[index]) == 0, "The returned word should equal: " + wordList[index] + " , But was: " + wordHelper.GetWord(index));
            }
        }
    }
}