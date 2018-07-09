using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BL_Core.Controllers
{
    [Table("EMP")]
    public class Emp
    {
        [StringLength(4)]
        public int Id { get; set; }
        public string Name { get; set; }
        public Emp()
        {

        }
        public Emp(int id, string foodName)
        {
            this.Id = id;
            this.Name = foodName;
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RollNo { get; set; }
    }
}
