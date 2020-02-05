// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;
using Wangkanai.IdentityAdmin.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityAdminCollectionExtensions
    {
        public static IdentityAdminBuilder AddIdentityAdmin<TUser>(this IServiceCollection services, Action<IdentityAdminOptions> setAction)
            => services.Configure(setAction)
                       .AddIdentityAdmin<TUser>();

        public static IdentityAdminBuilder AddIdentityAdmin<TUser>(this IServiceCollection services)
            => services.AddIdentityAdminBuilder(typeof(TUser));

        internal static IdentityAdminBuilder AddIdentityAdminBuilder(this IServiceCollection services, Type user)
            => new IdentityAdminBuilder(user, services);
    }
}