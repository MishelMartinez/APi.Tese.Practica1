using Api.Tese.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Tese.DataAccess.DataAccess.SqlServer
{
    public class SqlServerDataAccess : IDataAccess
    {

        private readonly string _connectionString;


        public SqlServerDataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> DeleteStudent(int id)
        {
            int value = 0;
            try
            {
               
               
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.Connection = con;
                        cmd.Connection.Open();
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.CommandText = $"delete from Student where IdStudent = {id}";
                        value = await  cmd.ExecuteNonQueryAsync();

                       
                    }

                    return 1;
                }
            }
            catch (Exception ex)
            {
                return value;
            }
        }

        public async Task<Student> GetStudent(int id)
        {
            try
            {

                Student student = new Student();
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.Connection = con;
                        cmd.Connection.Open();
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.CommandText = $"select* from Student where IdStudent = {id}";


                        using (SqlDataReader rdr = await cmd.ExecuteReaderAsync())
                        {
                           

                            while (rdr.Read())
                            {

                                student.Id = Convert.ToInt32(rdr["IdStudent"].ToString());
                                student.Name = rdr["Name"].ToString();
                                student.LastName = rdr["LastName"].ToString();
                                student.Age = Convert.ToInt32(rdr["Age"].ToString());
                                student.Address = rdr["Address"].ToString();
                                student.Semester = Convert.ToInt32(rdr["Semester"].ToString());

                               

                            }
                           
                        }
                        return student;
                    }

                  
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<Student>> GetStudents()
        {
            try
            {

                List<Student> students = new List<Student>();
                using(SqlConnection  con = new SqlConnection(_connectionString))
                {
                    using(SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.Connection = con;
                        cmd.Connection.Open();
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.CommandText = "select* from Student";


                        using(SqlDataReader rdr = await cmd.ExecuteReaderAsync())
                        {
                            Student student;

                            while (rdr.Read())
                            {
                                student = new Student();

                                student.Id = Convert.ToInt32(rdr["IdStudent"].ToString());
                                student.Name = rdr["Name"].ToString();
                                student.LastName = rdr["LastName"].ToString();
                                student.Age = Convert.ToInt32(rdr["Age"].ToString());
                                student.Address = rdr["Address"].ToString();
                                student.Semester = Convert.ToInt32(rdr["Semester"].ToString());


                                students.Add(student);
                            }
                        }
                    }

                    return students;
                }
            }catch(Exception ex)
            {
                return null;
            }
        }

        public Task<int> Test()
        {
            throw new NotImplementedException();
        }
    }
}
