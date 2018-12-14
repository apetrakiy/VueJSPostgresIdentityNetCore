using System;
using Microsoft.AspNetCore.Identity;

namespace UserService.Api.Entities
{
    public class ApplicationRole : IdentityRole<long>
    {
        public ApplicationRole() : base() {}

        public ApplicationRole(string roleName) : base(roleName)
        {

        }

        public ApplicationRole(string roleName, string description, DateTime creationDate) : base(roleName) {
            this.Description = description;
            this.CreationDate = creationDate;
        }

        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}