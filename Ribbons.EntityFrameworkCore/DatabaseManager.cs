using System.Threading.Tasks;

namespace Ribbons.EntityFrameworkCore
{
    public abstract class DatabaseManager<TDatabase> : IDatabaseManager<TDatabase> where TDatabase : Database
    {
        public TDatabase GetDatabase(string configurationName = null)
        {
            return CreateInstance(GetConfiguration(configurationName));
        }

        public async Task<TDatabase> GetDatabaseAsync(string configurationName = null)
        {
            return CreateInstance(await GetConfigurationAsync(configurationName));
        }

        protected abstract DatabaseConfig GetConfiguration(string configurationName = null);
        protected abstract Task<DatabaseConfig> GetConfigurationAsync(string configurationName = null);
        protected abstract TDatabase CreateInstance(DatabaseConfig configuration);
    }
}