using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMovieSystem.Entity.ViewModel
{
    public class PluginViewModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }

        public string CreateTime { get; set; }

        public string CreateBy { get; set; }
    }
}
