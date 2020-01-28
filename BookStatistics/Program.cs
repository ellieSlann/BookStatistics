using System;

namespace BookStatistics
{
    public class Program
    {
        private static readonly string path = @"C:\MyProjects\BookStatistics\dracula-book.txt";

        static void Main()
        {
            var _bookBuilder = new BookBuilder();
            var wordCounter = new WordCounter();

            var text = BookReader.ReadBook(path);
            var myBook = _bookBuilder.PopulateBook(text);

            var maxWordLength = wordCounter.FindMaxWordLength(myBook);

            Console.WriteLine(maxWordLength);

            //ToDo: run statistics on file

            //ToDo: output statistics to console.

        }
    }
}
