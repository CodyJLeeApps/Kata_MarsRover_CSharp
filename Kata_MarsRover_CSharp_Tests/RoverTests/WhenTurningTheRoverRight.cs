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
    public class WhenTurningTheRoverRight
    {

        [TestMethod]
        [DataRow(Direction.North, Direction.East, DisplayName = "AndFacingInTheNorthDirectionThenTheRoverFacesInTheEastDirection")]
        [DataRow(Direction.East, Direction.South, DisplayName = "AndFacingInTheEastDirectionThenTheRoverFacesInTheSouthDirection")]
        [DataRow(Direction.South, Direction.West, DisplayName = "AndFacingInTheSouthDirectionThenTheRoverFacesInTheWestDirection")]
        [DataRow(Direction.West, Direction.North, DisplayName = "AndFacingInTheWestDirectionThenTheRoverFacesInTheNothDirection")]
        public void TheRoverTurnsToFaceTheCorrectDirection(Direction startingDirection, Direction expectedDirection)
        {
            Rover rover = RoverTestFixtures.CreateRoverAtDefaultLocationWithGivenDirection(startingDirection);

            rover.TurnRight();

            Rover expectedRover = RoverTestFixtures.CreateRoverAtDefaultLocationWithGivenDirection(expectedDirection);
            Assert.AreEqual(expectedRover, rover);
        }

    }
}
