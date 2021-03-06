﻿using Kata_MarsRover_CSharp.Domain;
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
        [DataRow(Direction.North, Direction.West, DisplayName = "AndFacingInTheNorthDirectionThenTheRoverTurnsToFaceInTheEastDirection")]
        [DataRow(Direction.West, Direction.South, DisplayName = "AndFacingInTheWestDirectionThenTheRoverTurnsToFaceInTheSouthDirection")]
        [DataRow(Direction.South, Direction.East, DisplayName = "AndFacingInTheSouthDirectionThenTheRoverTurnsToFaceInTheEastDirection")]
        [DataRow(Direction.East, Direction.North, DisplayName = "AndFacingInTheEastDirectionThenTheRoverTurnsToFaceInTheNorthDirection")]
        public void TheRoverTurnsToFaceTheCorrectDirection(Direction startingDirection, Direction expectedDirection)
        {
            Rover rover = RoverTestFixtures.CreateRoverAtDefaultLocationWithGivenDirection(startingDirection);

            rover.TurnLeft();

            Rover expectedRover = RoverTestFixtures.CreateRoverAtDefaultLocationWithGivenDirection(expectedDirection);
            Assert.AreEqual(expectedRover, rover);
        }

    }
}
