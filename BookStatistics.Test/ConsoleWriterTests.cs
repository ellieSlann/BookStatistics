<<<<<<< Updated upstream
﻿using NUnit.Framework;
=======
﻿using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using NUnit.Framework;
>>>>>>> Stashed changes

namespace BookStatistics.Test
{
    public class ConsoleWriterTests
    {
        [Test]
        public void WriteToConsoleShouldOutputDictionaryToConsole()
        {
<<<<<<< Updated upstream
            //var consoleWriter = Mock

            //Assert.That(consoleWriter.WriteToConsole)

            //Todo work out how to test this
=======
            var consoleWriter = Mock.Of<ConsoleWriter>();

            //Assert.That(consoleWriter.WriteToConsole)
>>>>>>> Stashed changes
        }
    }
}
