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

public sealed class PRProject
     : IPropagatePropertyAccessPath
{
    public PRProject() { }
    
    public PRProject(string id, ProjectKey key, string name, bool @private, bool archived, List<TDMemberProfile> adminProfiles, List<TDTeam> adminTeams, List<BoardRecord> boards, List<TDMemberProfile> collaboratorsProfiles, List<TDTeam> collaboratorsTeams, List<TDMemberProfile> externalUserProfiles, List<ProjectFeatureState> features, List<TDMemberProfile> memberProfiles, List<TDTeam> memberTeams, List<ProjectPackageRepository> packages, string projectId, List<PRRepositoryInfo> repos, List<string> tags, List<ProjectIssueTrackerItem> trackers, ProjectTeamType type, string? description = null, string? icon = null, DateTime? latestRepositoryActivity = null, List<ProjectTeamMemberRecord>? members = null, TDTeam? team = null, List<TDTeam>? teams = null)
    {
        Id = id;
        Key = key;
        Name = name;
        IsPrivate = @private;
        Description = description;
        Icon = icon;
        LatestRepositoryActivity = latestRepositoryActivity;
        IsArchived = archived;
        AdminProfiles = adminProfiles;
        AdminTeams = adminTeams;
        Boards = boards;
        CollaboratorsProfiles = collaboratorsProfiles;
        CollaboratorsTeams = collaboratorsTeams;
        ExternalUserProfiles = externalUserProfiles;
        Features = features;
        MemberProfiles = memberProfiles;
        MemberTeams = memberTeams;
        Members = members;
        Packages = packages;
        ProjectId = projectId;
        Repos = repos;
        Tags = tags;
        Team = team;
        Teams = teams;
        Trackers = trackers;
        Type = type;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(PRProject), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<ProjectKey> _key = new PropertyValue<ProjectKey>(nameof(PRProject), nameof(Key), "key");
    
    [Required]
    [JsonPropertyName("key")]
    public ProjectKey Key
    {
        get => _key.GetValue(InlineErrors);
        set => _key.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(PRProject), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<bool> _private = new PropertyValue<bool>(nameof(PRProject), nameof(IsPrivate), "private");
    
    [Required]
    [JsonPropertyName("private")]
    public bool IsPrivate
    {
        get => _private.GetValue(InlineErrors);
        set => _private.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(PRProject), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<string?> _icon = new PropertyValue<string?>(nameof(PRProject), nameof(Icon), "icon");
    
    [JsonPropertyName("icon")]
    public string? Icon
    {
        get => _icon.GetValue(InlineErrors);
        set => _icon.SetValue(value);
    }

    private PropertyValue<DateTime?> _latestRepositoryActivity = new PropertyValue<DateTime?>(nameof(PRProject), nameof(LatestRepositoryActivity), "latestRepositoryActivity");
    
    [JsonPropertyName("latestRepositoryActivity")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? LatestRepositoryActivity
    {
        get => _latestRepositoryActivity.GetValue(InlineErrors);
        set => _latestRepositoryActivity.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(PRProject), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<List<TDMemberProfile>> _adminProfiles = new PropertyValue<List<TDMemberProfile>>(nameof(PRProject), nameof(AdminProfiles), "adminProfiles", new List<TDMemberProfile>());
    
    [Required]
    [JsonPropertyName("adminProfiles")]
    public List<TDMemberProfile> AdminProfiles
    {
        get => _adminProfiles.GetValue(InlineErrors);
        set => _adminProfiles.SetValue(value);
    }

    private PropertyValue<List<TDTeam>> _adminTeams = new PropertyValue<List<TDTeam>>(nameof(PRProject), nameof(AdminTeams), "adminTeams", new List<TDTeam>());
    
    [Required]
    [JsonPropertyName("adminTeams")]
    public List<TDTeam> AdminTeams
    {
        get => _adminTeams.GetValue(InlineErrors);
        set => _adminTeams.SetValue(value);
    }

    private PropertyValue<List<BoardRecord>> _boards = new PropertyValue<List<BoardRecord>>(nameof(PRProject), nameof(Boards), "boards", new List<BoardRecord>());
    
    [Required]
    [JsonPropertyName("boards")]
    public List<BoardRecord> Boards
    {
        get => _boards.GetValue(InlineErrors);
        set => _boards.SetValue(value);
    }

    private PropertyValue<List<TDMemberProfile>> _collaboratorsProfiles = new PropertyValue<List<TDMemberProfile>>(nameof(PRProject), nameof(CollaboratorsProfiles), "collaboratorsProfiles", new List<TDMemberProfile>());
    
    [Required]
    [JsonPropertyName("collaboratorsProfiles")]
    public List<TDMemberProfile> CollaboratorsProfiles
    {
        get => _collaboratorsProfiles.GetValue(InlineErrors);
        set => _collaboratorsProfiles.SetValue(value);
    }

    private PropertyValue<List<TDTeam>> _collaboratorsTeams = new PropertyValue<List<TDTeam>>(nameof(PRProject), nameof(CollaboratorsTeams), "collaboratorsTeams", new List<TDTeam>());
    
    [Required]
    [JsonPropertyName("collaboratorsTeams")]
    public List<TDTeam> CollaboratorsTeams
    {
        get => _collaboratorsTeams.GetValue(InlineErrors);
        set => _collaboratorsTeams.SetValue(value);
    }

    private PropertyValue<List<TDMemberProfile>> _externalUserProfiles = new PropertyValue<List<TDMemberProfile>>(nameof(PRProject), nameof(ExternalUserProfiles), "externalUserProfiles", new List<TDMemberProfile>());
    
    [Required]
    [JsonPropertyName("externalUserProfiles")]
    public List<TDMemberProfile> ExternalUserProfiles
    {
        get => _externalUserProfiles.GetValue(InlineErrors);
        set => _externalUserProfiles.SetValue(value);
    }

    private PropertyValue<List<ProjectFeatureState>> _features = new PropertyValue<List<ProjectFeatureState>>(nameof(PRProject), nameof(Features), "features", new List<ProjectFeatureState>());
    
    [Required]
    [JsonPropertyName("features")]
    public List<ProjectFeatureState> Features
    {
        get => _features.GetValue(InlineErrors);
        set => _features.SetValue(value);
    }

    private PropertyValue<List<TDMemberProfile>> _memberProfiles = new PropertyValue<List<TDMemberProfile>>(nameof(PRProject), nameof(MemberProfiles), "memberProfiles", new List<TDMemberProfile>());
    
    [Required]
    [JsonPropertyName("memberProfiles")]
    public List<TDMemberProfile> MemberProfiles
    {
        get => _memberProfiles.GetValue(InlineErrors);
        set => _memberProfiles.SetValue(value);
    }

    private PropertyValue<List<TDTeam>> _memberTeams = new PropertyValue<List<TDTeam>>(nameof(PRProject), nameof(MemberTeams), "memberTeams", new List<TDTeam>());
    
    [Required]
    [JsonPropertyName("memberTeams")]
    public List<TDTeam> MemberTeams
    {
        get => _memberTeams.GetValue(InlineErrors);
        set => _memberTeams.SetValue(value);
    }

    private PropertyValue<List<ProjectTeamMemberRecord>?> _members = new PropertyValue<List<ProjectTeamMemberRecord>?>(nameof(PRProject), nameof(Members), "members");
    
    [JsonPropertyName("members")]
    public List<ProjectTeamMemberRecord>? Members
    {
        get => _members.GetValue(InlineErrors);
        set => _members.SetValue(value);
    }

    private PropertyValue<List<ProjectPackageRepository>> _packages = new PropertyValue<List<ProjectPackageRepository>>(nameof(PRProject), nameof(Packages), "packages", new List<ProjectPackageRepository>());
    
    [Required]
    [JsonPropertyName("packages")]
    public List<ProjectPackageRepository> Packages
    {
        get => _packages.GetValue(InlineErrors);
        set => _packages.SetValue(value);
    }

    private PropertyValue<string> _projectId = new PropertyValue<string>(nameof(PRProject), nameof(ProjectId), "projectId");
    
    [Required]
    [JsonPropertyName("projectId")]
    public string ProjectId
    {
        get => _projectId.GetValue(InlineErrors);
        set => _projectId.SetValue(value);
    }

    private PropertyValue<List<PRRepositoryInfo>> _repos = new PropertyValue<List<PRRepositoryInfo>>(nameof(PRProject), nameof(Repos), "repos", new List<PRRepositoryInfo>());
    
    [Required]
    [JsonPropertyName("repos")]
    public List<PRRepositoryInfo> Repos
    {
        get => _repos.GetValue(InlineErrors);
        set => _repos.SetValue(value);
    }

    private PropertyValue<List<string>> _tags = new PropertyValue<List<string>>(nameof(PRProject), nameof(Tags), "tags", new List<string>());
    
    [Required]
    [JsonPropertyName("tags")]
    public List<string> Tags
    {
        get => _tags.GetValue(InlineErrors);
        set => _tags.SetValue(value);
    }

    private PropertyValue<TDTeam?> _team = new PropertyValue<TDTeam?>(nameof(PRProject), nameof(Team), "team");
    
    [JsonPropertyName("team")]
    public TDTeam? Team
    {
        get => _team.GetValue(InlineErrors);
        set => _team.SetValue(value);
    }

    private PropertyValue<List<TDTeam>?> _teams = new PropertyValue<List<TDTeam>?>(nameof(PRProject), nameof(Teams), "teams");
    
    [JsonPropertyName("teams")]
    public List<TDTeam>? Teams
    {
        get => _teams.GetValue(InlineErrors);
        set => _teams.SetValue(value);
    }

    private PropertyValue<List<ProjectIssueTrackerItem>> _trackers = new PropertyValue<List<ProjectIssueTrackerItem>>(nameof(PRProject), nameof(Trackers), "trackers", new List<ProjectIssueTrackerItem>());
    
    [Required]
    [JsonPropertyName("trackers")]
    public List<ProjectIssueTrackerItem> Trackers
    {
        get => _trackers.GetValue(InlineErrors);
        set => _trackers.SetValue(value);
    }

    private PropertyValue<ProjectTeamType> _type = new PropertyValue<ProjectTeamType>(nameof(PRProject), nameof(Type), "type");
    
    [Required]
    [JsonPropertyName("type")]
    public ProjectTeamType Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _key.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _private.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _icon.SetAccessPath(parentChainPath, validateHasBeenSet);
        _latestRepositoryActivity.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _adminProfiles.SetAccessPath(parentChainPath, validateHasBeenSet);
        _adminTeams.SetAccessPath(parentChainPath, validateHasBeenSet);
        _boards.SetAccessPath(parentChainPath, validateHasBeenSet);
        _collaboratorsProfiles.SetAccessPath(parentChainPath, validateHasBeenSet);
        _collaboratorsTeams.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalUserProfiles.SetAccessPath(parentChainPath, validateHasBeenSet);
        _features.SetAccessPath(parentChainPath, validateHasBeenSet);
        _memberProfiles.SetAccessPath(parentChainPath, validateHasBeenSet);
        _memberTeams.SetAccessPath(parentChainPath, validateHasBeenSet);
        _members.SetAccessPath(parentChainPath, validateHasBeenSet);
        _packages.SetAccessPath(parentChainPath, validateHasBeenSet);
        _projectId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repos.SetAccessPath(parentChainPath, validateHasBeenSet);
        _tags.SetAccessPath(parentChainPath, validateHasBeenSet);
        _team.SetAccessPath(parentChainPath, validateHasBeenSet);
        _teams.SetAccessPath(parentChainPath, validateHasBeenSet);
        _trackers.SetAccessPath(parentChainPath, validateHasBeenSet);
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

