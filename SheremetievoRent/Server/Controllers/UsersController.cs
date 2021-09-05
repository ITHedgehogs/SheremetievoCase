using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SheremetievoRent.Server.Data;
using SheremetievoRent.Shared;

namespace SheremetievoRent.Server.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> logger;
        private readonly DataContext context;
        private readonly NavigationManager navigation;

        public UsersController(ILogger<UsersController> logger, DataContext context, NavigationManager navigation)
        {
            this.logger = logger;
            this.context = context;
            this.navigation = navigation;
        }

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return context.Users;
        }

        [HttpPost("register")]
        public async Task RegisterNewAccount(User accountInfo)
        {
            await context.Users.AddAsync(accountInfo);
            await context.SaveChangesAsync();
        }

        [HttpPost("login")]
        public async Task<ActionResult<User>> LoginIn(User aInfo)
        {
            var user = await context.Users
                .Where(x => x.Email == aInfo.Email && x.Password == aInfo.Password).FirstOrDefaultAsync();
            if (user != null)
            {
                var claimsIdentity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Email, user.Email),
                }, "serverAuth");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
            }

            return await Task.FromResult(user);
        }
        
        [HttpGet("logout")]
        public async Task Logout()
        {
            await HttpContext.SignOutAsync();
        }

        [HttpGet("current")]
        public async Task<ActionResult<User>> GetCurrentUser()
        {
            var userInfo = new User();
            if (User.Identity is {IsAuthenticated: true})
                userInfo = await context.Users.Where(x => x.Email == User.FindFirstValue(ClaimTypes.Email)).FirstOrDefaultAsync();
            userInfo.Password = "";
            return await Task.FromResult(userInfo);
        }
    }
}