using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Models
{
    public class Student
    {
        public Student()
        {
            Subjects = new HashSet<Subject>();
        }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
