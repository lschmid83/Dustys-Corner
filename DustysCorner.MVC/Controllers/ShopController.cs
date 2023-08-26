using DustysCorner.Client;
using DustysCorner.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DustysCorner.MVC.Controllers
{
    public class ShopController : BaseController
    {
        private readonly IWebApiCalls webApiCalls;

        public ShopController(IWebApiCalls webApiCalls) : base(webApiCalls)
        {
            this.webApiCalls = webApiCalls;
        }

        [Route("~/shop/{category}")]
        public async Task<IActionResult> Index(int id)
        {
            var model = await CreateBaseModel<ShopViewModel>();
            try
            {
                model.Category = await webApiCalls.GetCategory().Get(id);
                model.Products = await webApiCalls.GetProduct().Get(id);
            }
            catch(Exception)
            {
                throw new Exception("Shop Category ID=" + id + " does not exist.");
            }
            return View(model);
        }

    }
}