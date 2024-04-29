using System.ComponentModel.DataAnnotations;

namespace WebApp1ByKrisha.Models
{
    public class Student
    {
        [Required(ErrorMessage = "ID is required")]
        public int StdID{ get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name length must be 2 to 50")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Faculty is required")]
        public string Faculty { get; set; }
    }
}
