using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst_Example3.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public short NumberOfClass { get; set; }
        [Required]
        public string Department { get; set; }
        public decimal GradeAvg { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
