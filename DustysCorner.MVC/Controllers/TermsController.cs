using DustysCorner.Client;
using DustysCorner.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DustysCorner.MVC.Controllers
{
    public class TermsController : BaseController
    {
        public TermsController(IWebApiCalls webApiCalls) : base(webApiCalls)
        {
        }

        [Route("~/terms")]
        public async Task<IActionResult> Index()
        {
            var model = await CreateBaseModel<TermsViewModel>();
            return View(model);
        }
    }
}