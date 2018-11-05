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
        public void WhenLowercaseLIsSentToTheTextProcessorTheTurnLeftCommandIsReturned()
        {
            CommandTextProcessor commandTextProcessor = new CommandTextProcessor();

            Command returnCommand = commandTextProcessor.CreateCommandFromText("l");

            Assert.AreEqual(Command.TurnLeft, returnCommand);
        }

        [TestMethod]
        public void WhenUppercaseLIsSentToTheTextProcessorTheTurnLeftCommandIsReturned()
        {
            CommandTextProcessor commandTextProcessor = new CommandTextProcessor();

            Command returnCommand = commandTextProcessor.CreateCommandFromText("L");

            Assert.AreEqual(Command.TurnLeft, returnCommand);
        }

        [TestMethod]
        public void WhenLowercaseRIsSentToTheTextProcessorTheTurnRightCommandIsReturned()
        {
            CommandTextProcessor commandTextProcessor = new CommandTextProcessor();

            Command returnCommand = commandTextProcessor.CreateCommandFromText("r");

            Assert.AreEqual(Command.TurnRight, returnCommand);
        }

        [TestMethod]
        public void WhenLowercaseFIsSentToTheTextProcessorTheMoveForwardCommandIsReturned()
        {
            CommandTextProcessor commandTextProcessor = new CommandTextProcessor();

            Command returnCommand = commandTextProcessor.CreateCommandFromText("f");

            Assert.AreEqual(Command.MoveForward, returnCommand);
        }

        [TestMethod]
        public void WhenLowercaseBIsSentToTheTextProcessorTheMoveBackwardCommandIsReturned()
        {
            CommandTextProcessor commandTextProcessor = new CommandTextProcessor();

            Command returnCommand = commandTextProcessor.CreateCommandFromText("b");

            Assert.AreEqual(Command.MoveBackward, returnCommand);
        }

        [TestMethod]
        public void WhenABadInstructionIsSentToTheTextProcessorAnUnknownCommandTypeIsReturned()
        {
            CommandTextProcessor commandTextProcessor = new CommandTextProcessor();

            Command returnCommand = commandTextProcessor.CreateCommandFromText("XYZ");

            Assert.AreEqual(Command.Unknown, returnCommand);
        }

        [TestMethod]
        public void WhenNoTextCommandIsSentToTheTextProcessorAnUnknownCommandTypeIsReturned()
        {
            CommandTextProcessor commandTextProcessor = new CommandTextProcessor();

            Command returnCommand = commandTextProcessor.CreateCommandFromText("");

            Assert.AreEqual(Command.Unknown, returnCommand);
        }

    }
}
