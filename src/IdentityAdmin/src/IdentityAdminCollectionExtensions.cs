// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using Wangkanai.IdentityAdmin.Builder;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Wangkanai.Responsive.Core.Internal;
using Wangkanai.IdentityAdmin;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityAdminCollectionExtensions
    {
        public static IdentityAdminBuilder AddIdentityAdmin(
            this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddIdentityAdminCore();

            return new IdentityAdminBuilder(services);
        }

        public static IdentityAdminBuilder AddIdentityAdmin(
            this IServiceCollection services,
            Action<IdentityAdminOptions> setAction)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.Configure<IdentityAdminOptions>(setAction);
            services.AddIdentityAdminCore();

            return new IdentityAdminBuilder(services);
        }
    }
}
