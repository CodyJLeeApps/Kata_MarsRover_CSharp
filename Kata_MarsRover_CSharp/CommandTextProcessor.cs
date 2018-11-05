using Kata_MarsRover_CSharp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_MarsRover_CSharp
{
    public class CommandTextProcessor
    {

        public Command CreateCommandFromText(string textCommand)
        {
            if (textCommand == null)
                throw new ArgumentNullException(textCommand, $"The argument {nameof(textCommand)} was null!");

            string lowercaseTextCommand = textCommand.ToLower();
            Command command = new Command();
            if(lowercaseTextCommand == "l")
            {
                command = Command.TurnLeft;
            }
            return command;
        }

    }
}
