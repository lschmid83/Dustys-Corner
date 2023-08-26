using DustysCorner.Client.Models;
using DustysCorner.Client.Operations.Interfaces;
using System.Threading.Tasks;

namespace DustysCorner.Client.Operations
{
    public class SocialMediaOperations : ClientBase, ISocialMediaOperations
    {
        public SocialMediaOperations(ApiSettings apiSettings) : base(apiSettings)
        {
        }

        public async Task<SocialMediaModel> Get()
        {
            return await GetRequest<SocialMediaModel>("/socialmedia");
        }
    }
}
