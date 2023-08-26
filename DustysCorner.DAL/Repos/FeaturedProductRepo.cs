using DustysCorner.DAL.Entities;
using DustysCorner.DAL.Repos.Base;
using DustysCorner.DAL.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DustysCorner.DAL.Repos
{
    public class FeaturedProductRepo : RepoBase<FeaturedProduct>, IFeaturedProductRepo
    {
        public FeaturedProductRepo(DbContextOptions<StoreContext> options)
        : base(options)
        {
        }
        public FeaturedProductRepo()
        {
        }

        public override IEnumerable<FeaturedProduct> GetAll()
        {
            return Table
                    .Include(x => x.Product)
                    .Include(x => x.Product.Category)
                    .Include(x => x.Product.AdditionalImages)
                    .Include(x => x.Product.Options)
                    .OrderBy(x => x.Order);
        }

    }
}
