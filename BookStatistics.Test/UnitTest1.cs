using System.IO;
using NUnit.Framework;

namespace BookStatistics.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReadBookShouldReadFromTestFile()
        {
            var fileLocation = "C:\\MyProjects\\BookStatistics\\test-book.txt";

            var text = BookReader.ReadBook(fileLocation);

            Assert.That(text == "This is a test");
        }

       
        //to do: test to confirm the correct text is read

        // to do: test that the statistics are calculated correctly

        //To Do: test that program outputs to console??
    }
}