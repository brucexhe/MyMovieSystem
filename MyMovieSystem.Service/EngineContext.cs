using MyMovieSystem.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieSystem.Service
{
    public class EngineContext
    {
        private static IEngine _engine; 

        public static IEngine Initialize(IEngine engine)
        {
            if (_engine == null)
                _engine = engine;
            return _engine;
        }
        public static IEngine Current
        {
            get
            {

                return _engine;
            }
        }
    }
}
