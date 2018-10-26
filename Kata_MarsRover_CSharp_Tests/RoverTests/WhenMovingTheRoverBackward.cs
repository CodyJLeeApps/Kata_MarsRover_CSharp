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
    public class WhenMovingTheRoverBackward
    {

        [TestMethod]
        public void WhileFacingInTheNorthDirectionThenTheRoverMovesOneUnitInTheNegativeYDirection()
        {
            Rover rover = RoverTestFixtures.CreateRoverAtDefaultLocationWithGivenDirection(Direction.North);

            rover.MoveBackward();

            Rover expectedRover = new Rover(0, -1, Direction.North);
            Assert.AreEqual(expectedRover, rover);
        }

        [TestMethod]
        public void WhileFacingInTheSouthDirectionThenTheRoverMovesOneUnitInThePositiveYDirection()
        {
            Rover rover = RoverTestFixtures.CreateRoverAtDefaultLocationWithGivenDirection(Direction.South);

            rover.MoveBackward();

            Rover expectedRover = new Rover(0, 1, Direction.South);
            Assert.AreEqual(expectedRover, rover);
        }

    }
}