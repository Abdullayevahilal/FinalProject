using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using Repository.Models;
using Repository.Repositories.AuthRepositories;
using Travel.Models.Account;

namespace Travel.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAuthRepository _authRepository;

        public AccountController(IMapper mapper,
                                 IAuthRepository authRepository)
        {
            _mapper = mapper;
            _authRepository = authRepository;
        }
        public IActionResult Register(RegisterViewModel register)
        {
            bool checkUser = _authRepository.CheckEmail(register.Email);

            if (checkUser)
            {
                ModelState.AddModelError("Email", "This email is already registered");
            }
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<RegisterViewModel, User>(register);
                user.Token = Guid.NewGuid().ToString();
                user.Status = true;
                _authRepository.Register(user);

                Response.Cookies.Delete("token");

                Response.Cookies.Append("token", Guid.NewGuid().ToString(), new Microsoft.AspNetCore.Http.CookieOptions
                {
                    HttpOnly = true,
                    Expires = DateTime.Now.AddYears(1)
                });

                return RedirectToAction("login");
            }
            return View("~/Views/Account/Register.cshtml",new AccountViewModel{

                Register = register
            });
        }
        public IActionResult Login(LoginViewModel login)
        {
           
            if(ModelState.IsValid)
            {
                var user = _authRepository.Login(login.Email, login.Password);

                if(user != null)
                {
                    user.Token = Guid.NewGuid().ToString();
                    _authRepository.UpdateToken(user.Id,user.Token);
                    Response.Cookies.Delete("token");
                    Response.Cookies.Append("token", Guid.NewGuid().ToString(), new Microsoft.AspNetCore.Http.CookieOptions
                    {
                        HttpOnly = true,
                        Expires = DateTime.Now.AddYears(1)
                    });

                    Request.Cookies.TryGetValue("token", out string token);
                    return RedirectToAction("userdashboard");

                }
                ModelState.AddModelError("Login.Password", "Wrong email or password");
            }
            return View("~/Views/Account/Login.cshtml", new AccountViewModel
            {

                Login = login
            });
        }
        public IActionResult UserDashboard()
        {
            return View();
        }
    }
}