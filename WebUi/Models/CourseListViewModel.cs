using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUi.Models
{
    public class CourseListViewModel
    {
        public List<Course> Courses { get; set; }
        public List<Insturctor> Insturctors { get; set; }
    }
}
