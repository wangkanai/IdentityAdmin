// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using IdentityAdmin.Builder;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityAdminCollectionsExtension
    {
        public static IdentityAdminBuilder AddIdentityAdmin(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //services.TryAddTransient<IIdentityAdminService, IdentityAdminService>();

            return new IdentityAdminBuilder(services);
        }
    }
}
