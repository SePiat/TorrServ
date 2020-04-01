using System;
using System.Collections.Generic;
using System.Text;
using TorrServData.Models;

namespace TorrServCore
{
    public interface ICommetsGetter<T> where T : class
    {
        IEnumerable<T> GetComments(TorrentMovie movie);
    }
}
