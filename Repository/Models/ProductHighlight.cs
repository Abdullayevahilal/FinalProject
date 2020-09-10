using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class ProductHighlight :BaseEntity
    {
        public int OrderBy { get; set; }

        public int ProductId { get; set; }

        public bool IsFilter { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        public string Image { get; set; }

        [Required]
        [MaxLength(500)]
        public string Key { get; set; }

        [Required]
        [MaxLength(500)]
        public string Value { get; set; }

        public Product Product { get; set; }
    }
}
