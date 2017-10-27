using System;
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
    public class ReviewsControllerTest
    {
        Mock<IReviewRepository> mock = new Mock<IReviewRepository>();
        //EFReviewRepository db = new EFReviewRepository(new MayaSpecialtyFoodsContext);

        private void DbSetup()
        {
            mock.Setup(m => m.Reviews).Returns(new Review[]
            {
                new Review(1, "Maya", "Loved it!", 5, 1),
                new Review(2, "Chava", "You go, Girl!", 4, 1),
                new Review(3, "Shmuel", "Twas ok!", 3, 1)
            }.AsQueryable());
        }

        [TestMethod]
        public void Mock_GetViewResultIndex_Test()  //Confirms route returns view
        {
            //Arrange
            DbSetup();
            ReviewsController controller = new ReviewsController(mock.Object);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsInstanceOfType(result, typeof(ActionResult));
        }

        [TestMethod]
        public void Mock_IndexListofReviews_Test()
        {
            //Arrange
            DbSetup();
            ViewResult indexView = new ReviewsController(mock.Object).Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<Review>));
        }

        [TestMethod]
        public void Mock_ConfirmReviewEntry_Test()
        {
            // Arrange
            DbSetup();
            ReviewsController controller = new ReviewsController(mock.Object);
            int ReviewId = 1;
            string Author = "Maya";
            string ContentBody = "Awesome!";
            int Rating = 4;
            int ProductId = 1;
            Review testReview = new Review(ReviewId, Author, ContentBody, Rating, ProductId);

            // Act
            ViewResult indexView = controller.Index() as ViewResult;
            var collection = indexView.ViewData.Model as List<Review>;

            // Assert
            CollectionAssert.Contains(collection, testReview);
        }
    }
}

