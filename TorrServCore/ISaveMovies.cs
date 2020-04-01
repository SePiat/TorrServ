using System.Threading.Tasks;

namespace TorrServCore
{
    public interface ISaveMovies
    {
        Task<bool> SaveMov();
    }
}