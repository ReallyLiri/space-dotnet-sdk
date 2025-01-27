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

namespace JetBrains.Space.Client;

public class ProjectsVaultPostRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsVaultPostRequest() { }
    
    public ProjectsVaultPostRequest(ProjectIdentifier project, string url, string name, string appRoleEndpointPath, string appRoleId, string appRoleSecretIdBase64, string? @namespace = null, string? vaultNamespace = null)
    {
        Project = project;
        Url = url;
        Name = name;
        Namespace = @namespace;
        VaultNamespace = vaultNamespace;
        AppRoleEndpointPath = appRoleEndpointPath;
        AppRoleId = appRoleId;
        AppRoleSecretIdBase64 = appRoleSecretIdBase64;
    }
    
    private PropertyValue<ProjectIdentifier> _project = new PropertyValue<ProjectIdentifier>(nameof(ProjectsVaultPostRequest), nameof(Project), "project");
    
    [Required]
    [JsonPropertyName("project")]
    public ProjectIdentifier Project
    {
        get => _project.GetValue(InlineErrors);
        set => _project.SetValue(value);
    }

    private PropertyValue<string> _url = new PropertyValue<string>(nameof(ProjectsVaultPostRequest), nameof(Url), "url");
    
    [Required]
    [JsonPropertyName("url")]
    public string Url
    {
        get => _url.GetValue(InlineErrors);
        set => _url.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(ProjectsVaultPostRequest), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _namespace = new PropertyValue<string?>(nameof(ProjectsVaultPostRequest), nameof(Namespace), "namespace");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("namespace")]
    public string? Namespace
    {
        get => _namespace.GetValue(InlineErrors);
        set => _namespace.SetValue(value);
    }

    private PropertyValue<string?> _vaultNamespace = new PropertyValue<string?>(nameof(ProjectsVaultPostRequest), nameof(VaultNamespace), "vaultNamespace");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("vaultNamespace")]
    public string? VaultNamespace
    {
        get => _vaultNamespace.GetValue(InlineErrors);
        set => _vaultNamespace.SetValue(value);
    }

    private PropertyValue<string> _appRoleEndpointPath = new PropertyValue<string>(nameof(ProjectsVaultPostRequest), nameof(AppRoleEndpointPath), "appRoleEndpointPath");
    
    [Required]
    [JsonPropertyName("appRoleEndpointPath")]
    public string AppRoleEndpointPath
    {
        get => _appRoleEndpointPath.GetValue(InlineErrors);
        set => _appRoleEndpointPath.SetValue(value);
    }

    private PropertyValue<string> _appRoleId = new PropertyValue<string>(nameof(ProjectsVaultPostRequest), nameof(AppRoleId), "appRoleId");
    
    [Required]
    [JsonPropertyName("appRoleId")]
    public string AppRoleId
    {
        get => _appRoleId.GetValue(InlineErrors);
        set => _appRoleId.SetValue(value);
    }

    private PropertyValue<string> _appRoleSecretIdBase64 = new PropertyValue<string>(nameof(ProjectsVaultPostRequest), nameof(AppRoleSecretIdBase64), "appRoleSecretIdBase64");
    
    [Required]
    [JsonPropertyName("appRoleSecretIdBase64")]
    public string AppRoleSecretIdBase64
    {
        get => _appRoleSecretIdBase64.GetValue(InlineErrors);
        set => _appRoleSecretIdBase64.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _project.SetAccessPath(parentChainPath, validateHasBeenSet);
        _url.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _namespace.SetAccessPath(parentChainPath, validateHasBeenSet);
        _vaultNamespace.SetAccessPath(parentChainPath, validateHasBeenSet);
        _appRoleEndpointPath.SetAccessPath(parentChainPath, validateHasBeenSet);
        _appRoleId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _appRoleSecretIdBase64.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

