// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;
using System;

namespace IdentityAdmin.Builder
{
    public class IdentityAdminBuilder : IIdentityAdminBuilder
    {
        public IServiceCollection Services { get; private set; }

        public IdentityAdminBuilder(IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            Services = services;
        }
    }
}