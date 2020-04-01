using TorrServ.Data;
using TorrServData.Models;

namespace TorrServRepositories.UoW
{
    public class SourceOfMoviesRepository : Repository<SourceOfMovies>
    {
        public SourceOfMoviesRepository(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}


