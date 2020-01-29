using BookStatistics.Models;
using NUnit.Framework;

namespace BookStatistics.Test
{
    public class BookBuilderTests
    {
        public BookBuilder bookBuilder;

        public string word;
        public string text;

        [SetUp]
        public void Setup()
        {
            bookBuilder = new BookBuilder();
            word = "This";
            text = "This is a test";
        }

        [Test]
        public void CreateWordListShouldCountTheNumberOfWordsInFile()
        {
            var wordlist = bookBuilder.CreateWordList(text);
            Assert.That(wordlist.Count == 4);
        }

        [Test]
        public void PopulateBookShouldAddWordsToNewBookModel()
        {
            var populatedBookModel = bookBuilder.PopulateBook(text);

            Assert.IsInstanceOf<BookModel>(populatedBookModel);
            Assert.That(populatedBookModel.WordsInBook[0] == word);
        }
    }
}
