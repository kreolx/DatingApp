using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must create password length between 4 and 8 character")]
        public string Password { get; set; }
    }
}