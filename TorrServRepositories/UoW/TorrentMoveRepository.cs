using TorrServ.Data;
using TorrServData.Models;

namespace TorrServRepositories.UoW
{
    public class TorrentMoveRepository : Repository<TorrentMovie>
    {
        public TorrentMoveRepository(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}
