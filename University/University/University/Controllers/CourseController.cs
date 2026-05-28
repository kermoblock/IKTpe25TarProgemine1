using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University.Data;
using University.Models;
using University.ViewModel;
using University.ViewModel.CoursesVM;
using University.ViewModel.CourseVM;

namespace University.Controllers
{
    public class CourseController : Controller
    {
        //on vaja kutsuda välja University constructor

        private readonly UniversityContext _context;
        private object course;

        public CourseController
            (
                UniversityContext context
            )
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
        var Course = _context.Courses
            .Select(c => new CourseIndexViewModel
            {
                CourseId = c.CourseId,
                Title = c.Title,
                Credits = c.Credits,
                DepartmentId = c.DepartmentId,
                Department = new CourseDepartmentIndexViewModel
                {
                    DepartmentName = c.Departments.Name
                }
            });
            return View(Course);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vm = await _context.Courses
                .Where(c => c.CourseId == id)
                .Select(c => new CourseUpdateViewModel
                {
                    CourseId = c.CourseId,
                    Title = c.Title,
                    Credits = c.Credits,
                    Department = new CourseDepartmentIndexViewModel
                    {
                        DepartmentName = c.Departments != null ? c.Departments.Name : null
                    }
                })
            .FirstOrDefaultAsync();

            return View(vm);
        }
    }
}
