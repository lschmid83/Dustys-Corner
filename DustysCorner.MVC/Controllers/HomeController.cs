using DustysCorner.Client;
using DustysCorner.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;

namespace DustysCorner.MVC.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IWebApiCalls webApiCalls;

        public HomeController(IWebApiCalls webApiCalls) : base(webApiCalls)
        {
            this.webApiCalls = webApiCalls;
        }

        public async Task<IActionResult> Index()
        {
            var model = await CreateBaseModel<HomeViewModel>();
            var featuredProducts = await webApiCalls.GetProduct().GetFeatured();
            model.FeaturedProducts = featuredProducts.Where(x => x.Product != null).Select(x => x.Product);
            model.CustomerReviews = await webApiCalls.GetReview().GetAll();
            return View(model);
        }
    }
}
