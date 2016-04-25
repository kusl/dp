using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Console.Tests
{
    [TestClass]
    public class CatTest
    {
        [TestMethod]
        public void SetWeightToNegativeFive()
        {
            var cat = new Cat();
            cat.Weight = -5;
            Assert.AreEqual(0, cat.Weight);
        }
        [TestMethod]
        public void SetWeightToFive()
        {
            var cat = new Cat();
            cat.Weight = 5;
            Assert.AreEqual(5, cat.Weight);
        }
        [TestMethod]
        public void SetNameToFido()
        {
            var cat = new Cat();
            cat.Name = "Fido";
            Assert.AreEqual("Fido", cat.Name);
        }
        [TestMethod]
        public void SetSoundToMeow()
        {
            var cat = new Cat();
            cat.Sound = "Meow";
            Assert.AreEqual("Meow", cat.Sound);
        }
        public void CheckCatMeows()
        {
            var cat = new Cat();
            Assert.AreEqual(Cat.catSound, cat.Sound);
        }
    }
}
