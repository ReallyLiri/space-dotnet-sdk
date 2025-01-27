using System;
using System.Linq;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

namespace _build
{
    [CheckBuildProjectConfigurations]
    [UnsetVisualStudioEnvironmentVariables]
    class Build : NukeBuild
    {
        public static int Main () => Execute<Build>(x => x.Package);

        [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
        readonly string Configuration = IsLocalBuild ? "Debug" : "Release";

        [Parameter("Space (Public) - NuGet target URL", Name = "JB_SPACE_PUBLIC_NUGET_URL")]
        readonly string? NuGetPublicSpaceTargetUrl;

        [Parameter("Space (Public) - NuGet target API key / access token", Name = "JB_SPACE_PUBLIC_CLIENT_TOKEN")]
        readonly string? NuGetPublicSpaceTargetApiKey;

        [Parameter("NuGet.org - NuGet target URL", Name = "JB_SPACE_NUGETORG_NUGET_URL")]
        readonly string? NuGetOrgTargetUrl;

        [Parameter("NuGet.org - NuGet target API key / access token", Name = "JB_SPACE_NUGETORG_CLIENT_TOKEN")]
        readonly string? NuGetOrgTargetApiKey;
    
        [Solution] readonly Solution? Solution;
        [VersionInfo(VersionMajor = 1, VersionMinor = 0, IsBeta = true)] readonly VersionInfo? VersionInfo;

        AbsolutePath SourceDirectory => RootDirectory / "src";
        AbsolutePath TestsDirectory => RootDirectory / "tests";
        AbsolutePath ArtifactsDirectory => RootDirectory / "artifacts";

        Target Clean => _ => _
            .Executes(() =>
            {
                SourceDirectory.GlobDirectories("**/bin", "**/obj").ForEach(DeleteDirectory);
                TestsDirectory.GlobDirectories("**/bin", "**/obj").ForEach(DeleteDirectory);
                EnsureCleanDirectory(ArtifactsDirectory);
            });

        Target Restore => _ => _
            .DependsOn(Clean)
            .Executes(() =>
            {
                DotNetRestore(_ => _
                    .SetProjectFile(Solution));
            });

        Target Compile => _ => _
            .DependsOn(Restore)
            .Executes(() =>
            {
                DotNetBuild(_ => _
                    .SetProjectFile(Solution)
                    .SetConfiguration(Configuration)
                    .SetAssemblyVersion(VersionInfo.AssemblySemVer)
                    .SetFileVersion(VersionInfo.AssemblySemFileVer)
                    .SetInformationalVersion(VersionInfo.InformationalVersion)
                    .SetVersion(VersionInfo.NuGetVersion)
                    .SetProperty("GeneratePackageOnBuild", "False")
                    .EnableNoRestore());
            });

        Target Test => _ => _
            .DependsOn(Compile)
            .Executes(() =>
            {
                DotNetTest(_ => _
                    .SetProjectFile(Solution)
                    .SetConfiguration(Configuration)
                    .EnableNoRestore()
                    .EnableNoBuild());
            });

        Target Package => _ => _
            .DependsOn(Test)
            .Executes(() =>
            {
                foreach (var project in Solution.AllProjects.Where(p => p.GetProperty<bool>("GeneratePackageOnBuild")).ToList())
                {
                    DotNetPack(_ => _
                        .SetProject(project)
                        .SetConfiguration(Configuration)
                        .EnableIncludeSource()
                        .EnableIncludeSymbols()
                        .EnableNoRestore()
                        .EnableNoBuild()
                        .SetVersion(VersionInfo.NuGetVersion)
                        .SetOutputDirectory(ArtifactsDirectory));
                }
            });

        Target PushPackagesToPublicSpace => _ => _
            .TriggeredBy(Package)
            .OnlyWhenStatic(() =>
                !string.IsNullOrEmpty(NuGetPublicSpaceTargetUrl) &&
                !string.IsNullOrEmpty(NuGetPublicSpaceTargetApiKey) &&
                NuGetPublicSpaceTargetUrl != " ")
            .WhenSkipped(DependencyBehavior.Execute)
            .Executes(() =>
            {
                var packages = ArtifactsDirectory.GlobFiles("*.nupkg");
            
                DotNetNuGetPush(_ => _
                        .SetSource(NuGetPublicSpaceTargetUrl)
                        .SetApiKey(NuGetPublicSpaceTargetApiKey)
                        .CombineWith(packages, (_, v) => _
                            .SetTargetPath(v)),
                    degreeOfParallelism: 5,
                    completeOnFailure: true);
            });

        Target PushPackagesToNuGetOrg => _ => _
            .TriggeredBy(Package)
            .OnlyWhenStatic(() =>
                (Environment.GetEnvironmentVariable("JB_SPACE_GIT_BRANCH") ?? "").Contains("main", StringComparison.OrdinalIgnoreCase) &&
                !string.IsNullOrEmpty(NuGetOrgTargetUrl) &&
                !string.IsNullOrEmpty(NuGetOrgTargetApiKey) &&
                NuGetOrgTargetUrl != " ")
            .WhenSkipped(DependencyBehavior.Execute)
            .Executes(() =>
            {
                var packages = ArtifactsDirectory.GlobFiles("*.nupkg", "*.snupkg");
            
                DotNetNuGetPush(_ => _
                        .SetSource(NuGetOrgTargetUrl)
                        .SetApiKey(NuGetOrgTargetApiKey)
                        .CombineWith(packages, (_, v) => _
                            .SetTargetPath(v)),
                    degreeOfParallelism: 5,
                    completeOnFailure: true);
            });
    }
}
