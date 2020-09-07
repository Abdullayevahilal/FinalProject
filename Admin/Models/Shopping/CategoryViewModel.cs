using System.ComponentModel.DataAnnotations;

namespace Admin.Models.Shopping
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required(ErrorMessage = "Category name is required")]
        [MaxLength(50, ErrorMessage = "Category name can be maximum 50 characters")]
        public string Name { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        public DepartmentViewModel Department { get; set; }
    }
}
