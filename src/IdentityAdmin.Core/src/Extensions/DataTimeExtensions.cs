using System;

namespace Wangkanai.IdentityAdmin.Extensions
{
    public static class DataTimeExtensions
    {
        public static bool HasExpired(this DateTime? expirationTime, DateTime now)
        {
            if (expirationTime.HasValue && expirationTime.Value.HasExpired(now))
                return true;

            return false;
        }

        public static bool HasExpired(this DateTime expirationTime, DateTime now)
        {
            if (now > expirationTime)
                return true;

            return false;
        }
    }
}