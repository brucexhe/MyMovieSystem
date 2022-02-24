using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace MyMovieSystem.Service
{
    public class Engine : Interfaces.IEngine
    {
        private IServiceCollection _service; 
        public Engine(IServiceCollection  service)
        {
            this._service = service;
        }
        public T GetService<T>() where T : class
        {
            var service = _service.BuildServiceProvider().GetService<T>();
            return service;
        }
        public IEnumerable<T> GetServices<T>() where T : class
        {
            var services = _service.BuildServiceProvider().GetServices<T>();
            return services;
        }
        public object GetService(Type type)
        {
            var service = _service.BuildServiceProvider().GetService(type);
            return service;
        }
    }
}
