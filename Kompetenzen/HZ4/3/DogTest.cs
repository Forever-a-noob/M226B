using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kompetenzen.HZ4._2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kompetenzen.HZ4._3
{
    [TestClass]
    class DogTest
    {
        [TestMethod]
        public void TestHasBittenOwner()
        {
            Person josh = new Person();
            josh.Pet = new AnimalStub();

            Assert.Equals(josh.IsHappy, false);
        }
    }
}
