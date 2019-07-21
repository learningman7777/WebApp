using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Data.Repositories
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAllTeachers();
        Teacher GetTeacher(int id);
    }
}