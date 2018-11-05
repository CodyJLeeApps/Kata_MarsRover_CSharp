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

            Command command = new Command();
            if(textCommand == "l")
            {
                command = Command.TurnLeft;
            }
            return command;
        }

    }
}
