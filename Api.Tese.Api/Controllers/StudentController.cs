using Api.Tese.BusinessLogic.Students;
using Api.Tese.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Tese.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentBL studentBL;
        public StudentController()
        {
            studentBL =  new StudentBL();
        }


        [HttpGet()]
        [Route("GetStudents")]

        public async Task<List<Student>> GetStudents()
        {
            List<Student> list = new List<Student>();
            try
            {
               list = await studentBL.GetStudents();

                

            }
            catch(Exception ex)
            {

            }

            return list;

        }

        [HttpPost()]

        [Route("StudentById")]

        public async Task<Student> GetStudentById(int Id)
        {
           return  await studentBL.GetStudentById(Id);
        }



        [HttpDelete()]
        [Route("DeleteStudent")]

        public async Task<int> DeleteStudent(int Id)
        {
            return await studentBL.DeleteStudent(Id);
        }

       




    }
}
