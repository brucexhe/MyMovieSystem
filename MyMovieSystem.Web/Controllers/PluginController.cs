using Microsoft.AspNetCore.Mvc;
using MyMovieSystem.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MyMovieSystem.Plugin.Hooks;
using MyMovieSystem.Service.Interfaces;
using MyMovieSystem.Entity.Entity;
namespace MyMovieSystem.Web.Controllers
{
    public class PluginController : Controller
    {
        IPluginService IPluginService;
        public PluginController(IPluginService _IPluginService)
        {
            IPluginService = _IPluginService;
        }
        public IActionResult List()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + "Plugins//";
            var files = System.IO.Directory.GetFiles(path);
            var PluginList = new List<Entity.Entity.Plugin>();
            foreach (var file in files)
            {
                Assembly assembly = Assembly.Load(System.IO.File.ReadAllBytes(file));

                var types = assembly.GetTypes();
                foreach (var type in types)
                {
                    if (type.GetInterface("IPlugin") != null)
                    {
                        var plugin = (IPlugin)type.InvokeMember("Info", BindingFlags.CreateInstance, null, null, null);

                        PluginList.Add(plugin.Info);
                    }
                }

            }

            return View(PluginList);
        }

        public JsonResult Enable(string id)
        {
            var plugin = new Entity.Entity.Plugin() { ID = id };
            IPluginService.Install(plugin);
            return new JsonResult(new { data = true, succes = true });
        }
        [HttpPost]
        public IActionResult Install2(Entity.Entity.Plugin model)
        {
            model = IPluginService.Install(model);

            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
