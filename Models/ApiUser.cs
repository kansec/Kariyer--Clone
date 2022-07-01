using Microsoft.AspNetCore.Identity;

namespace KariyerClone.Models
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
