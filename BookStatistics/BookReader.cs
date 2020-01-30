using System.IO;

namespace BookStatistics
{
    public static class BookReader
    {
        public static string ReadBook(string path)
        {
            var text = File.ReadAllText(path);

            return text;
        }
    }
}
