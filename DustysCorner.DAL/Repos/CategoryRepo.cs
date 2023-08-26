using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DustysCorner.DAL;
using DustysCorner.DAL.Repos.Base;
using DustysCorner.DAL.Repos.Interfaces;
using DustysCorner.DAL.Entities;

namespace DustysCorner.DAL.Repos
{
    public class CategoryRepo : RepoBase<Category>, ICategoryRepo
    {
        public CategoryRepo(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public CategoryRepo()
        {
        }

        public Category Get(int id)
        {
            return Table
                  .Include(x => x.Children)
                  .Where(x => x.Id == id)
                  .FirstOrDefault();
        }

        public override IEnumerable<Category> GetAll()
        {
            var result = Table
                        .Include(x => x.Children)
                        .OrderBy(x => x.Order)
                        .AsEnumerable();                    
            Sort(result);
            return result.Where(x=> x.Parent == null);
        }

        private IEnumerable<Category> Sort(IEnumerable<Category> categories)
        {
            categories = categories.OrderBy(x => x.Order);
            foreach(var category in categories)
            {
                if(category.Children != null)
                    category.Children = Sort(category.Children).ToList();
            }
            return categories;
        }
    }
}