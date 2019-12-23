// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace Wangkanai.IdentityAdmin
{
    public class IdentityAdminMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IdentityAdminOptions _options;

        public IdentityAdminMiddleware(RequestDelegate next, IOptions<IdentityAdminOptions> options)
        {
            if (next == null) throw new ArgumentNullException(nameof(next));
            if (options == null) throw new ArgumentNullException(nameof(options));

            _next = next;
            _options = options.Value;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            await _next(context);
        }
    }
}
