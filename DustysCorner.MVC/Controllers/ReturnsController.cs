using DustysCorner.Client;
using DustysCorner.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DustysCorner.MVC.Controllers
{
    public class ReturnsController : BaseController
    {
        public ReturnsController(IWebApiCalls webApiCalls) : base(webApiCalls)
        {
        }

        [Route("~/returns")]
        public async Task<IActionResult> Index()
        {
            var model = await CreateBaseModel<ReturnsViewModel>();
            return View(model);
        }
    }
}