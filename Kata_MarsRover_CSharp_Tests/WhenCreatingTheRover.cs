using Kata_MarsRover_CSharp.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_MarsRover_CSharp_Tests
{
    [TestClass]
    public class WhenCreatingTheRover
    {

        [TestMethod]
        public void WithLocationThenTheRoverIsGeneratedAtTheDefaultLocation()
        {
            Rover rover = new Rover(0, 0);

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(0, rover.Y);
        }

        [TestMethod]
        public void WithLocationAndDirectionThenTheRoverIsGeneratedAtTheDefaultLocationWithProperDirection()
        {
            Rover rover = new Rover(0, 0, Direction.North);

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(0, rover.Y);
            Assert.AreEqual(Direction.North, rover.Direction);
        }

    }
}