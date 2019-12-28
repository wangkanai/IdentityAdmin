// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Wangkanai.IdentityAdmin;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityAdminApiCollectionExtensions
    {
        public static IIdentityAdminCoreBuilder AddApiExplorer(
            this IIdentityAdminCoreBuilder builder)
        {
            if (builder is null)
                throw new System.ArgumentNullException(nameof(builder));

            return builder;
        }
    }
}