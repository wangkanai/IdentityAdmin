// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;

namespace IdentityAdmin.Builder
{
    public interface IIdentityAdminCoreBuilder
    {
        IServiceCollection Services { get; }
    }
}