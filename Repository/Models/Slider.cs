using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class Slider :BaseEntity
    {
        public SliderPosition Position { get; set; }
        public int OrderBy { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
     
    }
}
