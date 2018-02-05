using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityAdmin.Api
{
    public class UserController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await BuildUserViewModelAsync();
            return View();
        }

        private async Task<UserViewModel> BuildUserViewModelAsync()
        {
            await Task.Delay(100);

            return new UserViewModel { };
        }
    }

    public class UserViewModel
    {

    }
}
