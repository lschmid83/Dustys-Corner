using DustysCorner.DAL;
using DustysCorner.DAL.Entities;
using DustysCorner.DAL.Repos.Base;
using DustysCorner.DAL.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DustysCorner.DAL.Repos
{
    public class SocialMediaRepo : RepoBase<SocialMedia>, ISocialMediaRepo
    {
        public SocialMediaRepo(DbContextOptions<StoreContext> options)
        : base(options)
        {
        }
        public SocialMediaRepo()
        {
        }
    }
}
