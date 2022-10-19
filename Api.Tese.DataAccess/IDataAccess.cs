using Api.Tese.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Tese.DataAccess
{
    public interface IDataAccess
    {

        Task<List<Student>>  GetStudents();


        Task<Student> GetStudent(int id);


        Task<int> DeleteStudent(int id);
        Task<int> Test();

       
    }
}
