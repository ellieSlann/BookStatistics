using System.IO;

namespace BookStatistics
{
    public static class TextReader
    {
        public static string ReadText(string path)
        {
            var text = File.ReadAllText(path);

            return text;
        }
    }
}
