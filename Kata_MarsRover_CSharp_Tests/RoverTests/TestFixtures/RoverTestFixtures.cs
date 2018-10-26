using Kata_MarsRover_CSharp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_MarsRover_CSharp_Tests.RoverTests.TestFixtures
{
    public static class RoverTestFixtures
    {

        public static Rover CreateRoverAtDefaultLocationWithGivenDirection(Direction direction) 
            => new Rover(0, 0, direction);
        

    }
}
