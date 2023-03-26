using System.ComponentModel.DataAnnotations;

namespace TMSLesson17.Models
{
    public class UserViewModel
    {

        [Required, MinLength(5), MaxLength(50)]
        public string Username { get; set; }
        public string Password { get; set; }

        public UserViewModel() { }
    }
}