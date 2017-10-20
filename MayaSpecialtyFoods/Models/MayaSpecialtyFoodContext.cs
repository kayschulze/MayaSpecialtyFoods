﻿using Microsoft.EntityFrameworkCore;

namespace MayaSpecialtyFoods.Models
{
	public class AnimalSanctuaryContext : DbContext
	{
		public AnimalSanctuaryContext()
		{

		}

		public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseMySql(@"Server=localhost;Port=3306;database=gummibearkingdomMigrations;uid=root;pwd=root;");
		}

		public AnimalSanctuaryContext(DbContextOptions<AnimalSanctuaryContext> options)
			: base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
	}
}
