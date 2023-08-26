using DustysCorner.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DustysCorner.Client.Operations.Interfaces
{
    public interface ICategoryOperations
    {
        Task<CategoryModel> Get(int id);
        Task<IEnumerable<CategoryModel>> GetAll();
    }
}