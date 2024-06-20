using Microsoft.Extensions.DependencyInjection;
using MyMovieSystem.Plugin;
using MyMovieSystem.Plugin.Hooks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieSystem.Service
{
    public class PluginService : Interfaces.IPluginService
    {
        IServiceCollection service;
        public PluginService(IServiceCollection _service)
        {
            this.service = _service;
        }

        public Entity.Entity.Plugin Install(Entity.Entity.Plugin plugin)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + "Plugins//" + plugin.ID + ".dll";
            var assemblyList = new List<Assembly>();

            Assembly assembly = Assembly.Load(File.ReadAllBytes(path));

            var plugins = EngineContext.Current.GetServices<IPlugin>();
            foreach (var type in assembly.GetTypes())
            {
                if (type.GetInterface("IPlugin") != null && !plugins.Any(f => f.GetType().FullName == type.FullName))
                {
                    service.AddSingleton(typeof(IPlugin), type);
                }
                if (type.GetInterface("ITitleHook") != null && !plugins.Any(f => f.GetType().FullName == type.FullName))
                {
                    service.AddSingleton(typeof(IPostHook), type);
                }

            }


            return plugin;

        }
    }
}
