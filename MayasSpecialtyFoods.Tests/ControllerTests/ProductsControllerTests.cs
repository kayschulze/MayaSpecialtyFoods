using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MayaSpecialtyFoods.Models;
using MayaSpecialtyFoods.Controllers;
using Moq;
using System.Linq;

namespace MayaSpecialtyFoods.Tests
{
    [TestClass]
    public class ProductsControllerTest
    {
        Mock<IProductRepository> mock = new Mock<IProductRepository>();
        EFProductRepository db = new EFProductRepository(new TestDbContext());

        private void DbSetup()
        {
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product(1, "Maya's Spinach Enchiladas", 9.95, "United States of America"),
                new Product(2, "Maya's Spaghetti Sauce", 4.95, "China"),
                new Product(3, "Maya's Stir Fry", 7.95, "Italy")
            }.AsQueryable());
        }

        [TestMethod]
        public void Mock_GetViewResultIndex_Test()  //Confirms route returns view
        {
            //Arrange
            DbSetup();
            ProductsController controller = new ProductsController(mock.Object);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsInstanceOfType(result, typeof(ActionResult));
        }

        [TestMethod]
        public void Mock_IndexListofProducts_Test()
        {
            //Arrange
            DbSetup();
            ViewResult indexView = new ProductsController(mock.Object).Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<Product>));
        }

        [TestMethod]
        public void Mock_ConfirmEntry_Test()
        {
            // Arrange
            DbSetup();
            ProductsController controller = new ProductsController(mock.Object);
            int ProductId = 1;
            string Name = "Maya's Spinach Enchiladas";
            double Cost = 9.95;
            string Origincountry = "United States of America";
            Product testProduct = new Product(ProductId, Name, Cost, Origincountry);

            // Act
            ViewResult indexView = controller.Index() as ViewResult;
            var collection = indexView.ViewData.Model as List<Product>;

            // Assert
            CollectionAssert.Contains(collection, testProduct);
        }
    }
}
