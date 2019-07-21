using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Data.Repositories
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        Student GetStudent(int id);
        IEnumerable<Student> GetAllStudents();
        void Save();
        void Edit(Student student);
        void Delete(Student student);
    }
}