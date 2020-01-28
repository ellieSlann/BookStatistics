using System.IO;
using BookStatistics.Models;
using NUnit.Framework;

namespace BookStatistics.Test
{
    public class Tests
    {
        public WordCounter _WordCounter;

        public string _word;
        public string _text;

        [SetUp]
        public void Setup()
        {
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
        public void CheckWordsShouldCountTheNumberOfWordsInFile()
        {
            Assert.That(_WordCounter.CreateWordArray(_text).Length == 4);
        }

        [Test]
        public void FindWordLengthShouldReturnLengthOfWord()
        {
            Assert.That(_WordCounter.FindWordLength(_word) == 4) ;
        }

        [Test]
        public void PutWordInModelShouldReturnBookModel()
        {
            var wordInModel = _WordCounter.PutWordInModel(_word);

            Assert.IsInstanceOf<WordModel>(wordInModel);
            Assert.That(wordInModel.Characters == 4);
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
            var textArray = new string[] { "This", "is", "a", "test" };
            var populatedBookModel = _WordCounter.PopulateBook(textArray);

            Assert.IsInstanceOf<BookModel>(populatedBookModel);
            Assert.That(populatedBookModel.WordsInBook[0].ToString() == _word);
        }

        // to do: test that the statistics are calculated correctly

        //To Do: test that program outputs to console??
    }
}