using Kata_MarsRover_CSharp.Domain;
using Kata_MarsRover_CSharp_Tests.RoverTests.TestFixtures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_MarsRover_CSharp_Tests.RoverTests
{
    [TestClass]
    public class WhenMovingTheRoverBackward
    {

        [TestMethod]
        [DataRow(0, -1, Direction.North, DisplayName = "WhileFacingInTheNorthDirectionThenTheRoverMovesOneUnitInTheNegativeYDirection")]
        [DataRow(0, 1, Direction.South, DisplayName = "WhileFacingInTheSouthDirectionThenTheRoverMovesOneUnitInThePositiveYDirection")]
        [DataRow(-1, 0, Direction.East, DisplayName = "WhileFacingInTheEastDirectionThenTheRoverMovesOneUnitInThePositiveXDirection")]
        [DataRow(1, 0, Direction.West, DisplayName = "WhileFacingInTheWestDirectionThenTheRoverMovesOneUnitInThePositiveYDirection")]
        public void TheRoverMovesBackwardByOneUnitInTheProperDirection(int ExpectedX, int expectedY, Direction direction)
        {
            Rover rover = RoverTestFixtures.CreateRoverAtDefaultLocationWithGivenDirection(direction);

            rover.MoveBackward();

            Rover expectedRover = new Rover(ExpectedX, expectedY, direction);
            Assert.AreEqual(expectedRover, rover);
        }

    }
}
