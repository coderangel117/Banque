using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Banque;

namespace BanqueTest
{
    [TestClass]
    public class TestComptes
    {
        [TestMethod]
        public void Test_soldeCreationCompteB()
        {
            CompteB MonCompte = new CompteB("PERINO","euros", 1);
            Assert.AreEqual(MonCompte.GetSolde(), 0);
        }

        [TestMethod]
        public void Test_soldeCreationCompteB500()
        {
            CompteB MonCompte = new CompteB(500, "PERINO", "euros", 1);
            Assert.AreEqual(MonCompte.GetSolde(), 500);
        }
    }
}
