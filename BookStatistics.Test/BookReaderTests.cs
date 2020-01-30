using NUnit.Framework;

namespace BookStatistics.Test
{
    public class BookReaderTests
    {
        public string text;

        [SetUp]
        public void Setup()
        {
            text = "This is a test";
        }

        [Test]
        public void ReadBookShouldReadFromTestFile()
        {
            var fileLocation = "C:\\MyProjects\\BookStatistics\\test-book.txt";
            Assert.That(TextReader.ReadText(fileLocation) == text);
        }
    }
}
