using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore.Models
{
    internal class Student
    {
            public int StudentId { get; set; }

            [MaxLength(100)]
            public string? Name { get; set; }

            [StringLength(10)]
            [Unicode(false)]
            public string? PhoneNumber { get; set; }

            public DateTime RegisteredOn { get; set; }
            public DateTime? Birthday { get; set; }

            public ICollection<Homework> Homeworks { get; set; } = new HashSet<Homework>();
            public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
        }
    }
