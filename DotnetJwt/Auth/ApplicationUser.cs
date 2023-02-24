using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace DotnetJwt.Auth
{
    public class ApplicationUser:IdentityUser
    { 
        public string? CustomTag { get; set; }
    }
}
