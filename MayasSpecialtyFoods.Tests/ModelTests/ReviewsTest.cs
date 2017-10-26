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
    public class ReviewsTest
    {
        MayaSpecialtyFoodsContext db = new MayaSpecialtyFoodsContext();

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MayaSpecialtyFoodsContext>(options => options.UseMySql(@"Server=localhost;Port=3306;database=mayaspecialtyfoodstest;uid=root;pwd=root;"));
        }

        [TestMethod]
        public void Equals_OverrideTrueForSameReviewProperties_Review()
        {
            //Arrange, Act
            Review firstReview = new Review(1, "Maya", "Loved it!", 5, 1);
            Review secondReview = new Review(1, "Maya", "Loved it!", 5, 1);

            //Assert
            Assert.AreEqual(firstReview, secondReview);
        }

        [TestMethod]
        public void Equals_ReviewNameIsFoundInReviewObject_Name()
        {
            //Arrange
            Review newReview = new Review(1, "Maya", "Loved it!", 5, 1);
            string expected = "Maya";

            //Act
            string result = newReview.Author;

            //Assert
            Assert.AreEqual(expected, result);
        }

    }

}
