using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearnTech.Core.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string MiddleName { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string LastName { get; set; }
        public int Department { get; set; }
        public Department Departments { get; set; }
    }

    public class Department
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Department name must be >=2 and <=30")]
        public string name { get; set; }
    }
}
