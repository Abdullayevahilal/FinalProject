using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.Models.Blog
{
    public class BlogDetailViewModel
    {
        public string BlogId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public string PostedBy { get; set; }
        public DateTime PostedDate { get; set; }
    }
}
