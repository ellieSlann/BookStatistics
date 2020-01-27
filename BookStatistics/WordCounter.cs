using BookStatistics.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStatistics
{
    public class WordCounter
    {
        public string[] CreateWordArray(string text) => text.Split(" ");

        public WordModel PutWordInModel(string inputword)
        {
            return new WordModel
            {
                Characters = inputword.Length
            };
        }

        public BookModel PopulateBook(string[] Book)
        {
            var newBook = new BookModel();
            foreach (string w in Book)
            {
                newBook.Words.Add(PutWordInModel(w));
            }
            return newBook;
        }

        public int FindWordLength(string word) => word.ToCharArray().Length;

        public void CreateReport(string[] wordArray)
        {

        }

        //to do: for each word in array find length.

        //to do: group words of same length together.
    }
}
