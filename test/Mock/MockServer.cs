using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Wangkanai.IdentityAdmin.Configuration;

namespace Wangkanai.IdentityAdmin
{
    internal static class MockServer
    {
        public static TestServer CreateServer<TUser>()
            => CreateServer(CreateWebHostBuilder<TUser>());
        
        public static TestServer CreateServer<TUser>(Action<IdentityAdminOptions> options)
            => CreateServer(CreateWebHostBuilder<TUser>(options));
        
        public static TestServer CreateServer(IWebHostBuilder builder)
            => new TestServer(builder);

        public static IWebHostBuilder CreateWebHostBuilder<TUser>()
            => CreateWebHostBuilder<TUser>(options => { });
        
        public static IWebHostBuilder CreateWebHostBuilder<TUser>(Action<IdentityAdminOptions> options)
            => new WebHostBuilder()
               .ConfigureServices(services => services.AddIdentityAdmin<TUser>(options))
               .Configure(app =>
               {
                   app.UseIdentityAdmin();
                   app.Run(IdentityAdminContextHandler());
               });

        private static RequestDelegate IdentityAdminContextHandler()
        {
            return context => context.Response.WriteAsync("IdentityAdmin");
        }
    }
}