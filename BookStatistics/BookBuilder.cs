using BookStatistics.Models;
using System.Collections.Generic;

namespace BookStatistics
{
    public class BookBuilder
    {
        public List<string> CreateWordList(string text) => new List<string>(text.Split(" "));

        public WordModel PutWordInModel(string inputword)
        {
            return new WordModel
            {
                Characters = inputword.Length,
                WholeWord = inputword
            };
        }

        public BookModel PopulateBook(string Book)
        {
            var WordList = CreateWordList(Book);

            var newBook = new BookModel
            {
                WordsInBook = WordList,
                WholeBook = Book
            };
            return newBook;
        }
    }
}
