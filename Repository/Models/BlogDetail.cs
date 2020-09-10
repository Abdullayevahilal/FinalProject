using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class BlogDetail:BaseEntity
    {
        public string BlogId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public string PostedBy { get; set; }
        public DateTime PostedDate { get; set; }
        public Blog Blog { get; set; }
        public ICollection<BlogReview> Reviews { get; set; }
        public ICollection<Favorite> Favorites { get; set; }

    }

}
