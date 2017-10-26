using Microsoft.VisualStudio.TestTools.UnitTesting;
using MayaSpecialtyFoods.Models;
using MayaSpecialtyFoods.Controllers;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;

namespace MayaSpecialtyFoods.Tests
{
    [TestClass]
    public class ProductsTest
    {
        MayaSpecialtyFoodsContext db = new MayaSpecialtyFoodsContext();

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MayaSpecialtyFoodsContext>(options => options.UseMySql(@"Server=localhost;Port=3306;database=mayaspecialtyfoodstest;uid=root;pwd=root;"));
        }

        [TestMethod]
        public void Equals_OverrideTrueForSameProductProperties_Product()
        {
            //Arrange, Act
            Product firstProduct = new Product(1, "Maya's Spinach Enchiladas", 9.95, "United States of America");
            Product secondProduct = new Product(1, "Maya's Spinach Enchiladas", 9.95, "United States of America");

            //Assert
            Assert.AreEqual(firstProduct, secondProduct);
        }

        [TestMethod]
        public void Equals_ProductNameIsFoundInProductObject_Name()
        {
            //Arrange
            Product newProduct = new Product(1, "Maya's Spinach Enchiladas", 9.95, "United States of America");
            string expected = "Maya's Spinach Enchiladas";

            //Act
            string result = newProduct.Name;

            //Assert
            Assert.AreEqual(expected, result);
        }

    }

}