using DustysCorner.Client.Models;
using DustysCorner.DAL.Entities;
using DustysCorner.DAL.Repos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DustysCorner.Service.Controllers
{
    [Route("[controller]")]
    public class ReviewController : BaseController
    {
        private readonly IReviewRepo reviewRepo;

        public ReviewController(IReviewRepo reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(MapCollection<Review, ReviewModel>(reviewRepo.GetAll()));
        }
    }
}
