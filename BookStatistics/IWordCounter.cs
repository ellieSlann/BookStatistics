using System.Collections.Generic;

namespace BookStatistics
{
    interface IWordCounter
    {
        int CountWordsOfRequestedLength(int length);

        Dictionary<int, int> CreateReport();

        (int wordLength, string longWord) FindMaxWordLength();
    }
}
