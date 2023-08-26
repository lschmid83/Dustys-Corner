using DustysCorner.Client.Models;
using DustysCorner.Client.Operations.Interfaces;
using System.Threading.Tasks;

namespace DustysCorner.Client.Operations
{
    public class EventOperations : ClientBase, IEventOperations
    {
        public EventOperations(ApiSettings apiSettings) : base(apiSettings)
        {
        }

        public async Task<EventModel> Get()
        {
            return await GetRequest<EventModel>("/event");
        }
    }
}
