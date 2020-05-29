using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using BLL.DTO;
using BLL.Infrastructure;
using BLL.Interfaces;
using WEB.Models.Account;
using Microsoft.Extensions.Logging;
using BLL.Services;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace WEB.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService userService;

        public AccountController(IUserService serv)
        {
            userService = serv;
        }

        
        [Route("Login")]
        public IActionResult VLogin()
        {
            return View();
        }

        [Route("Registration")]
        public IActionResult VRegistration()
        {
            return View();
        }

        public IActionResult VForgotPassword()
        {
            return View("~/Views/Account/VLogin.cshtml");
        }

        [Authorize]
        public IActionResult VHome()
        {
            string name = User.Identity.Name;
            UserDTO newUser = userService.GetAll().Where(x => x.Email.ToUpper() == name.ToUpper()).SingleOrDefault();

            switch (newUser.Roles)
            {
                case "Admin": return View("~/Views/AdminDepartment/Home.cshtml", User.Identity.Name);
                case "Educational": return View("~/Views/EducationalDepartment/Home.cshtml");
                case "Curriculum": return View("~/Views/CurriculumDepartment/Home.cshtml");
                case "StudentDepartment": return View("~/Views/StudentDepartment/Home.cshtml");
                case "TeacherDepartment": return View("~/Views/TeacherDepartment/Home.cshtml");
            }

            return null;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserDTO user = userService.FindUser(model.Email, model.Password);
                if (user != null)
                {
                    await Authenticate(model.Email); // аутентификация

                    switch (user.Roles)
                    {
                        case "Admin": return RedirectToAction("VHome", "AdminDepartment");
                        case "EducationalDepartment": return RedirectToAction("VHome", "EducationalDepartment");
                        case "Curriculum": return RedirectToAction("VHome", "CurriculumDepartment");
                        case "StudentDepartment": return RedirectToAction("VHome", "StudentDepartment");
                        case "TeacherDepartment": return RedirectToAction("VHome", "TeacherDepartment");
                    }

                }

                ModelState.AddModelError("", "Невірний логін або пароль!");
            }

            return View("~/Views/Account/VLogin.cshtml", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                UserDTO user = new UserDTO()
                {
                    Email = model.Email,
                    Password = model.Password,
                };

                if (userService.FindUser(model.Email, model.Password) == null)
                {
                    if (user.Password == model.ConfirmPassword)
                    {
                        // добавляем пользователя в бд
                        await userService.Create(user);
                        //await userService.SaveChangesAsync();

                        await Authenticate(model.Email); // аутентификация

                        return RedirectToAction("VHomeUser", "Home");
                    }
                    else
                        ModelState.AddModelError("Password", "Паролі не співпадають");
                    //else
                    //return Content("Паролі не співпадають");
                }
                else
                    ModelState.AddModelError("Password", "Паролі не співпадають");
            }

            return View(model);
        }

        private async Task Authenticate(string userName)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("VLogin", "Account");
        }


    }
}