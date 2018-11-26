using System;
using BankinApp.L0.DataAccess.Implementation;
using BankinApp.L0.DataAccess.Facade;
using BankinApp.L0.DataAccess.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace BankinApp.L0.DataAccess.Tests
{
    [TestClass]
    public class UnitTestComptesRepositoryImpl_Memory
    {
        [TestMethod]
        public void TestFindAll()
        {
            //ARRANGE
            var underTest = new CompteRepositoryImp_Memory();
            var expected = 3;

            //ACT
            var actual = ((List<Compte>)underTest.FindAll()).Count;

            //ASSERT

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestFindByID()
        {
            //ARRANGE
            var underTest = new CompteRepositoryImp_Memory();
            var id = "C100";
            var expected = new Compte { Numero = "C100", Proprietaire = "Mohamed", Solde = 1000M };

            //ACT
            var actual = underTest.FindById(id);

            //ASSERT

            Assert.AreEqual(expected, actual);

        }
    }
}
