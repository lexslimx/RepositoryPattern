using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern
{
    public interface IStudentRepository : IRepository<Student>
    {
        void AddStudent();
        Student GetOneStudent();
        List<Student> GetAllStudents();
    }
}
