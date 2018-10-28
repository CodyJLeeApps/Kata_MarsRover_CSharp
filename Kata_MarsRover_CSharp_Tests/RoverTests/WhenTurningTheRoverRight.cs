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
        public void AndFacingInTheNorthDirectionThenTheRoverFacesInTheEastDirection()
        {
            Rover rover = RoverTestFixtures.CreateRoverAtDefaultLocationWithGivenDirection(Direction.North);

            rover.TurnRight();

            Rover expectedRover = RoverTestFixtures.CreateRoverAtDefaultLocationWithGivenDirection(Direction.East);
            Assert.AreEqual(expectedRover, rover);
        }

        [TestMethod]
        public void AndFacingInTheEastDirectionThenTheRoverFacesInTheSouthDirection()
        {
            Rover rover = RoverTestFixtures.CreateRoverAtDefaultLocationWithGivenDirection(Direction.East);

            rover.TurnRight();

            Rover expectedRover = RoverTestFixtures.CreateRoverAtDefaultLocationWithGivenDirection(Direction.South);
            Assert.AreEqual(expectedRover, rover);
        }

        [TestMethod]
        public void AndFacingInTheSouthDirectionThenTheRoverFacesInTheWestDirection()
        {
            Rover rover = RoverTestFixtures.CreateRoverAtDefaultLocationWithGivenDirection(Direction.South);

            rover.TurnRight();

            Rover expectedRover = RoverTestFixtures.CreateRoverAtDefaultLocationWithGivenDirection(Direction.West);
            Assert.AreEqual(expectedRover, rover);
        }

    }
}
