using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcCVReal.Models.Entity;
using System.Security.Claims;

namespace MvcCVReal.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(TblAdmin admin)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Login");
            }
            DbMyCvContext context = new DbMyCvContext();
            var logintry = context.TblAdmins.FirstOrDefault(x => x.KullaniciAd == admin.KullaniciAd &&
            x.KullaniciSifre == admin.KullaniciSifre);
            if (logintry != null)
            {
                var claims = new List<Claim>
                {
                new Claim(ClaimTypes.Name, logintry.KullaniciAd),
                new Claim(ClaimTypes.Role, logintry.Role)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties();

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
