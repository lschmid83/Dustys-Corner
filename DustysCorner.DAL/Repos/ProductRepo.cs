using DustysCorner.DAL;
using DustysCorner.DAL.Entities;
using DustysCorner.DAL.Repos.Base;
using DustysCorner.DAL.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DustysCorner.DAL.Repos
{
    public class ProductRepo : RepoBase<Product>, IProductRepo
    {
        public ProductRepo(DbContextOptions<StoreContext> options)
        : base(options)
        {
        }
        public ProductRepo()
        {
        }

        public override IEnumerable<Product> GetAll()
        {
            return Table
                    .Include(x=> x.Category)
                    .Include(x=> x.AdditionalImages)
                    .Include(x=> x.Options)
                    .OrderBy(x=> x.Name)
                    .ToList();
        }

        public IEnumerable<Product> GetCategory(int categoryId)
        {
            var products = Table
                    .Include(x => x.Category)
                    .Include(x => x.AdditionalImages)
                    .Include(x => x.Options)
                    .Where(x=> x.Category.Id == categoryId)
                    .OrderBy(x=> x.Name)
                    .ToList();
            return Sort(products);
        }
        
        private IEnumerable<Product> Sort(IEnumerable<Product> products)
        {
            foreach (var product in products)
            {
                product.AdditionalImages = product.AdditionalImages.OrderBy(x => x.Order).ToList();
                product.Options = product.Options.OrderBy(x => x.Order).ToList();
            }
            return products;
        }
    }
}
