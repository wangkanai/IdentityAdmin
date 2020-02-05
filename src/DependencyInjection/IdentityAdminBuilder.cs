﻿// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public class IdentityAdminBuilder : IIdentityAdminBuilder
    {
        public IServiceCollection Services { get; }
        
        public Type UserType { get; }

        public Type RoleType { get; }

        public IdentityAdminBuilder(Type user, IServiceCollection services)
        {
            Services = services ?? throw new ArgumentNullException(nameof(services));
            UserType = user ?? throw new ArgumentNullException(nameof(user));
        }

        public IdentityAdminBuilder(Type user, Type role, IServiceCollection services) 
            : this(user, services)
        {
            RoleType = role ?? throw new ArgumentNullException(nameof(role));
        }
    }
}