using ModelsLibrary;
using Moq;
using MyBLibrary;
using NUnit.Framework;
using System.Collections.Generic;

namespace BLTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetAllProductCount()
        {
            //arrange
            List<Product> products = new List<Product>
            {
                new Product{Name="Test1",Price=21.3f,UnitsInStock=20}
            };
           var moqProductRepo = new Mock<ProductRepo>();
            moqProductRepo.Setup(pr => pr.GetAll()).Returns(products);
            ProductBL bL = new ProductBL(moqProductRepo.Object);
            //Action
            var myProducts = bL.GetAllProducts();
            //Assert
            Assert.AreEqual(1, myProducts.Count);
        }
    }
}