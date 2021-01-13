# restore-to-intellisense

Samples for the restore to intellisense demo

## MSBuild intro

* MSBuild is the build engine for .NET projects.
* MSBuild uses Properties and Items to specify what and how to compile things, and what to output. Everything really evolves around targets.
* MSBuild, default targets, build target.

6 passes

https://docs.microsoft.com/en-us/visualstudio/msbuild/msbuild?view=vs-2019
https://docs.microsoft.com/en-us/visualstudio/msbuild/msbuild-concepts?view=vs-2019
https://docs.microsoft.com/en-us/visualstudio/msbuild/build-process-overview?view=vs-2019#evaluation-phase

- 3 mins

## Packages.config

* Create a package config project, install a package.
* Code against it. 
* Unload the project, show the reference. 
* Cover packages.config installation...how the build works.

- 3 mins

## Project System intro

The project system is the interface between the project file and Visual Studio features.
https://github.com/microsoft/VSProjectSystem/
https://github.com/microsoft/VSProjectSystem/blob/master/doc/overview/intro.md
https://github.com/dotnet/project-system
https://github.com/dotnet/project-system/tree/master/docs
https://github.com/dotnet/project-system/blob/master/docs/design-time-builds.md

3 mins

- At this point, everyone should kind/sort of get the idea of how Visual Studio builds and how Visual Studio gets intellisense for assemblies.

## Packages.config vs PackageReference

In packages.config the references are directly to the files. 
PackageReference has an assets file. 

https://github.com/dotnet/roslyn/blob/master/docs/wiki/Roslyn-Overview.md


## PackageReference build

project.assets.json

https://docs.microsoft.com/en-us/visualstudio/msbuild/resolveassemblyreference-task?view=vs-2019

### Show an example with packages.config and intellisense.

### Show an example with PackageReference and intellisense. (Create 2 local repos)

.... Good stopping point for some questions. 

## Finally say let's learn how it works in PackageReference in details.


