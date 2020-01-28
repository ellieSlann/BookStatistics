using System;
using System.Collections.Generic;
using System.Text;

namespace BookStatistics.Models
{
    public class BookModel
    {
        public List<WordModel> WordsInBook { get; set; }
        public string WholeBook { get; set; }
    }
}
