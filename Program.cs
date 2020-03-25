using RepositoryPattern.Database;
using System;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentDbContext context = new StudentDbContext();
            var unitOfWork = new UnitOfWork(context);
            unitOfWork.Students.AddItem(new Models.Student { Name = "Allan" });
            unitOfWork.Complete();
            Console.WriteLine("Hello World!");
        }
    }
}
