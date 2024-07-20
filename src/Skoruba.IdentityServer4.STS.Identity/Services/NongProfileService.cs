using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Skoruba.IdentityServer4.STS.Identity.Services
{
    //public class NongProfileService : IProfileService
    //{
    //    private readonly UserManager<ApplicationUser> _userManager;

    //    public NongProfileService(UserManager<ApplicationUser> userManager)
    //    {
    //        _userManager = userManager;
    //    }

    //    public async Task GetProfileDataAsync(ProfileDataRequestContext context)
    //    {
    //        var user = await _userManager.GetUserAsync(context.Subject);
    //        var roles = await _userManager.GetRolesAsync(user);
    //        var claims = new List<Claim>
    //    {
    //        new Claim(JwtClaimTypes.Role, string.Join(",", roles))
    //    };

    //        context.IssuedClaims.AddRange(claims);
    //    }

    //    public async Task IsActiveAsync(IsActiveContext context)
    //    {
    //        var user = await _userManager.GetUserAsync(context.Subject);
    //        context.IsActive = user != null;
    //    }
    //}

}
