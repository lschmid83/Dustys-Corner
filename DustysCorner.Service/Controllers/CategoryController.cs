using Microsoft.AspNetCore.Mvc;
using DustysCorner.Client.Models;
using DustysCorner.DAL.Repos.Interfaces;
using DustysCorner.DAL.Entities;
using System.Collections.Generic;

namespace DustysCorner.Service.Controllers
{
    [Route("[controller]")]
    public class CategoryController : BaseController
    {
        private readonly ICategoryRepo categoryRepo;

        public CategoryController(ICategoryRepo categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        [HttpGet]
        [Route("/[controller]/{id}")]
        public CategoryModel Get(int id)
        {
            return MapObject<Category, CategoryModel>(categoryRepo.Get(id));
        }

        [HttpGet]
        public IEnumerable<CategoryModel> Get()
        {
            return MapCollection<Category, CategoryModel>(categoryRepo.GetAll());
        }
    }
}
