
using Microsoft.AspNetCore.Identity;

namespace MovieApp.Domain.Entities.Identity
{
    public class AppUser: IdentityUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email{ get; set; }
        public string Password{ get; set; }
    }
}
