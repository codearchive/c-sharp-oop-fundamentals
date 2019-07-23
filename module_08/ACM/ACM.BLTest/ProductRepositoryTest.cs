﻿using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Bread",
                Description = "Fresh bread",
                CurrentPrice = 15.96M
            };

            //-- Act
            var actual = productRepository.Retrieve(2);

            //-- Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                ProductName = "Bread",
                Description = "Fresh bread",
                CurrentPrice = 18M,
                HasChanges = true
            };

            //-- Act
            var actual = productRepository.Save(updateProduct);

            //-- Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPride()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                ProductName = "Bread",
                Description = "Fresh bread",
                CurrentPrice = null,
                HasChanges = true
            };

            //-- Act
            var actual = productRepository.Save(updateProduct);

            //-- Assert
            Assert.AreEqual(false, actual);
        }
    }
}
