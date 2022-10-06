using Api.Tese.Entities;
using Api.Tese.MVC.BusinessLogic;
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
        public async Task<IActionResult> Index()
        {

            ViewBag.TestMessage = "A continuación se muestra el listado de los estudiantes en el curso";

            ViewBag.listStudents = await studentBL.GetStudents();



            return View();
        }


     
    }
}
