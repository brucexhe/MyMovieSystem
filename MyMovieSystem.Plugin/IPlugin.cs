using System;

namespace MyMovieSystem.Plugin
{
    public interface IPlugin
    {
        MyMovieSystem.Entity.Entity.Plugin Info { get; }
        void Install();
        void Unistall();
        void Enable();
        void Disable();
    }
}
