using BookStatistics.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BookStatistics
{
    public class BookBuilder
    {
        public List<string> CreateWordList(string text) => new List<string>(Regex.Split(text, @"[^A-Za-z]"));

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
