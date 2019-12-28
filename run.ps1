#./dotnet-install.ps1 -Channel Current -version 3.1.100
dotnet --version
dotnet restore
dotnet build -c Release
dotnet test
dotnet pack ./src/IdentityAdmin/src/Wangkanai.IdentityAdmin.csproj -c Release -o .\artifacts