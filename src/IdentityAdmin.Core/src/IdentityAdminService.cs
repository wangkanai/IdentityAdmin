// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text;

namespace Wangkanai.IdentityAdmin
{
    public class IdentityAdminService : IIdentityAdminService
    {
        public HttpContext Context { get; }

        public IdentityAdminService(HttpContext context)
        {
            Context = context ?? throw new System.ArgumentNullException(nameof(context));
        }
    }
}
