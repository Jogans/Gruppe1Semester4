using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.sun.org.apache.xml.@internal.utils;
using GuldtandMVC_Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GuldtandMVC_Identity.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] DtoUser dtoUser)
        {
            var newUser = new ApplicationUser
            {
                UserName = dtoUser.Email,
                Email = dtoUser.Email,
                NormalizedUserName = dtoUser.Name,
            };
            var userCreationResult = await _userManager.CreateAsync(newUser, dtoUser.Password);
            if (userCreationResult.Succeeded)
            {
                return Ok(newUser);
            }
            foreach (var error in userCreationResult.Errors)
                ModelState.AddModelError(string.Empty, error.Description);
            return BadRequest(ModelState);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] DtoUser dtoUser)
        {
            var passwordSignInResult = await _signInManager.PasswordSignInAsync(dtoUser.Email,
               dtoUser.Password, isPersistent: false, lockoutOnFailure: false);
            if (passwordSignInResult.Succeeded)
            {
                return Ok();
            }
            ModelState.AddModelError(string.Empty, "Invalid login");
            return BadRequest(ModelState);
        }

        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }


    }
}