using System;
using Microsoft.AspNetCore.Identity;

namespace UserService.Api.Entities
{
    public class ApplicationUser : IdentityUser<long>
    {
        public string FirstName { get; set; }
	
        public string LastName { get; set; }

        public DateTime? Birthday { get; set; }
    }
}