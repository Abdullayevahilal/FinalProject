using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Travel.Models.Product
{
    public class LeaveReviewViewModel
    {
        public int ProductId { get; set; }

        [Required]
        [Range(1,5)]
        public byte Star { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Review { get; set; }

        public IFormFile File { get; set; }
    }
}
