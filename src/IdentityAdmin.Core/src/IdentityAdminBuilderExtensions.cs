// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using System;

namespace Wangkanai.IdentityAdmin
{
    public static class IdentityAdminBuilderExtensions
    {
        public static IApplicationBuilder UseIdentityAdmin(
            this IApplicationBuilder app)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));

            return app.UseMiddleware<IdentityAdminMiddleware>();
        }

        public static IApplicationBuilder UseIdentityAdmin(
            this IApplicationBuilder app,
            IdentityAdminOptions options)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            return app.UseMiddleware<IdentityAdminMiddleware>(Options.Create(options));
        }
    }
}
