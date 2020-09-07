using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.Models
{
    public class CategoryListViewModel
    {
        public CategoryViewModel Category { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
