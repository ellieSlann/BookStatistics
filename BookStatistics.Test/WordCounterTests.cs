using BookStatistics.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace BookStatistics.Test
{
    public class WordCounterTests
    {
        public WordCounter wordCounter;
        public BookModel bookModel;


        [SetUp]
        public void Setup()
        {
            bookModel = new BookModel
            {
                WholeBook = "This is a test",
                WordsInBook = new List<string>() { "This", "is", "a", "test" }
            };

            wordCounter = new WordCounter(bookModel);
        }

        [Test]
        public void CountWordsOfLengthShouldReturnNumberOfWordsWithSameLength()
        {
            var countOfWords = wordCounter.CountWordsOfRequestedLength(2);

            Assert.That(countOfWords == 1);
        }

        [Test]
        public void FindMaxWordLengthShouldReturnTheLengthOfLongestWordInBook()
        {
            var longestWord = wordCounter.FindLongestWord();

            Assert.That(longestWord.Item1 == 4);
        }

        [Test]
        public void CreateReportShouldReturnPopulatedReport()
        {
            var report = wordCounter.CreateReport();
           
            Assert.IsInstanceOf<Dictionary<int, int>>(report);
            Assert.That(report[1] == 1);
            Assert.That(report[2] == 1);
            Assert.That(report[3] == 0);
            Assert.That(report[4] == 2);
        }
    }
}