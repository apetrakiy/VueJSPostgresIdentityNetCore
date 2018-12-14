using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;

namespace UserService.Api.Entities
{
    public class UserServiceDbContextSeeder
    {
        private readonly UserServiceDbContext _context;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserServiceDbContextSeeder(UserServiceDbContext context,  RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task EnsureSeededAsync()
        {
            if (!_userManager.Users.Any())
            {
                var users = JsonConvert.DeserializeObject<List<ApplicationUser>>(File.ReadAllText("seed" + Path.DirectorySeparatorChar + "users.json"));
                foreach (var user in users)
                {
                    var userName = user.Email.Substring(0, user.Email.IndexOf('@'));
                    user.UserName = userName;
                    var result = await _userManager.CreateAsync(user);
                    if (result.Succeeded)
                    {
                        await _userManager.AddPasswordAsync(user, userName);
                    }
                }
                
            }
        }
    }
}