using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Models.Product;

namespace Travel.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<string> Photos { get; set; }
        public int Id { get; set; }
        public LabelViewModel Label { get; set; }
        public DiscountViewModel Discount { get; set; }
        public CategoryViewModel Category { get; set; }
        public IList<LeaveReviewViewModel> LeaveReviews { get; set; }
        public IList<ReviewViewModel> Reviews { get; set; }
        public byte StarCount { get; set; }
        public string Text { get; set; }
    }
}
