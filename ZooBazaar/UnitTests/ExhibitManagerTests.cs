using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using ZooBazaarLogicLayer.Managers;
using ZooBazaarLogicLayer.Zones;

namespace UnitTests
{
    [TestClass]
    public class ExhibitManagerTests
    {
        [TestMethod]
        public void CanAddExhibit()
        {
            var manager = ExhibitManager.CreateForUnitTest();
            Exhibit exhibit = new Exhibit(1, "Test exhibit", "Taiga", 5, 0);

            var managerResponse = manager.AddExhibit(exhibit);

            Assert.IsTrue(manager.Exhibits.Count == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DuplicateAddFails()
        {
            var manager = ExhibitManager.CreateForUnitTest();
            Exhibit exhibit = new Exhibit(1, "Test exhibit", "Taiga", 5, 0);

            manager.AddExhibit(exhibit);
            manager.AddExhibit(exhibit);
        }

        [TestMethod]
        public void CanRemoveExhibit()
        {
            var manager = ExhibitManager.CreateForUnitTest();
            Exhibit exhibit1 = new Exhibit(1, "Test exhibit", "Taiga", 5, 0);
            Exhibit exhibit2 = new Exhibit(2, "Test exhibit 2", "Arctic", 5, 0);


            manager.AddExhibit(exhibit1);
            manager.AddExhibit(exhibit2);

            manager.DeleteExhibit(exhibit1);


            Assert.AreEqual(exhibit2, manager.Exhibits[0]);
            Assert.IsTrue(manager.Exhibits.Count == 1);
        }

        [TestMethod]
        public void CanUpdate()
        {
            Exhibit exhibit1 = new Exhibit(1, "Test", "Taiga", 5, 0);
            var manager = ExhibitManager.CreateForUnitTest();

            manager.AddExhibit(exhibit1);
            exhibit1.ChangeZone("Arctic"); //Update
            manager.UpdateExhibit(exhibit1);


            Assert.IsTrue(manager.Exhibits[0].Zone == "Arctic");
        }

        [TestMethod]
        
        public void UpdatingUnregisteredExhibitReturnsFalseSuccessResponse()
        {
            Exhibit exhibit1 = new Exhibit(1, "Test", "Taiga", 5, 0);
            var manager = ExhibitManager.CreateForUnitTest();

            var managerResponse = manager.UpdateExhibit(exhibit1);

            Assert.IsFalse(managerResponse.Success);
        }

        [TestMethod]
        public void SearchByIdReturnsValue()
        {
            Exhibit exhibit1 = new Exhibit(1, "Test1", "Taiga", 5, 0);
            Exhibit exhibit2 = new Exhibit(2, "Test2", "Taiga", 5, 0);
            var manager = ExhibitManager.CreateForUnitTest();

            manager.AddExhibit(exhibit1);
            manager.AddExhibit(exhibit2);

            Exhibit searchResult = manager.SearchById(1);

            Assert.AreSame(exhibit1, searchResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SearchByIdThrowsArgumentExceptionIfNoneFound()
        {
            var manager = ExhibitManager.CreateForUnitTest();
            manager.SearchById(1);
        }

        [TestMethod]
        public void SearchByNameReturnsValue()
        {
            var manager = ExhibitManager.CreateForUnitTest();
            string name = "Test exhibit 1";
            Exhibit exhibit1 = new Exhibit(1, name, "Taiga", 5, 0);

            manager.AddExhibit(exhibit1);
            Exhibit[] searchResult = manager.GetByName(name).ToArray();

            Assert.AreSame(exhibit1, searchResult.Single());
        }

        [TestMethod]
        public void GetAllReturnsFullList()
        {
            Exhibit[] exhibits = new Exhibit[3]
            {
                new Exhibit(1, "Test exhibit 1", "Taiga", 5, 0),
                new Exhibit(2, "Test exhibit 2", "Taiga", 5, 0),
                new Exhibit(3, "Test exhibit 3", "Taiga", 5, 0)
            };

            var manager = ExhibitManager.CreateForUnitTest();

            foreach(Exhibit exhibit in exhibits)
            {
                manager.AddExhibit(exhibit);
            }
            
            Exhibit[] searchResultCollection = manager.GetAll().ToArray();
            Assert.IsTrue(exhibits.Length == searchResultCollection.Length);
        }
    }
}