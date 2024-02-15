using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    public sealed class DbConnectionProvider
    {
        private readonly string _connectionString;

        public DbConnectionProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}
