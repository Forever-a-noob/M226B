using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ4._3
{
    [TestClass]
    class DogTest
    {
        [TestMethod]
        public void TestHasBittenOwner()
        {
            Dog dog = new Dog();

            var personStub = new Mock<Person>();
            personStub
                .Setup(p => p.HasBeenBitten())
                .Returns(true);

            dog.Owner = personStub.Object;

            dog.BiteOwner();

            Assert
        }
    }
}
