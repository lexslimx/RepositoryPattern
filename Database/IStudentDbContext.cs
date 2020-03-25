using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;

namespace RepositoryPattern.Database
{
    public interface IStudentDbContext
    {
        DbSet<Student> Students { get; set; }
        int SaveChanges();
        void Dispose();
    }
}