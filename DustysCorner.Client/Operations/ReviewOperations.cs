using DustysCorner.Client.Models;
using DustysCorner.Client.Operations.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DustysCorner.Client.Operations
{
    public class ReviewOperations : ClientBase, IReviewOperations
    {
        public ReviewOperations(ApiSettings apiSettings) : base(apiSettings)
        {
        }

        public async Task<IEnumerable<ReviewModel>> GetAll()
        {
            return await GetRequest<IEnumerable<ReviewModel>>("/review");
        }
    }
}
