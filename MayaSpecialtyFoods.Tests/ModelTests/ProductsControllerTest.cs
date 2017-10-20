using Microsoft.VisualStudio.TestTools.UnitTesting;
using MayaSpecialtyFoods.Models;

namespace MayaSpecialtyFoods.Tests
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void Equals_OverrideTrueForSameProductProperties_Product()
        {
            //Arrange, Act
            Product firstProduct = new Product(1, "Maya's Spinach Enchiladas", 9.95, "United States of America");
            Product secondProduct = new Product(1, "Maya's Spinach Enchiladas", 9.95, "United States of America");

            //Assert
            Assert.AreEqual(firstProduct, secondProduct);
        }
    }
}