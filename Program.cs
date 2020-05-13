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
            var student = unitOfWork.Students.AddItem(new Models.Student { Name = "Allan" });            
            var subject = unitOfWork.Subjects.AddItem(new Models.Subject { Name = "Math" });
            student.Subjects.Add(subject);
            unitOfWork.Complete();
            var students = unitOfWork.Students.GetAllStudents();
            foreach (var item in students)
            {
                Console.WriteLine($"Student: {item.Name}");
                foreach (var subjct in student.Subjects)
                {

                    Console.WriteLine($"Subject: {subjct.Name}");
                }
            }
            Console.WriteLine("Done");
        }
    }
}
