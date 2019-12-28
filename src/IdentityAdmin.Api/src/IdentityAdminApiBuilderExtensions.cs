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
