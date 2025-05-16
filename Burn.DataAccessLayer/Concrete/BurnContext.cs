using Burn.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Burn.DataAccessLayer.Concrete
{
    public class BurnContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;initial Catalog=BurnDb;Integrated Security=True;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
