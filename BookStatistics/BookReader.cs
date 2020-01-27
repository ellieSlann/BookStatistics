using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BookStatistics
{
    public static class BookReader
    {
        public static string ReadBook(string path)
        {
            var text = File.ReadAllText(path);

            return text;
        }

        public static int CheckWords(string text)
        {
            string[] wordArray;

            wordArray = text.Split(" ");

            return wordArray.Length;
        }
    }
}
