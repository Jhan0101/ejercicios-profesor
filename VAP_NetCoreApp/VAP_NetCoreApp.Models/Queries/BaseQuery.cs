using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace VAP_NetCoreApp.Models.Queries
{
    public class BaseQuery
    {
        /// <summary>
        /// Guarda la cadena de conexion internamente con las llamadas a DB
        /// </summary>
        internal string _connectionString;

        /// <summary>
        /// Constructor
        /// </summary>
        public BaseQuery()
        {
            _connectionString = Environment.GetEnvironmentVariable("VAP_Demo_ConStr");
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public class BaseResult
        {
            public bool Success { get; set; }
            public string Message { get; set; }
            public int ObjectID { get; set; }
        }
    }
      
}
