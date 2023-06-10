using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Pizza_Mama.Pages.Admin
{
    public class IndexModel : PageModel
    {
        public bool pasConnecte = false;
        public bool IsDevelopmentMode = false;
        IConfiguration configuration;
        public IndexModel(IConfiguration configuration, IWebHostEnvironment env) { 
            this.configuration = configuration;

            if (env.IsDevelopment())
            {
                IsDevelopmentMode = true;
            }
        }
        public IActionResult OnGet()
        {
            if (HttpContext.User.Identity.IsAuthenticated) {
                return Redirect("/admin/pizzas");
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string username, string password, string ReturnUrl)
        {
            var authSection = configuration.GetSection("Auth");

            string adminLogin = authSection["AdminLogin"];
            string adminPassword = authSection["AdminPassword"];

            if ((username == adminLogin) && (password == adminPassword))
            {
                var claims = new List<Claim>
                {
                new Claim(ClaimTypes.Name, username)
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Login");
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new
                ClaimsPrincipal(claimsIdentity));
                pasConnecte = false;
                return Redirect(ReturnUrl == null ? "/Admin/Pizzas" : ReturnUrl);
            }
            pasConnecte = true;
            return Page();
        }
        public async Task<IActionResult> OnGetLogout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/admin");
        }
    }
}
