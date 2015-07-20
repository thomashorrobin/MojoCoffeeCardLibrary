using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MojoCoffeeCardLibrary.DataModel;
using System.Linq;

namespace MojoCoffeeCardLibrary.Tests
{
    [TestClass]
    public class BaseTests
    {
        Model1 db = new Model1();

        [TestMethod]
        public void OrganisationName()
        {
            Assert.AreEqual("Nova Energy", db.XeroCustomers.Find(1549).OrganisationName);
        }

        [TestMethod]
        public void FindTom()
        {
            Assert.AreEqual(1549,db.Individuals.Single(e => e.LastName == "Horrobin").OrganisationalId);
        }

        [TestMethod]
        public void CheckTomsCardNumber()
        {
            Card card = db.Individuals.Single(e => e.LastName == "Horrobin").IndividualCards.First();
            Assert.AreEqual("f479ab23ca", card.CardId);
        }
    }
}
