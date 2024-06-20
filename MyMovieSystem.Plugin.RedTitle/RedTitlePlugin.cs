using MyMovieSystem.Entity;
using MyMovieSystem.Entity.Entity;
using MyMovieSystem.Plugin.Hooks;
using System;

namespace MyMovieSystem.Plugin.RedTitle
{
    public class RedTitlePlugin : IPlugin, IPostHook
    {
        public Entity.Entity.Plugin Info
        {
            get
            {
                return new Entity.Entity.Plugin()
                {
                    ID = "MyMovieSystem.Plugin.RedTitle",
                    Name = "RedTitle",
                    Description = "标题红名",
                    Version = "1.0.0",
                    CreateBy = "MyMovieSystem",
                    CreateTime = "2022-02-23",
                    Enabled = false
                };
            }
        }

        public void Disable()
        {
            Info.Enabled = false;
        }

        public void Enable()
        {
            Info.Enabled = true;
        }

        public Post Hook(Post post)
        {
            post.Title =  "<span style='color:red'>" + post.Title + "</span>";

            return post;
        }

        public void Install()
        {

        }

        public void Unistall()
        { 
        }
    }
}
