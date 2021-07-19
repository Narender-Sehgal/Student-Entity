using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        /// <summary>
        /// Database Object
        /// </summary>
        private readonly FirewallContext _context;
        public StudentsController(FirewallContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Get All Student Records
        /// </summary>
        [HttpGet]
        [Route("GetStudents")]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }
        /// <summary>
        /// Get Student Record By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetStudentById")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return student;
        }

        /// <summary>
        /// Get Pagination Students
        /// </summary>
        /// <param name="page"></param>
        /// <param name="itemsPerPage"></param>
        /// <returns></returns>

        [HttpGet]
        [Route("Paging")]
        public Pagination<Student> Paging([FromQuery] int? page, int itemsPerPage)
        {
            var countDetails = _context.Students.Count();
            var res = new Pagination<Student>()
            {
                Count = countDetails,
                Page = page ?? 1,
                ItemsPerPage = itemsPerPage,
                Student = _context.Students.Skip((page - 1 ?? 0) * itemsPerPage).Take(itemsPerPage).ToList()
            };
            return res;
        }
    }
}
