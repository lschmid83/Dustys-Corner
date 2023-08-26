using DustysCorner.Client.Models;
using DustysCorner.DAL.Entities;
using DustysCorner.DAL.Repos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DustysCorner.Service.Controllers
{
    [Route("[controller]")]
    public class EventController : BaseController
    {
        private readonly IEventRepo eventRepo;

        public EventController(IEventRepo eventRepo)
        {
            this.eventRepo = eventRepo;
        }

        [HttpGet]
        public EventModel Get()
        {
            return MapObject<Event, EventModel>(eventRepo.GetFirst());
        }
    }
}