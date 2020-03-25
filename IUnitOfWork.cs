//Expose various repositories based on the entities in the application
using RepositoryPattern;
using System;

public interface IUnitOfWork : IDisposable
{
    IStudentRepository Students { get; }
    void Complete(); //Completion of a unit of work can also be called savel
}