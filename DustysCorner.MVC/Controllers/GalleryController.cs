using DustysCorner.Client;
using DustysCorner.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DustysCorner.MVC.Controllers
{
    public class GalleryController : BaseController
    {
        private readonly IWebApiCalls webApiCalls;

        public GalleryController(IWebApiCalls webApiCalls) : base(webApiCalls)
        {
            this.webApiCalls = webApiCalls;
        }
        
        [Route("~/gallery/{category}")]
        public async Task<IActionResult> Index(int id)
        {
            var model = await CreateBaseModel<GalleryViewModel>();
            try
            {
                model.Category = await webApiCalls.GetCategory().Get(id);
                model.Gallery = await webApiCalls.GetGallery().Get(id);
            }
            catch(Exception)
            {
                throw new Exception("Gallery Category ID=" + id + " does not exist.");
            }
            return View(model);
        }
    }
}