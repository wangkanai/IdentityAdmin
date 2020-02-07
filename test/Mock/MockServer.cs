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
        public static TestServer CreateServer<TUser, TRole>()
            => CreateServer(CreateWebHostBuilder<TUser, TRole>());
        
        public static TestServer CreateServer<TUser, TRole>(Action<IdentityAdminOptions> options)
            => CreateServer(CreateWebHostBuilder<TUser, TRole>(options));
        
        public static TestServer CreateServer(IWebHostBuilder builder)
            => new TestServer(builder);

        public static IWebHostBuilder CreateWebHostBuilder<TUser, TRole>()
            => CreateWebHostBuilder<TUser, TRole>(options => { });
        
        public static IWebHostBuilder CreateWebHostBuilder<TUser, TRole>(Action<IdentityAdminOptions> options)
            => new WebHostBuilder()
               .ConfigureServices(services => services.AddIdentityAdmin<TUser, TRole>(options))
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