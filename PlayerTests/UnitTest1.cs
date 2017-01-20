using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blackjack.Tests
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void DoPlayersInitializeCorrectly()
        {
            var sut = new Player();
            Assert.AreEqual(0, sut.handSize);
            Assert.AreEqual(0, sut.GethandValue());
            Assert.AreEqual(21, sut.Getbuffer());
        }
    }
}
