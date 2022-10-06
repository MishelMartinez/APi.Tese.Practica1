using Api.Tese.Entities;

namespace Api.Tese.MVC.BusinessLogic
{
    public class StudentBL
    {
        private static HttpClient client;

        public StudentBL()
        {
            client = new HttpClient(); 
        }


        public async Task<List<Student>> GetStudents()
        {
            List < Student > students = new List<Student>();
            using (client = new HttpClient())
            {
                var result = await client.GetFromJsonAsync<List<Student>>("https://localhost:44326/api/Student/GetStudents");

                if(result!= null)
                {
                    students = result;
                }

               
            }

            return students;

        }
    }
}
