using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DustysCorner.DAL;

namespace DustysCorner.DAL.Initializers
{
    public static class StoreDataInitializer
    {
        public static void InitializeData(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<StoreContext>();
            context.Database.Migrate();
            SeedData(context);
        }

        public static void SeedData(StoreContext context)
        {
            try
            {
                if (!context.Category.Any())
                {
                    context.Category.AddRange(StoreSampleData.GetCategories());
                    context.SaveChanges();
                }

                if(!context.Product.Any())
                {
                    context.Product.AddRange(StoreSampleData.GetProducts(context));
                    context.SaveChanges();
                } 

                if(!context.Event.Any())
                {
                    context.Event.Add(StoreSampleData.GetEvent());
                    context.SaveChanges();
                }

                if(!context.Review.Any())
                {
                    context.Review.AddRange(StoreSampleData.GetReviews());
                    context.SaveChanges();
                }

                if (!context.Gallery.Any())
                {
                    context.Gallery.AddRange(StoreSampleData.GetGallery(context));
                    context.SaveChanges();
                }

                if (!context.SocialMedia.Any())
                {
                    context.SocialMedia.AddRange(StoreSampleData.GetSocialMedia());
                    context.SaveChanges();
                }

                if (!context.FeaturedProduct.Any())
                {
                    context.FeaturedProduct.AddRange(StoreSampleData.GetFeaturedProducts(context));
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}