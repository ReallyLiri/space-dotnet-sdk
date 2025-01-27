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

public sealed class CommitSetReviewRecord
     : CodeReviewRecord, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "CommitSetReviewRecord";
    
    public CommitSetReviewRecord() { }
    
    public CommitSetReviewRecord(ProjectKey project, string projectId, int number, string title, CodeReviewState state, long createdAt, bool? canBeReopened = null, TDMemberProfile? createdBy = null, bool? turnBased = null, M2ChannelRecord? feedChannel = null, string? feedChannelId = null)
    {
        Project = project;
        ProjectId = projectId;
        Number = number;
        Title = title;
        State = state;
        CanBeReopened = canBeReopened;
        CreatedAt = createdAt;
        CreatedBy = createdBy;
        IsTurnBased = turnBased;
        FeedChannel = feedChannel;
        FeedChannelId = feedChannelId;
    }
    
    private PropertyValue<ProjectKey> _project = new PropertyValue<ProjectKey>(nameof(CommitSetReviewRecord), nameof(Project), "project");
    
    [Required]
    [JsonPropertyName("project")]
    public ProjectKey Project
    {
        get => _project.GetValue(InlineErrors);
        set => _project.SetValue(value);
    }

    private PropertyValue<string> _projectId = new PropertyValue<string>(nameof(CommitSetReviewRecord), nameof(ProjectId), "projectId");
    
    [Required]
    [JsonPropertyName("projectId")]
    public string ProjectId
    {
        get => _projectId.GetValue(InlineErrors);
        set => _projectId.SetValue(value);
    }

    private PropertyValue<int> _number = new PropertyValue<int>(nameof(CommitSetReviewRecord), nameof(Number), "number");
    
    [Required]
    [JsonPropertyName("number")]
    public int Number
    {
        get => _number.GetValue(InlineErrors);
        set => _number.SetValue(value);
    }

    private PropertyValue<string> _title = new PropertyValue<string>(nameof(CommitSetReviewRecord), nameof(Title), "title");
    
    [Required]
    [JsonPropertyName("title")]
    public string Title
    {
        get => _title.GetValue(InlineErrors);
        set => _title.SetValue(value);
    }

    private PropertyValue<CodeReviewState> _state = new PropertyValue<CodeReviewState>(nameof(CommitSetReviewRecord), nameof(State), "state");
    
    [Required]
    [JsonPropertyName("state")]
    public CodeReviewState State
    {
        get => _state.GetValue(InlineErrors);
        set => _state.SetValue(value);
    }

    private PropertyValue<bool?> _canBeReopened = new PropertyValue<bool?>(nameof(CommitSetReviewRecord), nameof(CanBeReopened), "canBeReopened");
    
    [JsonPropertyName("canBeReopened")]
    public bool? CanBeReopened
    {
        get => _canBeReopened.GetValue(InlineErrors);
        set => _canBeReopened.SetValue(value);
    }

    private PropertyValue<long> _createdAt = new PropertyValue<long>(nameof(CommitSetReviewRecord), nameof(CreatedAt), "createdAt");
    
    [Required]
    [JsonPropertyName("createdAt")]
    public long CreatedAt
    {
        get => _createdAt.GetValue(InlineErrors);
        set => _createdAt.SetValue(value);
    }

    private PropertyValue<TDMemberProfile?> _createdBy = new PropertyValue<TDMemberProfile?>(nameof(CommitSetReviewRecord), nameof(CreatedBy), "createdBy");
    
    [JsonPropertyName("createdBy")]
    public TDMemberProfile? CreatedBy
    {
        get => _createdBy.GetValue(InlineErrors);
        set => _createdBy.SetValue(value);
    }

    private PropertyValue<bool?> _turnBased = new PropertyValue<bool?>(nameof(CommitSetReviewRecord), nameof(IsTurnBased), "turnBased");
    
    [JsonPropertyName("turnBased")]
    public bool? IsTurnBased
    {
        get => _turnBased.GetValue(InlineErrors);
        set => _turnBased.SetValue(value);
    }

    private PropertyValue<M2ChannelRecord?> _feedChannel = new PropertyValue<M2ChannelRecord?>(nameof(CommitSetReviewRecord), nameof(FeedChannel), "feedChannel");
    
    [JsonPropertyName("feedChannel")]
    public M2ChannelRecord? FeedChannel
    {
        get => _feedChannel.GetValue(InlineErrors);
        set => _feedChannel.SetValue(value);
    }

    private PropertyValue<string?> _feedChannelId = new PropertyValue<string?>(nameof(CommitSetReviewRecord), nameof(FeedChannelId), "feedChannelId");
    
    [JsonPropertyName("feedChannelId")]
    public string? FeedChannelId
    {
        get => _feedChannelId.GetValue(InlineErrors);
        set => _feedChannelId.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _project.SetAccessPath(parentChainPath, validateHasBeenSet);
        _projectId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _number.SetAccessPath(parentChainPath, validateHasBeenSet);
        _title.SetAccessPath(parentChainPath, validateHasBeenSet);
        _state.SetAccessPath(parentChainPath, validateHasBeenSet);
        _canBeReopened.SetAccessPath(parentChainPath, validateHasBeenSet);
        _createdAt.SetAccessPath(parentChainPath, validateHasBeenSet);
        _createdBy.SetAccessPath(parentChainPath, validateHasBeenSet);
        _turnBased.SetAccessPath(parentChainPath, validateHasBeenSet);
        _feedChannel.SetAccessPath(parentChainPath, validateHasBeenSet);
        _feedChannelId.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

