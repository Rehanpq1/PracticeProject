using BL_Core.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BL_Core.Database
{
    public class StudentDB
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmpDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public StudentDB()
        {
            conn.Open();
           IHpptHandler 
        }

        public List<Student> GetDetail()
        {
            string command = "Select * from Student";


            var cmd = new SqlCommand(command);
            cmd.Connection = conn;
            SqlDataReader rdr = cmd.ExecuteReader();
            List<Student> list = new List<Student>();
            if (rdr.Read())
                //list = rdr.Cast<Emp>().Select(x => new Emp(x.Id, x.FoodName)).ToList();
                list = rdr.Cast<IDataRecord>().Select(x => new Student { Id = (int)x["Id"], Name = (string)x["Name"], RollNo =(int)x["RollNo"]}).ToList();
            rdr.Close();
            cmd.Dispose();
            return list;
        }

        public int InsertValues(int id, string name, int Rollno)
        {
            int i = 0;
            string cmdString;
            if (!GetDetail().Exists(x => x.Id == id))
                cmdString = "INSERT INTO Student (Name, Rollno) VALUES (@Name, @Rollno)";
            else
                cmdString = "UPDATE Student Set Name =@Name, Rollno=@Rollno Where ID=@ID";

            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = cmdString;
                comm.Parameters.AddWithValue("@ID", id);
                comm.Parameters.AddWithValue("@Name", name);
                comm.Parameters.AddWithValue("@Rollno", Rollno);

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
                cmdString = "Delete from Student where ID=@ID";
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
