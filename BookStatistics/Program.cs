namespace BookStatistics
{
    public class Program
    {
        private static readonly string path = @"C:\MyProjects\BookStatistics\dracula-book.txt";

        static void Main()
        {
            var bookBuilder = new BookBuilder();            
            var consoleWriter = new ConsoleWriter();

            var text = TextReader.ReadText(path);
            var myBook = bookBuilder.PopulateBook(text);

            var wordCounter = new WordCounter(myBook);

            consoleWriter.WriteToConsole(wordCounter.CreateReport());
        }
    }
}
