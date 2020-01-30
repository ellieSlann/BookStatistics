using BookStatistics.Models;
using System.Collections.Generic;

namespace BookStatistics
{
    public class WordCounter : IWordCounter
    {
        private readonly BookModel _bookModel;

        public WordCounter(BookModel bookModel)
        {
            _bookModel = bookModel;
        }

        public int CountWordsOfRequestedLength(int length)
        {
            var count = 0;
            foreach (string word in _bookModel.WordsInBook)
            {
                if (word.Length == length) count++;
            }
            return count;
        }

        public Dictionary<int, int> CreateReport()
        {
            var report = new Dictionary<int, int>();
            var longestWord = FindLongestWord();
            for (var i = 1; i <= longestWord.maxWordLength; i++)
            {
                var numberOfWords = CountWordsOfRequestedLength(i);

                    report.Add(i, numberOfWords);
            }

            return report;
        }

        public (int maxWordLength, string longestWord) FindLongestWord()
        {
            var maxWordLength = 0;
            var longestWord = "";

            foreach (string word in _bookModel.WordsInBook)
            {
                if (word.Length > maxWordLength) 
                {
                    maxWordLength = word.Length;
                    longestWord = word;
                }
            }

            return (maxWordLength, longestWord);
        }
    }
}
