using DustysCorner.DAL;
using DustysCorner.DAL.Entities;
using DustysCorner.DAL.Repos.Base;
using DustysCorner.DAL.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DustysCorner.DAL.Repos
{
    public class ReviewRepo : RepoBase<Review>, IReviewRepo
    {
        public ReviewRepo(DbContextOptions<StoreContext> options)
        : base(options)
        {
        }
        public ReviewRepo()
        {
        }

        public override IEnumerable<Review> GetAll()
        {
            return Table.OrderBy(x => x.Name);
        }
    }
}
