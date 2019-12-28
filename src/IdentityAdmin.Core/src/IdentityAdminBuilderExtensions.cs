// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Builder;
using System;
using Wangkanai.IdentityAdmin;

namespace Microsoft.Extensions.DependencyInjection
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
    }
}