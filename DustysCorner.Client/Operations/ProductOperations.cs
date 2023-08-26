using DustysCorner.Client.Models;
using DustysCorner.Client.Operations.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DustysCorner.Client.Operations
{
    public class ProductOperations : ClientBase, IProductOperations
    {
        public ProductOperations(ApiSettings apiSettings) : base(apiSettings)
        {
        }

        public async Task<IEnumerable<ProductModel>> GetAll()
        {
            return await GetRequest<IEnumerable<ProductModel>>("/product");
        }

        public async Task<IEnumerable<ProductModel>> Get(int categoryId)
        {
            return await GetRequest<IEnumerable<ProductModel>>("/product/" + categoryId);
        }

        public async Task<IEnumerable<FeaturedProductModel>> GetFeatured()
        {
            return await GetRequest<IEnumerable<FeaturedProductModel>>("/product/featured");
        }

    }
}