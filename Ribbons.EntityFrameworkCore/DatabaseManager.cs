using System;
using System.Threading.Tasks;

namespace Ribbons.EntityFrameworkCore
{
    public abstract class DatabaseManager<TDatabase> : IDatabaseManager<TDatabase> where TDatabase : Database
    {
        public TDatabase GetDatabase(string databaseName = null)
        {
            throw new NotImplementedException();
        }

        public Task<TDatabase> GetDatabaseAsync(string databaseName = null)
        {
            throw new NotImplementedException();
        }
    }
}