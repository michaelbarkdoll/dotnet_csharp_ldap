# dotnet_csharp_ldap


Please find attached a sample dotnet core 2.1 console application with ldap authentication enabled.  Turns out dotnet core doesn't have cross-platform ldap support.  So I used a Novell LDAP library for the implementation since I plan to deploy the backend to linux servers.  The LDAP libraries provided by Novell are compatibility with both windows and linux.


You can read more about the library at:


https://www.novell.com/developer/ndk/ldap_libraries_for_c_sharp.html


Here is the nuget that I used:

https://www.nuget.org/packages/Ldap.NETStandard/


Version 1.0.3


Getting the code to work with C# was a bit interesting since I had to modify my .csproj file with the following lines:

```bash
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp2.0</TargetFramework>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="Ldap.NETStandard">
      <Version>1.0.3</Version> 
    </PackageReference>
  </ItemGroup>

</Project>
```

Then you run:
```shell
$ dotnet restore
$ dotnet run
```