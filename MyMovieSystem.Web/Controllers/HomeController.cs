using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyMovieSystem.Entity;
using MyMovieSystem.Plugin;
using MyMovieSystem.Plugin.Hooks;
using MyMovieSystem.Service;
using MyMovieSystem.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyMovieSystem.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
         
        private ITitleHook _titleHook;
        public HomeController(ILogger<HomeController> logger )
        {
            _logger = logger; 
        }

        public IActionResult Index()
        {
            Post post = new Post();
            post.ID = 1;
            post.Title = "我是标题";
            post.Content = "<p>我是内容。</p>";
            post.CreateTime = DateTime.Parse("2022-02-22 12:12:11");
            _titleHook = EngineContext.Current.GetService<ITitleHook>();  
            if (_titleHook!=null)
            {
                post.Title = _titleHook.HookTitle(post.Title);
            }
            return View(post);
        }

      

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
