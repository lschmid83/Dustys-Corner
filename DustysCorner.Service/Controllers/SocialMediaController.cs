using DustysCorner.Client.Models;
using DustysCorner.DAL.Entities;
using DustysCorner.DAL.Repos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DustysCorner.Service.Controllers
{
    [Route("[controller]")]
    public class SocialMediaController : BaseController
    {
        private readonly ISocialMediaRepo socialMediaRepo;

        public SocialMediaController(ISocialMediaRepo socialMediaRepo)
        {
            this.socialMediaRepo = socialMediaRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(MapObject<SocialMedia, SocialMediaModel>(socialMediaRepo.GetFirst()));
        }
    }
}
