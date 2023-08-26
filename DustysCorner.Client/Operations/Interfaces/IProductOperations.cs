using DustysCorner.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DustysCorner.Client.Operations.Interfaces
{
    public interface IProductOperations
    {
        Task<IEnumerable<ProductModel>> GetAll();
        Task<IEnumerable<ProductModel>> Get(int categoryId);
        Task<IEnumerable<FeaturedProductModel>> GetFeatured();
    }
}
