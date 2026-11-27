using System;
using System.Collections.Generic;
using System.Text;

namespace VAP_NetCoreApp.Models.Queries
{
    public class DataBase
    {
        public Users Users { get; set; }
        public Roles Roles { get; set; }

        public DataBase()
        {
            Users = new Users();
            Roles = new Roles();
        }
    }
}
