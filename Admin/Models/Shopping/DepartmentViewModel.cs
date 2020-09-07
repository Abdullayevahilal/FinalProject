using System.ComponentModel.DataAnnotations;

namespace Admin.Models.Shopping
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required(ErrorMessage = "Department name is required")]
        [MaxLength(50, ErrorMessage = "Department name can be maximum 50 characters")]
        public string Name { get; set; }
    }
}
