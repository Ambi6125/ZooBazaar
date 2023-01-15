using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZooBazaarLogicLayer.Zones;

namespace UnitTests
{
    [TestClass]
    public class ExhibitTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CannotHaveNullName()
        {
            Exhibit exhibit = new Exhibit(1, null, "Taiga", 5, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CannotHaveNullLocation()
        {
            Exhibit exhibit = new Exhibit(1, "Test", null, 5, 0);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void CannotHaveEmptyName()
        {
            Exhibit exhibit = new Exhibit(1, String.Empty, "Taiga", 5, 0);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void CannotHaveEmptyLocation()
        {
            Exhibit exhibit = new Exhibit(1, "Test", String.Empty, 5, 0);
        }

        [TestMethod]
        public void CanChangeTitle()
        {
            Exhibit exhibit = new Exhibit(1, "WRONG NAME", "Taiga", 5, 0);
            string newName = "Correct name";
            exhibit.Name = newName;

            Assert.AreEqual(newName, exhibit.Name);
        }

        [TestMethod]
        public void CanChangeZoneToValidOption()
        {
            Exhibit exhibit = new Exhibit(1, "Test exhibit", "Taiga", 5, 0);
            exhibit.ChangeZone("Arctic");

            Assert.AreEqual("Arctic", exhibit.Zone);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ChangingZoneToInvalidOptionThrowsException()
        {
            Exhibit exhibit = new Exhibit(1, "Test exhibit", "Taiga", 5, 0);
            exhibit.ChangeZone("Not a correct option");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ChangingToInvalidCountThrowsException()
        {
            Exhibit exhibit = new Exhibit(1, "Test exhibit", "Taiga", 5, 0);
            exhibit.ChangeCount(-1000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceedingCapInUpdateThrowsException()
        {
            Exhibit exhibit = new Exhibit(1, "Test exhibit", "Taiga", 1, 0);
            exhibit.ChangeCount(2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceedingCapInConstructorThrowsException()
        {
            Exhibit exhibit = new Exhibit(1, "Test exhibit", "Taiga", 1, 2);
        }
    }
}