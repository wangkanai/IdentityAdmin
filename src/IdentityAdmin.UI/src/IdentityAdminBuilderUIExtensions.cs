// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Wangkanai.IdentityAdmin.UI;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityAdminBuilderUIExtensions
    {
        public static IIdentityAdminCoreBuilder AddDefaultUI(this IIdentityAdminCoreBuilder builder)
        {
            builder.Services.ConfigureOptions(
                typeof(IdentityAdminDefaultUIConfigureOptions<>)
                    .MakeGenericType(builder.UserType));

            return builder;
        }
    }
}
