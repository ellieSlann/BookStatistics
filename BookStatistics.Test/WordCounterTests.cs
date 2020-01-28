using BookStatistics.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace BookStatistics.Test
{
    public class WordCounterTests
    {
        public WordCounter _WordCounter;
        public BookModel book;
        public string _word;


        [SetUp]
        public void Setup()
        {
            _WordCounter = new WordCounter();
            _word = "This";

            book = new BookModel
            {
                WholeBook = "This is a test",
                WordsInBook = new List<string>() { "This", "is", "a", "test" }
            };
        }

        [Test]
        public void CountWordsOfLengthShouldReturnNumberOfWordsWithSameLength()
        {
            var countOfWords = _WordCounter.CountWordsOfRequestedLength(2, book);

            Assert.That(countOfWords == 1);
        }

        [Test]
        public void FindMaxWordLengthShouldReturnTheLengthOfLongestWordInBook()
        {
            var longestWord = _WordCounter.FindMaxWordLength(book);

            Assert.That(longestWord.Item1 == 4);
        }

        [Test]
        public void CreateReportShouldReturnPopulatedReport()
        {
            var report = _WordCounter.CreateReport(book);
            //Assert.That(report.)
        }

        // todo: test that the statistics are calculated correctly

        //ToDo: test that program outputs to console??
    }
}