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
    public class WhenMovingTheRoverForward
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

        [TestMethod]
        public void WhileFacingEastThenTheRoverMovesOneUnitInThePositiveXDirection()
        {
            Rover rover = new Rover(0, 0, Direction.East);

            rover.MoveForward();

            Rover expectedRover = new Rover(1, 0, Direction.East);
            Assert.AreEqual(expectedRover, rover);
        }

        [TestMethod]
        public void WhileFacingWestThenTheRoverMovesOneUnitInTheNegativeXDirection()
        {
            Rover rover = new Rover(0, 0, Direction.West);

            rover.MoveForward();

            Rover expectedRover = new Rover(-1, 0, Direction.West);
            Assert.AreEqual(expectedRover, rover);
        }

    }
}
