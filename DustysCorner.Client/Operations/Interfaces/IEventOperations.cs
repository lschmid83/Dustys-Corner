using DustysCorner.Client.Models;
using System.Threading.Tasks;

namespace DustysCorner.Client.Operations.Interfaces
{
    public interface IEventOperations
    {
        Task<EventModel> Get();
    }
}
