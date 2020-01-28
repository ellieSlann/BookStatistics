using System;
using System.Collections.Generic;
using System.Text;

namespace BookStatistics.Models
{
    public class ReportModel
    {
        public int NumberOfWords { get; set; }
        public List<int> WordLength { get; set; }

        //ToDo: work out how to implement the report in this way
    }
}
