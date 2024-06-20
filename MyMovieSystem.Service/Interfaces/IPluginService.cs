using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieSystem.Service.Interfaces
{
    public interface IPluginService
    {
        Entity.Entity.Plugin Install(Entity.Entity.Plugin plugin);
    }
}
