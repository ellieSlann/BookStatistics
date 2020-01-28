using BookStatistics.Models;
using System.Collections.Generic;

namespace BookStatistics
{
    public class BookBuilder
    {
        public List<string> CreateWordList(string text) => new List<string>(text.Split(" "));

        //Todo: need to split on punctuation as well as white space ie clean up punctuation with regex

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
