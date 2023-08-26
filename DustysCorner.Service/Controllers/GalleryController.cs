using DustysCorner.Client.Models;
using DustysCorner.DAL.Entities;
using DustysCorner.DAL.Repos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DustysCorner.Service.Controllers
{
    [Route("[controller]")]
    public class GalleryController : BaseController
    {
        private readonly IGalleryRepo galleryRepo;

        public GalleryController(IGalleryRepo galleryRepo)
        {
            this.galleryRepo = galleryRepo;
        }

        [HttpGet]
        [Route("/[controller]/{categoryId}")]
        public IActionResult Get(int categoryId)
        {
            return Ok(MapCollection<Gallery, GalleryModel>(galleryRepo.Get(categoryId)));
        }
    }
}
