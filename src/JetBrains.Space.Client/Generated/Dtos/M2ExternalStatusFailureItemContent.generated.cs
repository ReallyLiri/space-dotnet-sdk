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

public sealed class M2ExternalStatusFailureItemContent
     : M2ItemContentDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "M2ExternalStatusFailureItemContent";
    
    public M2ExternalStatusFailureItemContent() { }
    
    public M2ExternalStatusFailureItemContent(string repository, string branch, string url, string externalServiceName, string taskName, string? projectId = null, RevisionAuthorInfo? revisionInfo = null, LastChanges? changesInfo = null, long? timestamp = null, string? description = null)
    {
        ProjectId = projectId;
        Repository = repository;
        Branch = branch;
        RevisionInfo = revisionInfo;
        ChangesInfo = changesInfo;
        Url = url;
        ExternalServiceName = externalServiceName;
        TaskName = taskName;
        Timestamp = timestamp;
        Description = description;
    }
    
    private PropertyValue<string?> _projectId = new PropertyValue<string?>(nameof(M2ExternalStatusFailureItemContent), nameof(ProjectId));
    
    [JsonPropertyName("projectId")]
    public string? ProjectId
    {
        get => _projectId.GetValue();
        set => _projectId.SetValue(value);
    }

    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(M2ExternalStatusFailureItemContent), nameof(Repository));
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue();
        set => _repository.SetValue(value);
    }

    private PropertyValue<string> _branch = new PropertyValue<string>(nameof(M2ExternalStatusFailureItemContent), nameof(Branch));
    
    [Required]
    [JsonPropertyName("branch")]
    public string Branch
    {
        get => _branch.GetValue();
        set => _branch.SetValue(value);
    }

    private PropertyValue<RevisionAuthorInfo?> _revisionInfo = new PropertyValue<RevisionAuthorInfo?>(nameof(M2ExternalStatusFailureItemContent), nameof(RevisionInfo));
    
    [JsonPropertyName("revisionInfo")]
    public RevisionAuthorInfo? RevisionInfo
    {
        get => _revisionInfo.GetValue();
        set => _revisionInfo.SetValue(value);
    }

    private PropertyValue<LastChanges?> _changesInfo = new PropertyValue<LastChanges?>(nameof(M2ExternalStatusFailureItemContent), nameof(ChangesInfo));
    
    [JsonPropertyName("changesInfo")]
    public LastChanges? ChangesInfo
    {
        get => _changesInfo.GetValue();
        set => _changesInfo.SetValue(value);
    }

    private PropertyValue<string> _url = new PropertyValue<string>(nameof(M2ExternalStatusFailureItemContent), nameof(Url));
    
    [Required]
    [JsonPropertyName("url")]
    public string Url
    {
        get => _url.GetValue();
        set => _url.SetValue(value);
    }

    private PropertyValue<string> _externalServiceName = new PropertyValue<string>(nameof(M2ExternalStatusFailureItemContent), nameof(ExternalServiceName));
    
    [Required]
    [JsonPropertyName("externalServiceName")]
    public string ExternalServiceName
    {
        get => _externalServiceName.GetValue();
        set => _externalServiceName.SetValue(value);
    }

    private PropertyValue<string> _taskName = new PropertyValue<string>(nameof(M2ExternalStatusFailureItemContent), nameof(TaskName));
    
    [Required]
    [JsonPropertyName("taskName")]
    public string TaskName
    {
        get => _taskName.GetValue();
        set => _taskName.SetValue(value);
    }

    private PropertyValue<long?> _timestamp = new PropertyValue<long?>(nameof(M2ExternalStatusFailureItemContent), nameof(Timestamp));
    
    [JsonPropertyName("timestamp")]
    public long? Timestamp
    {
        get => _timestamp.GetValue();
        set => _timestamp.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(M2ExternalStatusFailureItemContent), nameof(Description));
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue();
        set => _description.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _projectId.SetAccessPath(path, validateHasBeenSet);
        _repository.SetAccessPath(path, validateHasBeenSet);
        _branch.SetAccessPath(path, validateHasBeenSet);
        _revisionInfo.SetAccessPath(path, validateHasBeenSet);
        _changesInfo.SetAccessPath(path, validateHasBeenSet);
        _url.SetAccessPath(path, validateHasBeenSet);
        _externalServiceName.SetAccessPath(path, validateHasBeenSet);
        _taskName.SetAccessPath(path, validateHasBeenSet);
        _timestamp.SetAccessPath(path, validateHasBeenSet);
        _description.SetAccessPath(path, validateHasBeenSet);
    }

}

