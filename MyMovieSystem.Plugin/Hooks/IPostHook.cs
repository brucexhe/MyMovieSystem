using MyMovieSystem.Entity;
using MyMovieSystem.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieSystem.Plugin.Hooks
{
    public interface IPostHook
    {
        Post Hook(Post post);
    }
}
