using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Student
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Range(15,70)]
        public int Age { get; set; }
        [Required, MinLength(5)]
        public int Country { get; set; }

    }
}
