using Kata_MarsRover_CSharp;
using Kata_MarsRover_CSharp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_MarsRover_CSharp_Tests.CommandTextProcessorTests
{
    [TestClass]
    public class WhenProcessingACommand
    {

        [TestMethod]
        public void WhenTheCommandIsNullAnExceptionIsThrown()
        {
            CommandTextProcessor commandTextProcessor = new CommandTextProcessor();

            Assert.ThrowsException<ArgumentNullException>(() => commandTextProcessor.CreateCommandFromText(null));
        }

        [TestMethod]
        [DataRow("l", Command.TurnLeft, DisplayName = "WhenLowercaseLIsSentToTheTextProcessorTheTurnLeftCommandIsReturned")]
        [DataRow("L", Command.TurnLeft, DisplayName = "WhenUppercaseLIsSentToTheTextProcessorTheTurnLeftCommandIsReturned")]
        [DataRow("r", Command.TurnRight, DisplayName = "WhenLowercaseRIsSentToTheTextProcessorTheTurnRightCommandIsReturned")]
        [DataRow("f", Command.MoveForward, DisplayName = "WhenLowercaseFIsSentToTheTextProcessorTheMoveForwardCommandIsReturned")]
        [DataRow("b", Command.MoveBackward, DisplayName = "WhenLowercaseBIsSentToTheTextProcessorTheMoveBackwardCommandIsReturned")]
        [DataRow("XYZ", Command.Unknown, DisplayName = "WhenABadInstructionIsSentToTheTextProcessorAnUnknownCommandTypeIsReturned")]
        [DataRow("", Command.Unknown, DisplayName = "WhenNoTextCommandIsSentToTheTextProcessorAnUnknownCommandTypeIsReturned")]
        public void WhenATextCommandIsSentToTheCommandProcessor(string strCommand, Command expectedCommand)
        {
            CommandTextProcessor commandTextProcessor = new CommandTextProcessor();

            Command returnCommand = commandTextProcessor.CreateCommandFromText(strCommand);

            Assert.AreEqual(expectedCommand, returnCommand);
        }
    }
}
