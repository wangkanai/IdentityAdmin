// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;

namespace Wangkanai.IdentityAdmin
{
    public interface IIdentityAdminCoreBuilder
    {
        IServiceCollection Services { get; }
    }
}