using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class ProductPolicy :BaseEntity
    {
        public int OrderBy { get; set; }

        public int ProductId { get; set; }

        public bool IsFilter { get; set; }

        [Required]
        [MaxLength(100)]
        public string Key { get; set; }

        [Required]
        [MaxLength(500)]
        public string Value { get; set; }

        public Product Product { get; set; }
    }
}
