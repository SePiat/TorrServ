using System;
using System.Collections.Generic;
using System.Text;
using TorrServData.Models;

namespace TorrServCore
{
    public interface IMoviesGetterService<T> where T: class
    {
        IEnumerable<T> GetMovies();
    }
}
