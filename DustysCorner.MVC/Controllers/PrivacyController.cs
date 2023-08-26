using DustysCorner.Client;
using DustysCorner.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DustysCorner.MVC.Controllers
{
    public class PrivacyController : BaseController
    {
        public PrivacyController(IWebApiCalls webApiCalls) : base(webApiCalls)
        {
        }

        [Route("~/privacy")]
        public async Task<IActionResult> Index()
        {
            var model = await CreateBaseModel<PrivacyViewModel>();
            return View(model);
        }
    }
}