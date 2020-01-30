using System;
using System.Collections.Generic;
<<<<<<< Updated upstream
using System.Text;
=======
>>>>>>> Stashed changes

namespace BookStatistics
{
    public class ConsoleWriter
    {
        public void WriteToConsole(Dictionary<int, int> report)
        {
            foreach ( KeyValuePair<int, int> i in report)
            {
                Console.WriteLine($"Book contains {i.Value} words of length {i.Key}" );
            }
        }
    }
}
