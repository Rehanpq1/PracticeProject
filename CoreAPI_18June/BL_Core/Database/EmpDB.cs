using BL_Core.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BL_Core.Database
{
    public class EmpDB
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmpDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public EmpDB()
        {
            conn.Open();
        }

        public List<Emp> GetDetail()
        {
            string command = "Select * from EMP";

           // GetDetailUsingEntity();
            var cmd = new SqlCommand(command);
            cmd.Connection = conn;
            SqlDataReader rdr = cmd.ExecuteReader();
            List<Emp> list = new List<Emp>();
            if (rdr.Read())
                //list = rdr.Cast<Emp>().Select(x => new Emp(x.Id, x.Name)).ToList();
                list = rdr.Cast<IDataRecord>().Select(x => new Emp { Id = (int)x["Id"], Name = (string)x["Name"] }).ToList();
            rdr.Close();
            cmd.Dispose();
            return list;
        }
        public static string GetEntityConnectionString(string connectionString)
        {
            var entityBuilder = new EntityConnectionStringBuilder();

            // WARNING
            // Check app config and set the appropriate DBModel
            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = connectionString + ";MultipleActiveResultSets=True;App=EntityFramework;";
            entityBuilder.Metadata = @"res://*/DBModel.CWDB.csdl|res://*/DBModel.CWDB.ssdl|res://*/DBModel.CWDB.msl";

            return entityBuilder.ToString();
        }

        public List<Emp> GetDetailUsingEntity()
        {
            List<Emp> list = new List<Emp>();
            string Conn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmpDB;";
            var objEmpManager = new EmpManager(GetEntityConnectionString(Conn));
            list = objEmpManager.GetEmps.ToList();

            return list;
        }

        public int InsertValues(int id, string name)
        {
            int i = 0;
            string cmdString;
            if (!GetDetail().Exists(x => x.Id == id))
                cmdString = "INSERT INTO EMP (ID,Name) VALUES (@ID, @Name)";
            else
                cmdString = "UPDATE EMP Set Name =@Name Where ID=@ID";

            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = cmdString;
                comm.Parameters.AddWithValue("@ID", id);
                comm.Parameters.AddWithValue("@Name", name);

                i = comm.ExecuteNonQuery();
            }
            return i;
        }

        public int DeleteValues(int id)
        {
            int i = 0;
            string cmdString;
            if (GetDetail().Exists(x => x.Id == id))
            {
                cmdString = "Delete from EMP where ID=@ID";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = cmdString;
                    comm.Parameters.AddWithValue("@ID", id);

                    i = comm.ExecuteNonQuery();
                }
             }
            return i;
        }
    }
}
