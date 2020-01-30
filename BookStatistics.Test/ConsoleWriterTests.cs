using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using NUnit.Framework;

namespace BookStatistics.Test
{
    public class ConsoleWriterTests
    {
        [Test]
        public void WriteToConsoleShouldOutputDictionaryToConsole()
        {
            var consoleWriter = Mock.Of<ConsoleWriter>();

            //Assert.That(consoleWriter.WriteToConsole)
        }
    }
}
