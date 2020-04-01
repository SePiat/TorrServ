using System.Threading.Tasks;
using TorrServData.Models;

namespace TorrServCore
{
    public interface ISaveCommentsToDb
    {
        Task<bool> SaveCommens(TorrentMovie movie);
    }
}