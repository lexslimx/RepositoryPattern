using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.App
{
    public class StudentEnroller
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentEnroller(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void EnrollStudent(Student student)
        {
            _unitOfWork.Students.AddItem(student);
        }
    }
}
