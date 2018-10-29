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
    public class WhenTurningTheRoverLeft
    {

        [TestMethod]
        public void AndFacingInTheNorthDirectionThenTheRoverTurnsToFaceInTheEastDirection()
        {
            Rover rover = RoverTestFixtures.CreateRoverAtDefaultLocationWithGivenDirection(Direction.North);

            rover.TurnLeft();

            Rover expectedRover = RoverTestFixtures.CreateRoverAtDefaultLocationWithGivenDirection(Direction.West);
            Assert.AreEqual(expectedRover, rover);
        }

    }
}
