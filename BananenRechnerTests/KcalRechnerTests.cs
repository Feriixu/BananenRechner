using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BananenRechner;

namespace BananenRechnerTests
{
    [TestClass]
    public class KcalRechnerTests
    {
        [TestMethod]
        public void KcalPerBanana_100g_1kcalPer100g_Returns1()
        {
            // Arrange
            KcalRechner k = new KcalRechner(1);

            // Act
            int result = k.KcalPerBanana(100);
            Console.WriteLine(result);

            // Assert
            Assert.IsTrue(result == 1);
        }
    }
}