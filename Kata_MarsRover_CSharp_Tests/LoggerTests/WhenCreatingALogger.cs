using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kata_MarsRover_CSharp;

namespace Kata_MarsRover_CSharp_Tests.LoggerTests
{
    [TestClass]
    public class WhenCreatingALogger
    {

        [TestMethod]
        public void WithNoFilePathThenTheLoggerThrowsAnException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new FileLogger(null));
        }

    }
}
