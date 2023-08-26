using DustysCorner.DAL.Entities;
using DustysCorner.DAL.Repos.Base;

namespace DustysCorner.DAL.Repos.Interfaces
{
    public interface ICategoryRepo : IRepo<Category>
    {
        Category Get(int id);
    }
}