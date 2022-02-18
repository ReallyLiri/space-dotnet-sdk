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

namespace JetBrains.Space.Client.ProjectsVaultForIdPatchRequestPartialBuilder;

public static class ProjectsVaultForIdPatchRequestPartialExtensions
{
    public static Partial<ProjectsVaultForIdPatchRequest> WithUrl(this Partial<ProjectsVaultForIdPatchRequest> it)
        => it.AddFieldName("url");
    
    public static Partial<ProjectsVaultForIdPatchRequest> WithName(this Partial<ProjectsVaultForIdPatchRequest> it)
        => it.AddFieldName("name");
    
    public static Partial<ProjectsVaultForIdPatchRequest> WithNamespace(this Partial<ProjectsVaultForIdPatchRequest> it)
        => it.AddFieldName("namespace");
    
    public static Partial<ProjectsVaultForIdPatchRequest> WithVaultNamespace(this Partial<ProjectsVaultForIdPatchRequest> it)
        => it.AddFieldName("vaultNamespace");
    
    public static Partial<ProjectsVaultForIdPatchRequest> WithAppRoleEndpointPath(this Partial<ProjectsVaultForIdPatchRequest> it)
        => it.AddFieldName("appRoleEndpointPath");
    
    public static Partial<ProjectsVaultForIdPatchRequest> WithAppRoleId(this Partial<ProjectsVaultForIdPatchRequest> it)
        => it.AddFieldName("appRoleId");
    
    public static Partial<ProjectsVaultForIdPatchRequest> WithAppRoleSecretIdBase64(this Partial<ProjectsVaultForIdPatchRequest> it)
        => it.AddFieldName("appRoleSecretIdBase64");
    
}
