using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    
        [Authorize(Roles = "Admin")]
        public class AdminController : Controller
        {
        // Admin paneli eylemleri
        services.AddControllersWithViews(config =>
{
        var policy = new AuthorizationPolicyBuilder()
                  .RequireAuthenticatedUser()
                  .RequireRole("Admin")
                  .Build();
        config.Filters.Add(new AuthorizeFilter(policy));
});



        }


    }

