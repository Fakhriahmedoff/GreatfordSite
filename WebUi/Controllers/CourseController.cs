using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUi.Models;

namespace WebUi.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;

        public CourseController(ICourseService productService)
        {
            _courseService = productService;
        }

        public IActionResult Index()
        {
            var model = new CourseListViewModel
            {
                Courses = _courseService.GetAll()
            };
            return View(model);
        }
    }
}
