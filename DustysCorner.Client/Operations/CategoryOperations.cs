using DustysCorner.Client.Models;
using DustysCorner.Client.Operations.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DustysCorner.Client.Operations
{
    public class CategoryOperations : ClientBase, ICategoryOperations
    {
        public CategoryOperations(ApiSettings apiSettings) : base(apiSettings)
        {
        }

        public async Task<CategoryModel> Get(int id)
        {
            return await GetRequest<CategoryModel>("/category/" + id);
        }

        public async Task<IEnumerable<CategoryModel>> GetAll()
        {
            return await GetRequest<IEnumerable<CategoryModel>>("/category");
        }
    }
}
