// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Wangkanai.IdentityAdmin.UI;

namespace Wangkanai.IdentityAdmin
{
    public static class IdentityAdminBuilderUIExtensions
    {
        public static IdentityAdminBuilder AddDefaultUI(this IdentityAdminBuilder builder)
        {
            builder.Services.ConfigureOptions(typeof(IdentityAdminDefaultUIConfigureOptions))

            return builder;
        }
    }
}
