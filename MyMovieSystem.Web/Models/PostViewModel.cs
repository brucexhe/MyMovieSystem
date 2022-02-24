using MyMovieSystem.Plugin.Hooks;
using MyMovieSystem.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMovieSystem.Web.Models
{
    public class PostViewModel
    {
        private ITitleHook _titleHook;
        public PostViewModel()
        {
            _titleHook = EngineContext.Current.GetService<ITitleHook>();

        }
        public int ID { get; set; }
        private string _Title;
        public string Title
        {
            get
            {
                if (_titleHook != null)
                {
                    _Title = _titleHook.HookTitle(_Title);
                }
                return _Title;
            }
            set
            {
                _Title = value;
            }
        }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
