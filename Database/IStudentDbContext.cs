using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;

namespace RepositoryPattern.Database
{
    public interface IStudentDbContext
    {
        DbSet<Student> Students { get; set; }
        DbSet<Subject> Subjects { get; set; }
        int SaveChanges();
        void Dispose();
    }
}