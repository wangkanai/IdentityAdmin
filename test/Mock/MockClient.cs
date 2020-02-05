using System.Net.Http;

namespace Wangkanai.IdentityAdmin
{
    internal static class MockClient
    {
        public static HttpRequestMessage CreateRequest(string url = "/")
        {
            return new HttpRequestMessage(HttpMethod.Get, url);
        }
    }
}