using BL_Core.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Text;

namespace BL_Core.Database
{
    public class EmpManager : DbContext
    {
        public EmpManager(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<Emp> GetEmps { get; set; }
        
    }
}
