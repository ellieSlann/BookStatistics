using System;
using System.Collections.Generic;

namespace BookStatistics
{
    public class ConsoleWriter
    {
        public void WriteToConsole(Dictionary<int, int> report)
        {
            Console.WriteLine("Report:");
            Console.WriteLine("Chosen book contains");

            foreach ( KeyValuePair<int, int> i in report)
            {
                Console.WriteLine($"{i.Value} words of {i.Key} letters");
            }

            
        }
    }
}
