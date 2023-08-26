using DustysCorner.Client.Models;
using System.Threading.Tasks;

namespace DustysCorner.Client.Operations.Interfaces
{
    public interface ISocialMediaOperations
    {
        Task<SocialMediaModel> Get();
    }
}
