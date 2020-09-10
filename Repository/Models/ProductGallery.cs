using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class ProductGallery :BaseEntity
    {
        public int OrderBy { get; set; }

        public int ProductId { get; set; }
        public string Image { get; set; }
    }
}
