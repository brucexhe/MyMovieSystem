using MyMovieSystem.Plugin.Hooks;
using System;

namespace MyMovieSystem.Plugin.RedTitle
{
    public class RedTitlePlugin : IPlugin, ITitleHook
    {
        public Entity.Plugin Info
        {
            get
            {
                return new Entity.Plugin()
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

        public string HookTitle(string title)
        {
            return "<span style='color:red'>" + title + "</span>";
        }

        public void Install()
        {

        }

        public void Unistall()
        { 
        }
    }
}
