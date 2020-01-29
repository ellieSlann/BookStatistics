using System;

namespace BookStatistics
{
    public class Program
    {
        private static readonly string path = @"C:\MyProjects\BookStatistics\dracula-book.txt";

        static void Main()
        {
            var bookBuilder = new BookBuilder();
            var wordCounter = new WordCounter();

            var text = BookReader.ReadBook(path);
            var myBook = bookBuilder.PopulateBook(text);

            var report = wordCounter.CreateReport(myBook);

            Console.WriteLine(report);

            //ToDo: output statistics to console.

        }
    }
}
