using System.Threading.Tasks;

namespace Ribbons.EntityFrameworkCore
{
    public interface IDatabaseManager<TDatabase> where TDatabase : Database
    {
        TDatabase GetDatabase(string databaseName = null);
        Task<TDatabase> GetDatabaseAsync(string databaseName = null);
    }
}