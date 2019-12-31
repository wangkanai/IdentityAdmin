// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public class IdentityAdminCoreBuilder : IIdentityAdminCoreBuilder
    {
        public IServiceCollection Services { get; private set; }

        public IdentityAdminCoreBuilder(IServiceCollection services)
        {
            Services = services
                ?? throw new ArgumentNullException(nameof(services));
        }
    }
}