using System.IO;
using BookStatistics.Models;
using NUnit.Framework;

namespace BookStatistics.Test
{
    public class Tests
    {
<<<<<<< HEAD
        [SetUp]
        public void Setup()
        {
=======
        public WordCounter _WordCounter;
        public string _word;
        public string _text;

        [SetUp]
        public void Setup()
        {
            _WordCounter = new WordCounter();
            _word = "This";
            _text = "This is a test";
>>>>>>> Start of building models
        }

        [Test]
        public void ReadBookShouldReadFromTestFile()
        {
            var fileLocation = "C:\\MyProjects\\BookStatistics\\test-book.txt";

<<<<<<< HEAD
            var text = BookReader.ReadBook(fileLocation);

            Assert.That(text == "This is a test");
        }

       
        //to do: test to confirm the correct text is read
=======
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
        }

        [Test]
        public void PopulateBookShouldAddWordsToNewBookModel()
        {
            var textArray = new string[] { "This", "is", "a", "test" };
            var populatedBookModel = _WordCounter.PopulateBook(textArray);

            Assert.IsInstanceOf<BookModel>(populatedBookModel);
            Assert.That(populatedBookModel.WordsInBook[0].ToString() == _word);
        }
>>>>>>> Start of building models

        // to do: test that the statistics are calculated correctly

        //To Do: test that program outputs to console??
    }
}