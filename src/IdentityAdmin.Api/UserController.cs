using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityAdmin.Api
{
    [Authorize]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        public IEnumerable<UserViewModel> Get()
        {
            var users = new List<UserViewModel> {
                new UserViewModel
                {
                    Username = "sarin",
                    Firstname = "Sarin",
                    Lastname = "Na Wangkanai"
                }
            };

            return users;
        }
    }

    public class UserViewModel
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
