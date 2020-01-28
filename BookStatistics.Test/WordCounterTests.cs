using System.IO;
using BookStatistics.Models;
using NUnit.Framework;

namespace BookStatistics.Test
{
    public class WordCounterTests
    {
        public WordCounter _WordCounter;
        public BookBuilder _bookBuilder;

        public string _word;
        public string _text;

        [SetUp]
        public void Setup()
        {
            _bookBuilder = new BookBuilder();
            _WordCounter = new WordCounter();
            _word = "This";
            _text = "This is a test";
        }

        [Test]
        public void ReadBookShouldReadFromTestFile()
        {
            var fileLocation = "C:\\MyProjects\\BookStatistics\\test-book.txt";
            Assert.That(BookReader.ReadBook(fileLocation) == _text);
        }

        [Test]
        public void FindWordLengthShouldReturnLengthOfWord()
        {
            Assert.That(_WordCounter.FindWordLength(_word) == 4) ;
        }

  

        // to do: test that the statistics are calculated correctly

        //To Do: test that program outputs to console??
    }
}