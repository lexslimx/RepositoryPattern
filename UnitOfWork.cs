using RepositoryPattern;
using RepositoryPattern.Database;
using RepositoryPattern.Models;

public class UnitOfWork : IUnitOfWork
{
    private readonly IStudentRepository _studentRepository;
    private readonly IStudentDbContext _context;
    public UnitOfWork(IStudentDbContext studentDbContext)
    {
        _context = studentDbContext;
        _studentRepository = new StudentRepository(_context);
        Students = new StudentRepository(_context);
    }
    public IStudentRepository Students { get; set;}

    public void Complete()
    {
       _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}