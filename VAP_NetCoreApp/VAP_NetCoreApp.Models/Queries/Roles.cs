using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace VAP_NetCoreApp.Models.Queries
{
    public class Roles : BaseQuery
    {
        public Roles() : base() { }


        public List<VAP_NetCoreApp.Models.Role> GetAll()
        {
            
            using (var db = GetConnection())
            {
                return db.Query<VAP_NetCoreApp.Models.Role>(@"SELECT * FROM [Role]").ToList();
            }
         
        }

    }
}
