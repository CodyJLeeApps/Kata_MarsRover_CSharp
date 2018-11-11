using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_MarsRover_CSharp
{
    public class FileLogger
    {

        public FileLogger(string filePath)
        {
            if (filePath == null)
                throw new ArgumentNullException($"The argument {nameof(filePath)} was null!");
        }

    }
}
