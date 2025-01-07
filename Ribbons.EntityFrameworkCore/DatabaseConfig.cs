﻿namespace Ribbons.EntityFrameworkCore
{
    public sealed class DatabaseConfig
    {
        public DatabaseProvider Provider { get; set; }
        public string ConnectionString { get; set; }
    }
}