using DustysCorner.DAL.Entities;
using DustysCorner.DAL.Repos.Base;
using System.Collections.Generic;

namespace DustysCorner.DAL.Repos.Interfaces
{
    public interface IGalleryRepo : IRepo<Gallery>
    {
        IEnumerable<Gallery> Get(int categoryId);
    }
}
