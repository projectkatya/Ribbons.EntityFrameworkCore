using Microsoft.EntityFrameworkCore;
using System;

namespace Ribbons.EntityFrameworkCore
{
    public abstract class Database : DbContext
    {
        protected DatabaseProvider Provider { get; set; }

        protected Database(DatabaseProvider provider)
        {
            Provider = provider;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();

            switch (Provider)
            {
                case DatabaseProvider.MsSql:
                    optionsBuilder.UseSqlServer();
                    break;
                case DatabaseProvider.MySql:
                    optionsBuilder.UseMySQL();
                    break;
                case DatabaseProvider.Npgsql:
                    optionsBuilder.UseNpgsql();
                    break;
                case DatabaseProvider.Oracle:
                    optionsBuilder.UseOracle();
                    break;
                case DatabaseProvider.Sqlite:
                    optionsBuilder.UseSqlite();
                    break;
                default:
                    throw new NotSupportedException();
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}