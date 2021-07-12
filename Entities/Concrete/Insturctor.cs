using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Insturctor: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string Image { get; set; }
    }
}
