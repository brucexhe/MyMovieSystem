using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMovieSystem.Web.Controllers
{
    public class BaseController : Controller
    {
        public T GetService<T>() where T : class
        {
            var serviceProvidersFeature = HttpContext.Features.Get<IServiceProvidersFeature>();
            var services = serviceProvidersFeature.RequestServices;
            var service = (IServiceProvider)services.GetService(typeof(IServiceProvider));
            return (T)service.GetService(typeof(T));
        }
    }
}
