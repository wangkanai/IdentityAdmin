// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Wangkanai.IdentityAdmin.Builder;
using System;
using System.Collections.Generic;
using System.Text;
using Wangkanai.IdentityAdmin;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityAdminApiBuilderExtensions
    {
        public static IIdentityAdminCoreBuilder AddApiExplorer(
            this IIdentityAdminCoreBuilder builder)
        {
            return builder;
        }
    }
}
