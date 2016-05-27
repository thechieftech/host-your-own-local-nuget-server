# Host your own local nuget server
Demo projects used in the "Host your own local nuget server" video tutorial.
Video tutorial on hosting your own private local nuget server can be found on YouTube. Video link below.  
[Host your own local nuget server video tutorial on YouTube](https://youtu.be/jucr187lEhI "Host your own local nuget server")

### Important information about this tutorial
Please note that this tutorial deals with hosting your own private, local nuget server, either on your machine or on a shared network drive. This particular demo does not cover hosting your own nuget server on your own web server. This is covered in different tutorial.

### Below are some of the Command Line commands I used in the video.
#### This command is used to package the project into a nuget package file.
```shell
nuget pack "C:\YourProjectRoot\YourProjectName.csproj"
```
#### This command is used to push your nuget package to your local nuget directory.
```shell
nuget push YourProjectName.1.0.0.nupkg -source "C:\LocalnugetDirectory"
```
### Here are the Post-Build scripts I used in the video.
```shell
nuget pack "$(ProjectPath)"
nuget push TheSharedLibrary.@(VersionNumber).nupkg -source "C:\LocalnugetDirectory"
```
### Below are the code snippets you will need for updating the project file XML.
#### This code snippet is the Target for the Macro.
```xml
<Target Name="PostBuildMacros">
  <GetAssemblyIdentity AssemblyFiles="$(TargetPath)">
    <Output TaskParameter="Assemblies" ItemName="Targets" />
  </GetAssemblyIdentity>
  <ItemGroup>
    <VersionNumber Include="@(Targets->'%(Version)')" />
  </ItemGroup>
</Target>
```
#### This code snippet is the Post-build script dependency declaration.
```xml
<PostBuildEventDependsOn>
  $(PostBuildEventDependsOn);
  PostBuildMacros;
</PostBuildEventDependsOn>
