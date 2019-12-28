// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using Wangkanai.IdentityAdmin;
using Wangkanai.IdentityAdmin.Builder;
using Wangkanai.Responsive.Core.Internal;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityAdminCoreCollectionExtensions
    {
        public static IIdentityAdminCoreBuilder AddIdentityAdminCore(
            this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.TryAddTransient<IIdentityAdminService, IdentityAdminService>();

            services.AddOptions();

            services.TryAddSingleton<ResponsiveMarkerService, ResponsiveMarkerService>();

            return new IdentityAdminCoreBuilder(services);
        }
    }
}