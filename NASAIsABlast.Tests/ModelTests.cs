using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NASAIsABlast.Models;

namespace NASAIsABlast.Tests
{
    [TestClass]
    public class NasaModelTests
    {
        [TestMethod]
        public void CrewTest()
        {
            CrewRequirements newRequirements = new CrewRequirements(3, 1200);

            var result = newRequirements.RequiredAstronauts();
            System.Console.WriteLine(result);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ArcDistanceTest()
        {
            int thisLatDegree = 28;
            int thisLatMinute = 28;
            int thisLngDegree = -80;
            int thisLngMinute = -31;
            RocketDistance newRocketDistance = new RocketDistance(thisLatDegree, thisLatMinute, thisLngDegree, thisLngMinute);

            var result = newRocketDistance.CalculateDistance();
            //result = Math.Round(result * 2 / 1609);

            Assert.AreEqual(1, result); 
        }
    }
}
