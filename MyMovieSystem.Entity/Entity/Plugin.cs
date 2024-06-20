using System;

namespace MyMovieSystem.Entity.Entity
{
    public class Plugin
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }

        public string CreateTime { get; set; }

        public string CreateBy { get; set; }
        public bool Enabled { get; set; }
    }
}
