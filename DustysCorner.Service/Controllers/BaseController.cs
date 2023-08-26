using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DustysCorner.Service.Controllers
{
    public abstract class BaseController : Controller
    {
        public IEnumerable<TDest> MapCollection<TSource, TDest>(IEnumerable<TSource> source)
        {
            var mapper = CreateMapper<TSource, TDest>();
            return mapper.Map<IEnumerable<TSource>, IEnumerable<TDest>>(source);
        }

        public TDest MapObject<TSource, TDest>(TSource source)
        {
            var mapper = CreateMapper<TSource, TDest>();
            return mapper.Map<TSource, TDest>(source);
        }

        private IMapper CreateMapper<TSource, TDest>()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TSource, TDest>();
            });
            return config.CreateMapper();
        }
    }
}
