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

       
        public string Review { get; set; }

      
    }
}
