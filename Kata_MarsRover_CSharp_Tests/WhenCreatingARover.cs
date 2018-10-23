
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_MarsRover_CSharp_Tests
{
    [TestClass]
    class WhenCreatingARover
    {

        [TestMethod]
        public void ThenTheRoverIsGeneratedWithALocation()
        {

            Rover rover = new Rover(0, 0);

            Assert.IsNotNull(rover);

        }

    }
}
