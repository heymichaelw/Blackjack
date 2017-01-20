using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blackjack.Tests
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void DoCardsInitializeCorrectly()
        {
            var sut = new Card();
            Assert.AreEqual(0, sut.GetValue());
            Assert.AreEqual(null, sut.name);
        }

        [TestMethod]
        public void CardsCanBeCreatedWithArgs()
        {
            var sut = new Card(9, "9");
            Assert.AreEqual(9, sut.GetValue());
            Assert.AreEqual("9", sut.name);

        }
    }
}
