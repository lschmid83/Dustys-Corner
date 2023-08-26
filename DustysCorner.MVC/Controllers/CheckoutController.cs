using DustysCorner.Client;
using DustysCorner.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DustysCorner.MVC.Controllers
{
    public class CheckoutController : BaseController
    {
        public CheckoutController(IWebApiCalls webApiCalls) : base(webApiCalls)
        {
        }

        [Route("~/shop/checkout")]
        public async Task<IActionResult> Index()
        {
            var model = await CreateBaseModel<CheckoutViewModel>();
            return View(model);
        }
    }
}
