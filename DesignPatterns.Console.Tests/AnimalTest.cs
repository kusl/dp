using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Console.Tests
{
    [TestClass]
    public class AnimalTest
    {
        [TestMethod]
        public void SetWeightToNegativeFive()
        {
            var animal = new Animal();
            animal.Weight = -5;
            Assert.AreEqual(0, animal.Weight);
        }
        [TestMethod]
        public void SetWeightToFive()
        {
            var animal = new Animal();
            animal.Weight = 5;
            Assert.AreEqual(5, animal.Weight);
        }
        [TestMethod]
        public void SetNameToFido()
        {
            var animal = new Animal();
            animal.Name = "Fido";
            Assert.AreEqual("Fido", animal.Name);
        }
        [TestMethod]
        public void SetSoundToMeow()
        {
            var animal = new Animal();
            animal.Sound = "Meow";
            Assert.AreEqual("Meow", animal.Sound);
        }
    }
}
