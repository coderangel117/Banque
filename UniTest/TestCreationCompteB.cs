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
        [TestMethod]
        public void Test_soldeApresDebit()
        {
            CompteB MonCompte2 = new CompteB(500, "PERINO", "euros", 2);
            MonCompte2.Debiter(100);
            Assert.AreEqual(MonCompte2.GetSolde(), 400);
        }
        public void Test_soldeApresDebit()
        {
            CompteB MonCompte2 = new CompteB(500, "PERINO", "euros", 2);
            MonCompte2.Debiter(100);
            Assert.AreEqual(MonCompte2.GetSolde(), 400);
        }
    }
}
