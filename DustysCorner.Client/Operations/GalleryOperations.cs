using DustysCorner.Client.Models;
using DustysCorner.Client.Operations.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DustysCorner.Client.Operations
{
    public class GalleryOperations : ClientBase, IGalleryOperations
    {
        public GalleryOperations(ApiSettings apiSettings) : base(apiSettings)
        {
        }

        public async Task<IEnumerable<GalleryModel>> Get(int categoryId)
        {
            return await GetRequest<IEnumerable<GalleryModel>>("/gallery/" + categoryId);
        }
    }
}
