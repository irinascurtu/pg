using FirstAppi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAppi.Controllers
{
    [Route("api/[controller]")] //localhost:{port}/api/student
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private List<Student> students = new List<Student>();

        public StudentsController()
        {
            students = new List<Student>()
                {
                    new Student { Id=1,  FirstName = "John", LastName = "Doe", Age = 20, Grade = 3.8 },
                    new Student { Id=2, FirstName = "Jane", LastName = "Smith", Age = 21, Grade = 3.6 },
                    new Student { Id=3, FirstName = "Alice", LastName = "Johnson", Age = 19, Grade = 3.9 },
                    new Student { Id=4, FirstName = "Bob", LastName = "Williams", Age = 22, Grade = 3.3 },
                    new Student { Id=5, FirstName = "Emily", LastName = "Brown", Age = 20, Grade = 3.7 }
                };
        }


        [HttpGet]
        public IActionResult GetAllStudents()//GetAll
        {
            return Ok(this.students);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

    }
}
