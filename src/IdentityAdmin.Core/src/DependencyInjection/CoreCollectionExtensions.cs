// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using System;
using Wangkanai.IdentityAdmin;
using Wangkanai.IdentityAdmin.Configuration;
using Wangkanai.IdentityAdmin.Internal;
using Wangkanai.IdentityAdmin.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class CoreCollectionExtensions
    {
        public static IIdentityAdminCoreBuilder AddIdentityAdminCore(
            this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.TryAddSingleton<IdentityAdminService, IdentityAdminService>();

            services.AddOptions();
            services.AddSingleton(
                resolver => resolver.GetRequiredService<IOptions<IdentityAdminOptions>>().Value);

            services.TryAddSingleton<IdentityAdminMarkerService, IdentityAdminMarkerService>();

            return new IdentityAdminCoreBuilder(services);
        }
    }
}