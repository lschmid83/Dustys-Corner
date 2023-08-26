using DustysCorner.Client;
using DustysCorner.MVC.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DustysCorner.MVC.Controllers
{
    [Route("error")]
    public class ErrorController : BaseController
    {
        public ErrorController(IWebApiCalls webApiCalls) : base(webApiCalls)
        {
        }

        [Route("500")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> AppError()
        {
            var model = await CreateBaseModel<ErrorViewModel>();
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            model.Path = exceptionHandlerPathFeature.Path;
            model.Error = exceptionHandlerPathFeature.Error.Message;
            model.RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View(model);
        }

        [Route("404")]
        public async Task<IActionResult> PageNotFound()
        {
            var model = await CreateBaseModel<ErrorViewModel>();
            return View(model);
        }

    }
}
