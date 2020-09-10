using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class BlogReview:BaseEntity
    {
        public int BlogDetailId { get; set; }
        public int UserId { get; set; }
        [Required]
        [MaxLength(100)]
        public string CraetedBy { get; set; }
        [Required]
        [MaxLength(500)]
        public string Review { get; set; }
        public DateTime CreatedAt { get; set; }
        public User User { get; set; }
        public BlogDetail BlogDetail { get; set; }
    }
}
