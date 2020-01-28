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
    }
}
