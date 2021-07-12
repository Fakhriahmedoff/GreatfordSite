using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
       private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> Get(int id)
        {
           return _courseDal.GetList(c=>c.Id == id);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetList();
        }
    }
}
