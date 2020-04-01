using TorrServ.Data;
using TorrServData.Models;

namespace TorrServRepositories.UoW
{
    public class CommentsRepository : Repository<Comments>
    {
        public CommentsRepository(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}