using Microsoft.EntityFrameworkCore;

namespace MayaSpecialtyFoods.Models
{
    public class TestDbContext : MayaSpecialtyFoodsContext
    {
        public override DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;database=mayaspecialtyfoods_test;uid=root;pwd=root;");
        }
    }
}
