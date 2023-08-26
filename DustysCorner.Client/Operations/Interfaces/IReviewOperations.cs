using DustysCorner.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DustysCorner.Client.Operations.Interfaces
{
    public interface IReviewOperations
    {
        Task<IEnumerable<ReviewModel>> GetAll();
    }
}
