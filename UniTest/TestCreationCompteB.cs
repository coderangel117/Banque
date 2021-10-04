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
            CompteB MonCompte = new CompteB("PERINO","euros");
            Assert.AreEqual(MonCompte.GetSolde(), 0);
        }

        [TestMethod]
        public void Test_soldeCreationCompteB500()
        {
            CompteB MonCompte = new CompteB(500, "PERINO", "euros");
            Assert.AreEqual(MonCompte.GetSolde(), 500);
        }
        [TestMethod]
        public void Test_soldeApresDebit()
        {
            CompteB MonCompte2 = new CompteB(500, "PERINO", "euros");
            MonCompte2.Debiter(100);
            Assert.AreEqual(MonCompte2.GetSolde(), 400);
        }
        [TestMethod]
        public void Test_SoldeApresCredit()
        {
            CompteB MonCompte2 = new CompteB(500, "PERINO", "euros");
            MonCompte2.Crediter(100);
            Assert.AreEqual(MonCompte2.GetSolde(), 600);
        }
        public void Test_GetNbCompte()
        {
            CompteB CompteB1 = new CompteB("PERINO", "euros");
            CompteB CompteB2 = new CompteB("PERINO", "euros");
            CompteB CompteB3 = new CompteB("PERINO", "euros");
            CompteE CompteE1 = new CompteE(0.5, 10);
            Assert.AreEqual(CompteB.GetSolde, 4);
        }
    }
}
