using System.ComponentModel.DataAnnotations;

namespace WebApplication202311.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Please enter your name!")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Please enter your email!")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone!")]
        public String Phone { get; set; }

        [Required(ErrorMessage = "Please choose an option!")]
        public bool? IsGraduate { get; set; }
    }
}
