using Microsoft.AspNetCore.Mvc;
using DustysCorner.Client.Models;
using System.Collections.Generic;
using AutoMapper;
using DustysCorner.DAL.Repos.Interfaces;
using DustysCorner.DAL.Entities;

namespace DustysCorner.Service.Controllers
{
    [Route("[controller]")]
    public class ProductController : BaseController
    {
        private readonly IProductRepo productRepo;
        private readonly IFeaturedProductRepo featuredProductRepo;

        public ProductController(IProductRepo productRepo, IFeaturedProductRepo featuredProductRepo)
        {
            this.productRepo = productRepo;
            this.featuredProductRepo = featuredProductRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(MapCollection<Product, ProductModel>(productRepo.GetAll()));
        }

        [HttpGet]
        [Route("/[controller]/{categoryId}")]
        public IActionResult Get(int categoryId)
        {
            return Ok(MapCollection<Product, ProductModel>(productRepo.GetCategory(categoryId)));
        }

        [HttpGet]
        [Route("/[controller]/featured")]
        public IActionResult GetFeatured()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Product, ProductModel>();
                cfg.CreateMap<FeaturedProduct, FeaturedProductModel>();
            });
            var configMapper = config.CreateMapper();
            return Ok(configMapper.Map<IEnumerable<FeaturedProduct>, IEnumerable<FeaturedProductModel>>(featuredProductRepo.GetAll()));
        }
    }
}
