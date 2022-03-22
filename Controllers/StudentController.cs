using FirstAPI.Model;
using FirstAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository repo;
        public StudentController(IStudentRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(repo.GetStudents());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(repo.GetStudent(id));
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            repo.AddStudent(student);
            return StatusCode(201, "Student details saved successfully");
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Student student)
        {
            repo.UpdateStudent(id, student);
            return Ok("Student details updated successfully");
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            repo.DeleteStudent(id);
            return Ok("Student details deleted successfully");
        }
    }
}
