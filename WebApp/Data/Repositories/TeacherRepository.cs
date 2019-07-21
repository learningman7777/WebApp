using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Data.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly WebAppContext _context;

        public TeacherRepository(WebAppContext context)
        {
            _context = context;
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            var result = _context.Teachers.ToList();
            return result;
        }

        public Teacher GetTeacher(int id)
        {
            var result = _context.Teachers.Find(id);

            return result;
        }
    }
}
