using System.ComponentModel.DataAnnotations;

namespace KariyerClone.Models.Dtos
{
    public class ApiUserDto : LoginDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
      

    }
}
