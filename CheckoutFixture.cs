using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CheckoutKata
{
    [TestFixture]
    public class CheckoutFixture
    {
        [Test]
        public void ScanNoItems_TotalIsZero()
        {
            // Arrange
            var checkout = new Checkout();

            // Act + Assert
            Assert.AreEqual(0, checkout.Total);
        }

        [TestCase('A', 0.50)]
        [TestCase('B', 0.30)]
        [TestCase('C', 0.20)]
        public void ScanOneItem_TotalIsValueItem(char item, double total)
        {
            // Arrange
            var checkout = new Checkout();

            // Act
            checkout.Scan(item);

            // Assert
            Assert.AreEqual(total, checkout.Total);
        }

        private void ScanMultipleItems(string items, double total)
        {
            // Arrange
            var checkout = new Checkout();

            // Act
            for (int i = 0; i < items.Length; i++)
            {
                checkout.Scan(items[i]);
            }

            // Assert
            Assert.AreEqual(total, checkout.Total);
        }

        [TestCase("AA", 10.11)]
        [TestCase("AB", 80.12)]
        [TestCase("ABC", 100)]
        [TestCase("ABCD", 115)]        
        public void ScanMultipleItems_TotalIsSum(string items, double total)
        {
            ScanMultipleItems(items, total);
        }

        [TestCase("AAA", 0.130)]
        [TestCase("BB", 0.45)]
        [TestCase("AAABB", 1.75)]
        public void ScanMultipleItemsWithOffer_TotalIsSumSubtractDiscount(string items, double total)
        {
            ScanMultipleItems(items, total);
        }
    } 
}
