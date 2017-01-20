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
            //Assert.AreEqual(0, sut.GetValue());
            Assert.AreEqual(null, sut.name);
            Assert.AreEqual(null, sut.suit);
        }

        [TestMethod]
        public void CardsCanBeCreatedWithArgs()
        {
            var sut = new Card("9", "Hearts");
            Assert.AreEqual("Hearts", sut.suit);
            Assert.AreEqual("9", sut.name);

        }
    }
}
