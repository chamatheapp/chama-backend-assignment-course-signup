using System.Threading;
using System.Threading.Tasks;

namespace Chama.EntityFramework.Interfaces
{
    public interface IDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}