using NUnit.Framework;

namespace BookStatistics.Test
{
    public class BookReaderTests
    {
        public string _word;
        public string _text;

        [SetUp]
        public void Setup()
        {
            _text = "This is a test";
        }

        [Test]
        public void ReadBookShouldReadFromTestFile()
        {
            var fileLocation = "C:\\MyProjects\\BookStatistics\\test-book.txt";
            Assert.That(BookReader.ReadBook(fileLocation) == _text);
        }
    }
}
