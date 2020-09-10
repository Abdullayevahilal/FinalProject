using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.Models.Blog
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PostedBy { get; set; }
        public LabelViewModel Label { get; set; }
        public string ActionText { get; set; }
        public string EndPoint { get; set; }
    }
}
