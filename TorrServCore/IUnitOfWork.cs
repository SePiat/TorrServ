using System;
using System.Threading.Tasks;
using TorrServCore;
using TorrServData.Models;

namespace TorrServCore
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TorrentMovie> torrentMove { get; }
        IGenericRepository<SourceOfMovies> sourceOfMovies { get; }
        IGenericRepository<Comments> comments { get; }
        void Save();
        Task SaveAsync();
    }
}
