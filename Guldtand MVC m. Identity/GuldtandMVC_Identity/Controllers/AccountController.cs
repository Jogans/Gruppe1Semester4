using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GuldtandMVC_Identity.Models;
using java.net;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Identity;



namespace GuldtandMVC_Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] DtoUser dtoUser)
        {
            var newUser = new ApplicationUser
            {
                Email = dtoUser.Email,
                UserName = dtoUser.Email,
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

                //HttpContext.Response.Cookies.Append(
                //         dtoUser.Email,
                //         DateTime.Now.ToString(),
                //         new CookieOptions()
                //         {
                //             Expires = DateTime.Now.AddHours(1),
                //             HttpOnly = false,
                //             Secure = false
                //         }
                //     );
                HttpContext.Response.Cookies.Append(
                    dtoUser.Email,
                    DateTime.Now.ToString()
                   );

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
