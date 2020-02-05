// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;

namespace Wangkanai.IdentityAdmin.Extensions
{
    public static class DataTimeExtensions
    {
        // public static bool HasExpired(this DateTime? expirationTime, DateTime now)
        // {
        //     if (expirationTime.HasValue && expirationTime.Value.HasExpired(now))
        //         return true;
        //
        //     return false;
        // }

        public static bool HasExpired(this DateTime expirationTime, DateTime now)
        {
            if (now > expirationTime)
                return true;

            return false;
        }
    }
}