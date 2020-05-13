using RepositoryPattern;
using RepositoryPattern.Database;
using RepositoryPattern.Models;

public class UnitOfWork : IUnitOfWork
{    
    private readonly IStudentDbContext _context;    
    public UnitOfWork(IStudentDbContext studentDbContext)
    {
        _context = studentDbContext;        
        Students = new StudentRepository(_context);
        Subjects = new SubjectRepository(_context);
    }
    public IStudentRepository Students { get; set;}
    public ISubjectRepository Subjects { get; set; }

    public void Complete()
    {
       _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}