# Mtd.Core

## Using this Package Locally

### Create NuGet.config

To use this package you must add MTD's GitHub NuGet feed as a source. To do so,
add a `NuGet.config` file to the root of your project
with the following content:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
 <packageRestore>
  <add key="enabled" value="True" />
  <add key="automatic" value="True" />
 </packageRestore>
 <packageSources>
  <clear />
  <add key="nuget.org" value="https://api.nuget.org/v3/index.json" />
  <add key="github" value="https://nuget.pkg.github.com/CUMTD/index.json" />
 </packageSources>
 <packageSourceCredentials>
  <github>
   <add key="Username" value="%MtdGithubUserName%" />
   <add key="ClearTextPassword" value="%MtdGithubAccessToken%" />
  </github>
 </packageSourceCredentials>
 <packageSourceMapping>
  <packageSource key="nuget.org">
   <package pattern="*" />
  </packageSource>
  <packageSource key="github">
   <package pattern="Mtd.*" />
  </packageSource>
 </packageSourceMapping>
 <disabledPackageSources />
 <activePackageSource>
  <add key="All" value="(Aggregate source)" />
 </activePackageSource>
</configuration>
```

### Generate a personal access token

After adding the nuget config file, you must add environment variables
to authenticate with GitHub. To do so, you need a personal access Token.
You will need a unique token for each local machine on which you do development.

1. In GitHub, navigate to _[Settings > Developer Settings > Personal Access Tokens > Tokens (Classic)](https://github.com/settings/tokens)_.
Select _Generate New Token > Generate New Token (Classic)_.
2. Create a token with the `read:packages` permission.
3. Take note of the generated token.

**Note**: Make sure you are going to your personal settings not the organization settings.

### Set Environment Variables

The final step to get going locally is to tell your environment about your personal access token.

From PowerShell, run the following commands:

```powershell
setx MtdGithubUserName <YOUR_GITHUB_USERNAME>
setx MtdGithubAccessToken <YOUR_PERSONAL_ACCESS_TOKEN> 
```

## Using this Package in a GitHub Action


You can use the `secrets.GITHUB_TOKEN` token to access this repository
in another project.
A sample YML is below:

```yml
# This workflow will build a .NET project
# For more information see: https://docs.github.com/en/actions/automating-builds-and-tests/building-and-testing-net

name: .NET Build and Test

on:
  workflow_dispatch:
  push:
    branches: ['main']
  pull_request:
    branches: ['main']

jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      packages: read
    env:
      MtdGithubUserName: CUMTD
      MtdGithubAccessToken: ${{ secrets.GITHUB_TOKEN }}
    steps:
      - uses: actions/checkout@v3
      - name: Setup .NET
        uses: actions/setup-dotnet@v3
        with:
          dotnet-version: 8.0.x
      - name: Restore dependencies
        run: dotnet restore Mtd.Test.sln
      - name: Build
        run: dotnet build --no-restore Mtd.Test.sln
      - name: Test
        run: dotnet test --no-build --verbosity normal
```
