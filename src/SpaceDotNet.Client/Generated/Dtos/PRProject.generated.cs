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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class PRProject
         : IPropagatePropertyAccessPath
    {
        public PRProject() { }
        
        public PRProject(string id, ProjectKey key, string name, bool @private, bool archived, List<TDMemberProfile> adminProfiles, List<TDTeam> adminTeams, List<BoardRecord> boards, List<TDMemberProfile> memberProfiles, List<TDTeam> memberTeams, List<ProjectPackageRepository> packages, List<PRRepositoryInfo> repos, List<string> tags, List<ProjectIssueTrackerItem> trackers, string? description = null, string? icon = null, DateTime? latestRepositoryActivity = null)
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
            MemberProfiles = memberProfiles;
            MemberTeams = memberTeams;
            Packages = packages;
            Repos = repos;
            Tags = tags;
            Trackers = trackers;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(PRProject), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<ProjectKey> _key = new PropertyValue<ProjectKey>(nameof(PRProject), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public ProjectKey Key
        {
            get { return _key.GetValue(); }
            set { _key.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(PRProject), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<bool> _private = new PropertyValue<bool>(nameof(PRProject), nameof(IsPrivate));
        
        [Required]
        [JsonPropertyName("private")]
        public bool IsPrivate
        {
            get { return _private.GetValue(); }
            set { _private.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(PRProject), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<string?> _icon = new PropertyValue<string?>(nameof(PRProject), nameof(Icon));
        
        [JsonPropertyName("icon")]
        public string? Icon
        {
            get { return _icon.GetValue(); }
            set { _icon.SetValue(value); }
        }
    
        private PropertyValue<DateTime?> _latestRepositoryActivity = new PropertyValue<DateTime?>(nameof(PRProject), nameof(LatestRepositoryActivity));
        
        [JsonPropertyName("latestRepositoryActivity")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? LatestRepositoryActivity
        {
            get { return _latestRepositoryActivity.GetValue(); }
            set { _latestRepositoryActivity.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(PRProject), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<List<TDMemberProfile>> _adminProfiles = new PropertyValue<List<TDMemberProfile>>(nameof(PRProject), nameof(AdminProfiles));
        
        [Required]
        [JsonPropertyName("adminProfiles")]
        public List<TDMemberProfile> AdminProfiles
        {
            get { return _adminProfiles.GetValue(); }
            set { _adminProfiles.SetValue(value); }
        }
    
        private PropertyValue<List<TDTeam>> _adminTeams = new PropertyValue<List<TDTeam>>(nameof(PRProject), nameof(AdminTeams));
        
        [Required]
        [JsonPropertyName("adminTeams")]
        public List<TDTeam> AdminTeams
        {
            get { return _adminTeams.GetValue(); }
            set { _adminTeams.SetValue(value); }
        }
    
        private PropertyValue<List<BoardRecord>> _boards = new PropertyValue<List<BoardRecord>>(nameof(PRProject), nameof(Boards));
        
        [Required]
        [JsonPropertyName("boards")]
        public List<BoardRecord> Boards
        {
            get { return _boards.GetValue(); }
            set { _boards.SetValue(value); }
        }
    
        private PropertyValue<List<TDMemberProfile>> _memberProfiles = new PropertyValue<List<TDMemberProfile>>(nameof(PRProject), nameof(MemberProfiles));
        
        [Required]
        [JsonPropertyName("memberProfiles")]
        public List<TDMemberProfile> MemberProfiles
        {
            get { return _memberProfiles.GetValue(); }
            set { _memberProfiles.SetValue(value); }
        }
    
        private PropertyValue<List<TDTeam>> _memberTeams = new PropertyValue<List<TDTeam>>(nameof(PRProject), nameof(MemberTeams));
        
        [Required]
        [JsonPropertyName("memberTeams")]
        public List<TDTeam> MemberTeams
        {
            get { return _memberTeams.GetValue(); }
            set { _memberTeams.SetValue(value); }
        }
    
        private PropertyValue<List<ProjectPackageRepository>> _packages = new PropertyValue<List<ProjectPackageRepository>>(nameof(PRProject), nameof(Packages));
        
        [Required]
        [JsonPropertyName("packages")]
        public List<ProjectPackageRepository> Packages
        {
            get { return _packages.GetValue(); }
            set { _packages.SetValue(value); }
        }
    
        private PropertyValue<List<PRRepositoryInfo>> _repos = new PropertyValue<List<PRRepositoryInfo>>(nameof(PRProject), nameof(Repos));
        
        [Required]
        [JsonPropertyName("repos")]
        public List<PRRepositoryInfo> Repos
        {
            get { return _repos.GetValue(); }
            set { _repos.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _tags = new PropertyValue<List<string>>(nameof(PRProject), nameof(Tags));
        
        [Required]
        [JsonPropertyName("tags")]
        public List<string> Tags
        {
            get { return _tags.GetValue(); }
            set { _tags.SetValue(value); }
        }
    
        private PropertyValue<List<ProjectIssueTrackerItem>> _trackers = new PropertyValue<List<ProjectIssueTrackerItem>>(nameof(PRProject), nameof(Trackers));
        
        [Required]
        [JsonPropertyName("trackers")]
        public List<ProjectIssueTrackerItem> Trackers
        {
            get { return _trackers.GetValue(); }
            set { _trackers.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _key.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _private.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _icon.SetAccessPath(path, validateHasBeenSet);
            _latestRepositoryActivity.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _adminProfiles.SetAccessPath(path, validateHasBeenSet);
            _adminTeams.SetAccessPath(path, validateHasBeenSet);
            _boards.SetAccessPath(path, validateHasBeenSet);
            _memberProfiles.SetAccessPath(path, validateHasBeenSet);
            _memberTeams.SetAccessPath(path, validateHasBeenSet);
            _packages.SetAccessPath(path, validateHasBeenSet);
            _repos.SetAccessPath(path, validateHasBeenSet);
            _tags.SetAccessPath(path, validateHasBeenSet);
            _trackers.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
