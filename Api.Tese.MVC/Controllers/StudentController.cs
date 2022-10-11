using Api.Tese.Entities;
using Api.Tese.MVC.BusinessLogic;
using Api.Tese.MVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace Api.Tese.MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentBL studentBL;


        public StudentController()
        {
            studentBL = new StudentBL();
        }
        public async Task<IActionResult> Index(string nameStudent)
        {

            if(nameStudent == null)
            {
                ViewBag.listStudents = await studentBL.GetStudents();

            }else
            {

                ViewBag.listStudents = await GetStudentsByName(nameStudent);

            }

            ViewBag.TestMessage = "A continuación se muestra el listado de los estudiantes en el curso";

           



            return View();
        }



        public async Task<List<Student>> GetStudentsByName(string Name)
        {
            List<Student> list = await studentBL.GetStudents();

            List<Student> listResult = new List<Student>();


            listResult = (from student in list
                          where student.Name.Contains( Name)
                          select new Student
                          {
                              Id = student.Id,
                              Name = student.Name,
                              LastName = student.LastName,
                              Age = student.Age,
                          }).ToList();

            return listResult;

        }




     
    }
}
