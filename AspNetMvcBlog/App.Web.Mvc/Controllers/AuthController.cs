using App.Web.Mvc.Data;
using App.Web.Mvc.Data.Entity;
using App.Web.Mvc.DTOs;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text.Json;

namespace App.Web.Mvc.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext appDbContext;

        public AuthController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterUserDto model)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction(nameof(Register), new { model });
            }

            if (model == null)
            {
                RedirectToAction(nameof(Index), "Home");
            }

            bool alreadyRegistered = appDbContext.User.Any(user => user.UserEmail == model.UserEmail);

            if (alreadyRegistered)
            {
                ModelState.AddModelError("Email", "Boyle bir email adresi zaten mevcut");

                ViewBag.RegisterationMessage = "Kayit basarisiz oldu";
                RedirectToAction(nameof(Register));
            }

            else
            {
                var dataModel = new User()
                {
                    UserEmail = model.UserEmail,
                    UserName = model.UserName,
                    UserSurname = model.UserSurname,
                    UserPassword = model.UserPassword,

                };

                appDbContext.Add(dataModel);
                appDbContext.SaveChanges();
                ViewBag.RegisterationMessage = "Kayit basari ile gerceklestirildi"; //bu konuda bir şey düşünün..

                return RedirectToAction(nameof(Index), "Home", new { area = "" });
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login(string? redirectUrl)
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginUserDto model)
        {
            if (model == null)
            {
                return RedirectToAction(nameof(Login));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = appDbContext.User.FirstOrDefault(t => t.UserEmail == model.UserEmail && t.UserPassword == model.UserPassword);

            if (user == null)
            {
                ModelState.AddModelError(nameof(model.UserPassword), "Kullanıcı kodu veya şifreniz hatalı");
                return View(model);
            }

            if (string.IsNullOrEmpty(HttpContext.Session.GetString("user")))
            {
                string userJson = JsonSerializer.Serialize<User>(user);
                HttpContext.Session.SetString("user", userJson);
                HttpContext.Session.SetInt32("isLoggedIn", 1);
            }

            #region claim
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Surname, user.UserSurname),
                new Claim(ClaimTypes.Email, user.UserEmail)

            };

            var claimsIdentity = new ClaimsIdentity(claims,
            CookieAuthenticationDefaults.AuthenticationScheme);

            #endregion

            return RedirectToAction(nameof(Index), "Home", new { area = "" });

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            //HttpContext.Session.Remove("user");

            return Redirect("/");

        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

    }
}

