using Api.Tese.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Api.Tese.DataAccess.DataAccess.Mock
{
    public class MockDataAccess : IDataAccess
    {
        public async Task<Student> GetStudent(int id)
        {
            List<Subject> list = new List<Subject>()
            {
                new Subject()
                {
                    Id = 1,
                    Name = "Topicos",
                    Credits = 40
                },
                new Subject()
                {
                    Id = 2,
                    Name = "Programacion web",
                    Credits = 45
                }

            };



           Student student = new Student();


            student.Id = 1;
            student.Address = "Valle del Duero 194";
            student.Semester = 7;
            student.ListSubjects = list;
            student.Age = 25;
            student.Name = "Juan";
            student.LastName = "Perez";



            return student;
        }

        public async  Task<List<Student>> GetStudents()
        {
            List<Student> list = new List<Student>();


            list.Add(new Student()
            {
                Id = 1,
                Age = 25,
                Name = "Juan",
                LastName = "Perez"
            });

            list.Add(new Student()
            {
                Id = 2,
                Age = 25,
                Name = "Juan",
                LastName = "Perez"
            });
            list.Add(new Student()
            {
                Id = 3,
                Age = 26,
                Name = "Luis",
                LastName = "Saltillo"
            });
            list.Add(new Student()
            {
                Id = 1,
                Age = 27,
                Name = "Pedro",
                LastName = "Muñoz"
            });


            return   list;

        }

        public Task<int> Test()
        {
            throw new NotImplementedException();
        }

     


    }
}
