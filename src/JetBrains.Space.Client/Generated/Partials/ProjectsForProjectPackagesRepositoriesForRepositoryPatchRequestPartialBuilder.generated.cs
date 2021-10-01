// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequestPartialBuilder;

public static class ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequestPartialExtensions
{
    public static Partial<ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest> WithName(this Partial<ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest> it)
        => it.AddFieldName("name");
    
    public static Partial<ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest> WithDescription(this Partial<ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest> it)
        => it.AddFieldName("description");
    
    public static Partial<ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest> WithIsPublic(this Partial<ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest> it)
        => it.AddFieldName("public");
    
    public static Partial<ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest> WithSettings(this Partial<ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest> it)
        => it.AddFieldName("settings");
    
    public static Partial<ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest> WithSettings(this Partial<ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest> it, Func<Partial<ESPackageRepositorySettings>, Partial<ESPackageRepositorySettings>> partialBuilder)
        => it.AddFieldName("settings", partialBuilder(new Partial<ESPackageRepositorySettings>(it)));
    
}

