using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Repositories;

namespace StudentAdminPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private readonly IStudentRepository _studentRepository;
        public StudentsController(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }
        [HttpGet]
        public IActionResult GetAllStudent()
        {
            var students = _studentRepository.GetStudents();

            var domainModel = new List<StudentDto>();
            foreach (var student in students)
            {
                domainModel.Add(new StudentDto
                {

                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    DateOfBirth = student.DateOfBirth,
                    Email = student.Email,
                    Mobile = student.Mobile,
                    ProfileImageUrl = student.ProfileImageUrl,
                    GenderId = student.GenderId,
                });
            }

            return Ok(domainModel);
        }
    }
}
