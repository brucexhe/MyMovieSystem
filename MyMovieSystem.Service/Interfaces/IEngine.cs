using System;
using System.Collections.Generic;

namespace MyMovieSystem.Service.Interfaces
{
    public interface IEngine
    {
        T GetService<T>() where T : class;
        IEnumerable<T> GetServices<T>() where T : class;
        object GetService(Type type);
    }
}
