using BookStatistics.Models;
using NUnit.Framework;

namespace BookStatistics.Test
{
    public class BookBuilderTests
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
        public void CreateWordListShouldCountTheNumberOfWordsInFile()
        {
            Assert.That(_bookBuilder.CreateWordList(_text).Count == 4);
        }

        [Test]
        public void PutWordInModelShouldReturnBookModel()
        {
            var wordInModel = _bookBuilder.PutWordInModel(_word);

            Assert.IsInstanceOf<WordModel>(wordInModel);
            Assert.That(wordInModel.Characters == 4);
        }


        [Test]
        public void PopulateBookShouldAddWordsToNewBookModel()
        {
            var populatedBookModel = _bookBuilder.PopulateBook(_text);

            Assert.IsInstanceOf<BookModel>(populatedBookModel);
            Assert.That(populatedBookModel.WordsInBook[0] == _word);
        }
    }
}
