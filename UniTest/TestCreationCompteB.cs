using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Banque;

namespace BanqueTest
{
    [TestClass]
    public class TestComptes
    {
        [TestMethod]
        public void TestsoldeCreationCompteB()
        {
            CompteB MonCompte = new CompteB(500,"PERINO","euros", 1);
            Assert.AreEqual(MonCompte.GetSolde(), 0);
        }

    }
}
