using BookStatistics.Models;

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

        public void CreateReport(BookModel bookModel)
        {
            var maxWordLength = FindMaxWordLength(bookModel);
            var report = new ReportModel();
            for (var i = 0; i <= maxWordLength.Item1; i++)
            {
                report.WordLength.Add(i);
                var wordCount = CountWordsOfRequestedLength(i, bookModel);
                
            }
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


        //todo: group words of same length together.
    }
}
