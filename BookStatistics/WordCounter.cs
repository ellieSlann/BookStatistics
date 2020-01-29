using BookStatistics.Models;
using System;
using System.Collections.Generic;

namespace BookStatistics
{
    public class WordCounter
    {
        public int CountWordsOfRequestedLength(int length, BookModel bookModel)
        {
            var count = 0;
            foreach (string word in bookModel.WordsInBook)
            {
                if (word.Length == length) count++;
            }
            return count;
        }

        public Dictionary<int, int> CreateReport(BookModel bookModel)
        {
            var report = new Dictionary<int, int>();
            var maxWordLength = FindMaxWordLength(bookModel);
            for (var i = 1; i <= maxWordLength.Item1; i++)
            {
                var numberOfWords = CountWordsOfRequestedLength(i, bookModel);

                    report.Add(i, numberOfWords);
            }

            return report;
        }

        public (int, string) FindMaxWordLength(BookModel book)
        {
            var MaxWordLength = 0;
            var longestWord = "";

            foreach (string word in book.WordsInBook)
            {
                if (word.Length > MaxWordLength) 
                {
                    MaxWordLength = word.Length;
                    longestWord = word;
                }
            }

            return (MaxWordLength, longestWord);
        }
    }
}
