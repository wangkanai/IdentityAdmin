// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Wangkanai.IdentityAdmin;
using Wangkanai.IdentityAdmin.Builder;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityAdminCoreCollectionExtensions
    {
        public static IIdentityAdminCoreBuilder AddIdentityAdminCore(this IServiceCollection services)
        {
            return new IdentityAdminCoreBuilder(services);
        }
    }
}