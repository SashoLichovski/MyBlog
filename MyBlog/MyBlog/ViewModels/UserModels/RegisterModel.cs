using System.ComponentModel.DataAnnotations;

namespace MyBlog.ViewModels.UserModels
{
    public class RegisterModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "The password must contain at least 8 characters")]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$",
            ErrorMessage = "The password must contain at least one captial letter and one digit")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
