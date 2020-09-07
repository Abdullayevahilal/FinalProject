using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string CoverImage { get; set; }
        public string Name { get; set; }
        public DepartmentViewModel Department { get; set; }
    }
}
