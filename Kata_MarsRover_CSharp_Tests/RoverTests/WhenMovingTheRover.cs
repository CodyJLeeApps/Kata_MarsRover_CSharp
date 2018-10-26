using Kata_MarsRover_CSharp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_MarsRover_CSharp_Tests.RoverTests
{
    [TestClass]
    public class WhenMovingTheRover
    {

        [TestMethod]
        public void WhileFacingNorthThenTheRoverMovesOneUnitInThePositiveYDirection()
        {
            Rover rover = new Rover(0, 0, Direction.North);

            rover.MoveForward();

            Rover expectedRover = new Rover(0, 1, Direction.North);
            Assert.AreEqual(expectedRover, rover);
        }

        [TestMethod]
        public void WhileFacingSouthThenTheRoverMovesOneUnitInTheNegativeYDirection()
        {
            Rover rover = new Rover(0, 0, Direction.South);

            rover.MoveForward();

            Rover expectedRover = new Rover(0, -1, Direction.South);
            Assert.AreEqual(expectedRover, rover);
        }

    }
}
