

# Dotnet core & angular
<!-- TOC -->

- [Dotnet core & angular](#dotnet-core--angular)
    - [Installation](#installation)
        - [Visual Studio 2017](#visual-studio-2017)
        - [Visual Studio Code Insiders](#visual-studio-code-insiders)
        - [Install SPA templates](#install-spa-templates)
    - [Debug with Visual studio code insiders](#debug-with-visual-studio-code-insiders)
    - [Install EF && EF CLI](#install-ef--ef-cli)
        - [Add Packages into csproj, then run `dotnet restore`](#add-packages-into-csproj-then-run-dotnet-restore)
        - [Generate DbContext class](#generate-dbcontext-class)

<!-- /TOC -->

## Installation

### Visual Studio 2017

[https://www.microsoft.com/net/core?WT.mc_id=Blog_CENews_Announce_CEA#windowsvs2017](https://www.microsoft.com/net/core?WT.mc_id=Blog_CENews_Announce_CEA#windowsvs2017)

### Visual Studio Code Insiders

[https://code.visualstudio.com/insiders](https://code.visualstudio.com/insiders)

[https://www.microsoft.com/net/core?WT.mc_id=Blog_CENews_Announce_CEA#windowscmd](https://www.microsoft.com/net/core?WT.mc_id=Blog_CENews_Announce_CEA#windowscmd)

### Install SPA templates

`dotnet new –-install Microsoft.AspNet.Core.SpaServices::*`

`dotnet new angular`

## Debug with Visual studio code insiders

No extra config, click `Debug`, it will take care everything else.
If there are some errors, remove the folder `.vscode`, then click `Debug` again.


## Install EF && EF CLI

### Add Packages into csproj, then run `dotnet restore` 

```diff
     <PackageReference Include="Microsoft.AspNetCore.SpaServices" Version="1.1.1" />
      <PackageReference Include="Microsoft.AspNetCore.StaticFiles" Version="1.1.0" />		      <PackageReference Include="Microsoft.AspNetCore.StaticFiles" Version="1.1.0" />
      <PackageReference Include="Microsoft.Extensions.Logging.Debug" Version="1.1.0" />		      <PackageReference Include="Microsoft.Extensions.Logging.Debug" Version="1.1.0" />
 +    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="1.1.2" />
 +    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="1.1.2" />
 +    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer.Design" Version="1.1.2" />
 +  </ItemGroup>
 +  <ItemGroup>
 +    <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="1.0.0" />
 +    <DotNetCliToolReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Tools" Version="1.0.0" />
    </ItemGroup>		    </ItemGroup>
    <ItemGroup>		    <ItemGroup>
      <!-- Files not to show in IDE -->		      <!-- Files not to show in IDE -->
```

### Generate DbContext class 

```
dotnet ef dbcontext scaffold  "Server=(local);Database=TestDb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -c TestDbContext -p coreangular.csproj
```