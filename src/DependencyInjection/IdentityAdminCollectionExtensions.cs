// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;
using Wangkanai.IdentityAdmin.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityAdminCollectionExtensions
    {
        public static IIdentityAdminBuilder AddIdentityAdmin<TUser, TRole>(this IServiceCollection services, Action<IdentityAdminOptions> setAction)
            => services.Configure(setAction)
                       .AddIdentityAdmin<TUser, TRole>();

        public static IIdentityAdminBuilder AddIdentityAdmin<TUser, TRole>(this IServiceCollection services)
            => services.AddIdentityAdminBuilder(typeof(TUser), typeof(TRole))
                       .AddCoreServices()
                       .AddWebApiServices();

        internal static IIdentityAdminBuilder AddIdentityAdminBuilder(this IServiceCollection services, Type user, Type role)
            => new IdentityAdminBuilder(user, role, services);
    }
}