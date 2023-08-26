using Microsoft.EntityFrameworkCore;
using DustysCorner.DAL.Entities;

namespace DustysCorner.DAL
{
    public class StoreContext : DbContext
    {
        public DbSet<Category> Category { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<ProductImage> ProductImage { get; set; }

        public DbSet<ProductOption> ProductOption { get; set; }

        public DbSet<Event> Event { get; set; }

        public DbSet<Review> Review { get; set; }

        public DbSet<Gallery> Gallery { get; set; }

        public DbSet<GalleryImage> GalleryImage { get; set; }

        public DbSet<SocialMedia> SocialMedia { get; set; }

        public DbSet<FeaturedProduct> FeaturedProduct { get; set; }

        public StoreContext()
        {
        }

        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                @"Data Source=YOUR_SERVER_NAME;Initial Catalog=DustysCorner;Persist Security Info=True;User ID=YOUR_USERNAME;Password=YOUR_PASSWORD",
                options => options.EnableRetryOnFailure());
            }
        }
    }
}
 