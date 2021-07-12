using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebUi.Models;

namespace WebUi.Controllers
{
    public class HomeController : Controller
    {
        private IInstructorService _instructorService;

        private ICourseService _courseService;
        public HomeController(IInstructorService instructorService, ICourseService courseService)
        {
            _instructorService = instructorService;
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            var model = new CourseListViewModel
            {
                Insturctors = _instructorService.GetAll(),
                Courses = _courseService.GetAll()
            };
            return View(model);
        }

    }
}
