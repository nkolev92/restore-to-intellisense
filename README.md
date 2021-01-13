# Restore to intellisense

Samples for the restore to intellisense demo

## MSBuild

```xml
<Project>

  <PropertyGroup>
    <SpecialProp>..\..\special\path\custom.dll</SpecialProp>
  </PropertyGroup>

  <ItemGroup>
    <Reference Include="$(SpecialProp)" />
  </ItemGroup>

  <Target Name="BeforeBuild">
    <!-- Insert tasks to run before build here -->
  </Target>
</Project>
```

### MSBuild references

* [General MSBuild docs](https://docs.microsoft.com/en-us/visualstudio/msbuild/msbuild?view=vs-2019)
* [MSBuild concepts](https://docs.microsoft.com/en-us/visualstudio/msbuild/msbuild-concepts?view=vs-2019)
* [MSBuild evaluation](https://docs.microsoft.com/en-us/visualstudio/msbuild/build-process-overview?view=vs-2019#evaluation-phase)

## Packages.config

* The original NuGet package management style.
* Built on basic MSBuild concepts such as `Reference`.
* `Build` process is unaware of NuGet.

## PackageReference Build

* PackageReference has an assets file, instead of hardcoding the assemblies in the project file.

```xml
<Project>
...
    <ItemGroup>
        <PackageReference Include="NuGet.Common" Version="5.8.0" />
    </ItemGroup>
...
</Project>
```

## Project System

The project system is the interface between the project file and Visual Studio features.

Design time builds are minimal builds that gather enough information to populate:

* Language service (roslyn)
* Solution explorer

### Project System references

[CPS](https://github.com/microsoft/VSProjectSystem/)
[CPS Intro](https://github.com/microsoft/VSProjectSystem/blob/master/doc/overview/intro.md)
[.NET Project System](https://github.com/dotnet/project-system)
[.NET Project System general docs](https://github.com/dotnet/project-system/tree/master/docs)
[.NET Project System design time build details](https://github.com/dotnet/project-system/blob/master/docs/design-time-builds.md)

## PackageReference, Automatic restore and `intellisense stage` in .NET Managed languages project system
