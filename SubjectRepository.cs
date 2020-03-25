using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Database;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RepositoryPattern
{
    public class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        private readonly new IStudentDbContext _context;
        public SubjectRepository(IStudentDbContext context) : base(context as DbContext)
        {
            _context = context;
        }
        public void AddSubject()
        {
            throw new NotImplementedException();
        }

        public List<Subject> GetAllSubjects()
        {
            throw new NotImplementedException();
        }

        public Subject GetOneSubject()
        {
            throw new NotImplementedException();
        }
    }
}
