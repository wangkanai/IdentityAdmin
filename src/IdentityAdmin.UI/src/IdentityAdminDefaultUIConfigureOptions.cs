using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wangkanai.IdentityAdmin.UI
{
    internal class IdentityAdminDefaultUIConfigureOptions : IPostConfigureOptions<RazorPagesOptions>
    {
        private const string IdentityAdminUIDefaultAreaName = "admin";

        public IdentityAdminDefaultUIConfigureOptions(IWebHostEnvironment environment)
        {
            Environment = environment;
        }

        public IWebHostEnvironment Environment { get; }

        public void PostConfigure(string name, RazorPagesOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
