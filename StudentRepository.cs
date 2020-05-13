using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Database;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepositoryPattern
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly new IStudentDbContext _context;
        public StudentRepository(IStudentDbContext context) : base(context as DbContext)
        {
            _context = context;
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetOneStudent()
        {
            return _context.Students.FirstOrDefault();
        }
    }
}
