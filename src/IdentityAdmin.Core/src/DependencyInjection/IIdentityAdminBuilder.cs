// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;

namespace Wangkanai.IdentityAdmin
{
    public interface IIdentityAdminBuilder
    {
        IServiceCollection Services { get; }
    }
}