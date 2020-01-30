//using Microsoft.VisualStudio.TestPlatform.Utilities;
//using NUnit.Framework;
//using System;
//using System.Collections.Generic;

//namespace BookStatistics.Test
//{
//    public class ConsoleWriterTests
//    {
//        [Test]
//        public void WriteToConsoleShouldOutputDictionaryToConsole()
//        {
//            var currentConsoleOut = Console.Out;
//            var report = new Dictionary<int, int>();
//            report.Add(1, 1);
//            report.Add(2, 1);
//            report.Add(3, 0);           

//            var consoleWriter = new ConsoleWriter();

//            using (var consoleOutput = new ConsoleOutput())
//            {
//                consoleWriter.WriteToConsole(report);
//            }
            
//            //var consoleWriter = Mock.Of<ConsoleWriter>();

//            //Assert.That(consoleWriter.WriteToConsole)
//        }
//    }
//}
