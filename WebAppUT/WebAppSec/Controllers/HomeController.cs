using System; using WebAppSec.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppSec.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace WebAppSec.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public HomeController(
           UserManager<User> userManager,
           SignInManager<User> signInManager,
           RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            var uClaim = User.Claims.FirstOrDefault(x => x.Type == "EditSet");

            return View();
        }

        public async Task<IActionResult> Contact()
        {
            ViewData["Message"] = "Your contact page.";

            var tttt = _userManager.GetUserId(User);
            var yyyy = User.FindFirstValue("UserIdClaimType");

            var user = await _userManager.GetUserAsync(User);


            //Add userClaim
            //await _userManager.AddClaimAsync(user, new System.Security.Claims.Claim("EditSet", "True"));

            //Add role
            //var role = new Role();
            //role.Name = "Admin2";
            //await _roleManager.CreateAsync(role);

            //Add role to user
            //await _userManager.AddToRoleAsync(user, "Admin2");

            //Add claim to role
            var role = await _roleManager.FindByNameAsync("Admin2");
            var ttt = await _roleManager.AddClaimAsync(role, new System.Security.Claims.Claim("ViewSet", "True"));

            await _signInManager.RefreshSignInAsync(user);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
