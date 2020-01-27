using System.IO;
using NUnit.Framework;

namespace BookStatistics.Test
{
    public class Tests
    {
        public WordCounter _WordCounter;

        [SetUp]
        public void Setup()
        {
            _WordCounter = new WordCounter();
        }

        [Test]
        public void ReadBookShouldReadFromTestFile()
        {
            var fileLocation = "C:\\MyProjects\\BookStatistics\\test-book.txt";

            Assert.That(BookReader.ReadBook(fileLocation) == "This is a test");
        }

        [Test]
        public void CheckWordsShouldCountTheNumberOfWordsInFile()
        {
            var text = "This is a test";

            Assert.That(_WordCounter.CreateWordArray(text).Length == 4);
        }

        [Test]
        public void FindWordLengthShouldReturnLengthOfWord()
        {
            var word = "This";

            Assert.That(_WordCounter.FindWordLength(word) == 4) ;
        }

        [Test]
        public void PutWordInModelShouldReturnBookModel()
        {

        }

        [Test]
        public void PopulateBookShouldAddWordsToNewBookModel()
        {

        }

        // to do: test that the statistics are calculated correctly

        //To Do: test that program outputs to console??
    }
}