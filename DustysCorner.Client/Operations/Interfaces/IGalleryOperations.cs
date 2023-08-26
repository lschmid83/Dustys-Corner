using DustysCorner.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DustysCorner.Client.Operations.Interfaces
{
    public interface IGalleryOperations
    {
        Task<IEnumerable<GalleryModel>> Get(int categoryId);
    }
}
