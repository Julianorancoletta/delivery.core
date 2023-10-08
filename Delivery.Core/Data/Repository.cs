using Microsoft.EntityFrameworkCore;

namespace Delivery.Core.Data
{
    public abstract class BaseRepository<T, TContext> where TContext : DbContext
    {
    }
}
