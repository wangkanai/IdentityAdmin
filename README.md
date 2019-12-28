# About IdentityAdmin

[![Build status](https://ci.appveyor.com/api/projects/status/1cnnn2s61yqsoyup?svg=true)](https://ci.appveyor.com/project/wangkanai/IdentityAdmin) 
[![NuGet Badge](https://buildstats.info/nuget/wangkanai.IdentityAdmin)](https://www.nuget.org/packages/wangkanai.IdentityAdmin)
[![NuGet Badge](https://buildstats.info/nuget/wangkanai.IdentityAdmin?includePreReleases=true)](https://www.nuget.org/packages/wangkanai.IdentityAdmin)
[![MyGet Badge](https://buildstats.info/myget/wangkanai/Wangkanai.IdentityAdmin)](https://www.myget.org/feed/wangkanai/package/nuget/Wangkanai.IdentityAdmin)

IdentityAdmin is a free, open source administration portal for managing [IdentityServer](https://github.com/IdentityServer/). Founded and maintained by Sarin Na Wangkanai, IdentityAdmin will allow easier implementation of IdentityServer.

## Overview

Installation of IdentityAdmin

```powershell
PM> install-package Wangkanai.IdentityAdmin
```

Implement of the library into your web application is done by configuring the `Startup.cs` by adding the IdentityAdmin service in the `ConfigureServices` method.

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddControllersWithViews();

    services.AddIdentityAdmin();
}
```

Adding the IdentityAdmin middleware to the pipeline. The IdentityAdmin middleware is enabled in the `Configure` method of *Startup.cs* file.

```csharp
public void Configure(IApplicationBuilder app)
{
    app.UseIdentityAdmin();

    app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());
}
```

### Directory Structure
* `src` - The code of this project lives here
* `test` - Unit tests of this project to valid that everything pass specs

### Contributing

All contribution are welcome, please contact the author.