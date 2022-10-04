using Api.Tese.DataAccess;
using Api.Tese.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Tese.BusinessLogic.Students
{
    public class StudentBL
    {

        public async Task<List<Student>> GetStudents()
        {
            return await App.DataAccess.GetStudents();
        }


        public async Task<Student> GetStudentById(int id)
        {
            return await App.DataAccess.GetStudent(id);
        }

    }
}
