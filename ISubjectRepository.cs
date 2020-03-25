using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern
{
    public interface ISubjectRepository : IRepository<Subject>
    {
        void AddSubject();
        Subject GetOneSubject();
        List<Subject> GetAllSubjects();
    }
}
