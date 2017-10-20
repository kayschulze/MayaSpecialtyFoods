using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MayaSpecialtyFoods.Models
{
    public class EFReviewRepository : IReviewRepository
    {
        MayaSpecialtyFoodsContext db = new MayaSpecialtyFoodsContext();

        public IQueryable<Review> Reviews
        { get { return db.Reviews; } }

        public Review Save(Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
            return review;
        }

        public Review Edit(Review review)
        {
            db.Entry(review).State = EntityState.Modified;
            db.SaveChanges();
            return review;
        }

        public void Remove(Review review)
        {
            db.Reviews.Remove(review);
            db.SaveChanges();
        }
    }
}