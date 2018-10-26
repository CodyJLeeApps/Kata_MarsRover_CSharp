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

    }
}
