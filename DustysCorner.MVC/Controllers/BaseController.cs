using DustysCorner.Client;
using DustysCorner.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DustysCorner.MVC.Controllers
{
    public class BaseController : Controller
    {
        private readonly IWebApiCalls webApiCalls;

        public BaseController(IWebApiCalls webApiCalls)
        {
            this.webApiCalls = webApiCalls;
        }

        public async Task<T> CreateBaseModel<T>() where T : BaseViewModel, new()
        {
            return new T
            {
                Categories = await webApiCalls.GetCategory().GetAll(),
                SocialMedia = await webApiCalls.GetSocialMedia().Get(),
                Event = await webApiCalls.GetEvent().Get()
            };
        }     
    }
}
