using Microsoft.EntityFrameworkCore;

namespace MayaSpecialtyFoods.Models
{
	public class MayaSpecialtyFoodsContext : DbContext
	{
		public MayaSpecialtyFoodsContext()
		{

		}

		public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseMySql(@"Server=localhost;Port=3306;database=mayaspecialtyfoodstest;uid=root;pwd=root;");
		}

		public MayaSpecialtyFoodsContext(DbContextOptions<MayaSpecialtyFoodsContext> options)
			: base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
	}
}
