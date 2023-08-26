using DustysCorner.DAL;
using DustysCorner.DAL.Entities;
using DustysCorner.DAL.Repos.Base;
using DustysCorner.DAL.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DustysCorner.DAL.Repos
{
    public class GalleryRepo : RepoBase<Gallery>, IGalleryRepo
    {
        public GalleryRepo(DbContextOptions<StoreContext> options)
        : base(options)
        {
        }
        public GalleryRepo()
        {
        }

        public override IEnumerable<Gallery> GetAll()
        {
            var galleries = Table
                .Include(x=> x.Category)
                .Include(x => x.AdditionalImages)
                .OrderBy(x => x.Id);
            return SortImages(galleries);
        }

        public IEnumerable<Gallery> Get(int categoryId)
        {
            var galleries = Table
                .Include(x=> x.Category)
                .Include(x => x.AdditionalImages)
                .Where(x => x.Category.Id == categoryId)
                .OrderBy(x => x.Order);
            return SortImages(galleries);
        }

        private IEnumerable<Gallery> SortImages(IEnumerable<Gallery> galleries)
        {
            foreach (var gallery in galleries)
            {
                gallery.AdditionalImages = gallery.AdditionalImages.OrderBy(x => x.Order).ToList();
            }
            return galleries;
        }
    }
}
