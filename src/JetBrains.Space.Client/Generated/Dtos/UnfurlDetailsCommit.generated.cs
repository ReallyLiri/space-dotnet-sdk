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

public sealed class UnfurlDetailsCommit
     : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "UnfurlDetailsCommit";
    
    public UnfurlDetailsCommit() { }
    
    public UnfurlDetailsCommit(PRProject project, string repository, string commitId, string message, DateTime commitDate, GitAuthorInfo author, TDMemberProfile? authorProfile = null, bool? hideAuthorAndDate = null, bool? withBranchTags = null)
    {
        Project = project;
        Repository = repository;
        CommitId = commitId;
        Message = message;
        CommitDate = commitDate;
        Author = author;
        AuthorProfile = authorProfile;
        IsHideAuthorAndDate = hideAuthorAndDate;
        IsWithBranchTags = withBranchTags;
    }
    
    private PropertyValue<PRProject> _project = new PropertyValue<PRProject>(nameof(UnfurlDetailsCommit), nameof(Project));
    
    [Required]
    [JsonPropertyName("project")]
    public PRProject Project
    {
        get => _project.GetValue();
        set => _project.SetValue(value);
    }

    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(UnfurlDetailsCommit), nameof(Repository));
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue();
        set => _repository.SetValue(value);
    }

    private PropertyValue<string> _commitId = new PropertyValue<string>(nameof(UnfurlDetailsCommit), nameof(CommitId));
    
    [Required]
    [JsonPropertyName("commitId")]
    public string CommitId
    {
        get => _commitId.GetValue();
        set => _commitId.SetValue(value);
    }

    private PropertyValue<string> _message = new PropertyValue<string>(nameof(UnfurlDetailsCommit), nameof(Message));
    
    [Required]
    [JsonPropertyName("message")]
    public string Message
    {
        get => _message.GetValue();
        set => _message.SetValue(value);
    }

    private PropertyValue<DateTime> _commitDate = new PropertyValue<DateTime>(nameof(UnfurlDetailsCommit), nameof(CommitDate));
    
    [Required]
    [JsonPropertyName("commitDate")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime CommitDate
    {
        get => _commitDate.GetValue();
        set => _commitDate.SetValue(value);
    }

    private PropertyValue<GitAuthorInfo> _author = new PropertyValue<GitAuthorInfo>(nameof(UnfurlDetailsCommit), nameof(Author));
    
    [Required]
    [JsonPropertyName("author")]
    public GitAuthorInfo Author
    {
        get => _author.GetValue();
        set => _author.SetValue(value);
    }

    private PropertyValue<TDMemberProfile?> _authorProfile = new PropertyValue<TDMemberProfile?>(nameof(UnfurlDetailsCommit), nameof(AuthorProfile));
    
    [JsonPropertyName("authorProfile")]
    public TDMemberProfile? AuthorProfile
    {
        get => _authorProfile.GetValue();
        set => _authorProfile.SetValue(value);
    }

    private PropertyValue<bool?> _hideAuthorAndDate = new PropertyValue<bool?>(nameof(UnfurlDetailsCommit), nameof(IsHideAuthorAndDate));
    
    [JsonPropertyName("hideAuthorAndDate")]
    public bool? IsHideAuthorAndDate
    {
        get => _hideAuthorAndDate.GetValue();
        set => _hideAuthorAndDate.SetValue(value);
    }

    private PropertyValue<bool?> _withBranchTags = new PropertyValue<bool?>(nameof(UnfurlDetailsCommit), nameof(IsWithBranchTags));
    
    [JsonPropertyName("withBranchTags")]
    public bool? IsWithBranchTags
    {
        get => _withBranchTags.GetValue();
        set => _withBranchTags.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _project.SetAccessPath(path, validateHasBeenSet);
        _repository.SetAccessPath(path, validateHasBeenSet);
        _commitId.SetAccessPath(path, validateHasBeenSet);
        _message.SetAccessPath(path, validateHasBeenSet);
        _commitDate.SetAccessPath(path, validateHasBeenSet);
        _author.SetAccessPath(path, validateHasBeenSet);
        _authorProfile.SetAccessPath(path, validateHasBeenSet);
        _hideAuthorAndDate.SetAccessPath(path, validateHasBeenSet);
        _withBranchTags.SetAccessPath(path, validateHasBeenSet);
    }

}

