using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
