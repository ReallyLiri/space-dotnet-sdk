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
    public sealed class Meeting
         : IPropagatePropertyAccessPath
    {
        public Meeting() { }
        
        public Meeting(string id, bool archived, string summary, List<TDLocation> locations, List<TDMemberProfile> profiles, List<TDTeam> teams, CalendarEventSpec occurrenceRule, MeetingOrigin origin, MeetingVisibility visibility, MeetingModificationPreference modificationPreference, long etag, bool privateDataSubstituted, bool canModify, bool canDelete, bool canJoin, List<string> externalParticipants, string? description = null, string? conferenceLink = null, MeetingJoiningPreference? joiningPreference = null, MeetingOrganizer? organizer = null, string? linkToExternalSource = null, List<MeetingAttachment>? eventAttachments = null)
        {
            Id = id;
            IsArchived = archived;
            Summary = summary;
            Description = description;
            Locations = locations;
            Profiles = profiles;
            Teams = teams;
            OccurrenceRule = occurrenceRule;
            Origin = origin;
            ConferenceLink = conferenceLink;
            Visibility = visibility;
            ModificationPreference = modificationPreference;
            JoiningPreference = joiningPreference;
            Organizer = organizer;
            Etag = etag;
            IsPrivateDataSubstituted = privateDataSubstituted;
            CanModify = canModify;
            CanDelete = canDelete;
            CanJoin = canJoin;
            ExternalParticipants = externalParticipants;
            LinkToExternalSource = linkToExternalSource;
            EventAttachments = eventAttachments;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(Meeting), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(Meeting), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<string> _summary = new PropertyValue<string>(nameof(Meeting), nameof(Summary));
        
        [Required]
        [JsonPropertyName("summary")]
        public string Summary
        {
            get { return _summary.GetValue(); }
            set { _summary.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(Meeting), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<List<TDLocation>> _locations = new PropertyValue<List<TDLocation>>(nameof(Meeting), nameof(Locations));
        
        [Required]
        [JsonPropertyName("locations")]
        public List<TDLocation> Locations
        {
            get { return _locations.GetValue(); }
            set { _locations.SetValue(value); }
        }
    
        private PropertyValue<List<TDMemberProfile>> _profiles = new PropertyValue<List<TDMemberProfile>>(nameof(Meeting), nameof(Profiles));
        
        [Required]
        [JsonPropertyName("profiles")]
        public List<TDMemberProfile> Profiles
        {
            get { return _profiles.GetValue(); }
            set { _profiles.SetValue(value); }
        }
    
        private PropertyValue<List<TDTeam>> _teams = new PropertyValue<List<TDTeam>>(nameof(Meeting), nameof(Teams));
        
        [Required]
        [JsonPropertyName("teams")]
        public List<TDTeam> Teams
        {
            get { return _teams.GetValue(); }
            set { _teams.SetValue(value); }
        }
    
        private PropertyValue<CalendarEventSpec> _occurrenceRule = new PropertyValue<CalendarEventSpec>(nameof(Meeting), nameof(OccurrenceRule));
        
        [Required]
        [JsonPropertyName("occurrenceRule")]
        public CalendarEventSpec OccurrenceRule
        {
            get { return _occurrenceRule.GetValue(); }
            set { _occurrenceRule.SetValue(value); }
        }
    
        private PropertyValue<MeetingOrigin> _origin = new PropertyValue<MeetingOrigin>(nameof(Meeting), nameof(Origin));
        
        [Required]
        [JsonPropertyName("origin")]
        public MeetingOrigin Origin
        {
            get { return _origin.GetValue(); }
            set { _origin.SetValue(value); }
        }
    
        private PropertyValue<string?> _conferenceLink = new PropertyValue<string?>(nameof(Meeting), nameof(ConferenceLink));
        
        [JsonPropertyName("conferenceLink")]
        public string? ConferenceLink
        {
            get { return _conferenceLink.GetValue(); }
            set { _conferenceLink.SetValue(value); }
        }
    
        private PropertyValue<MeetingVisibility> _visibility = new PropertyValue<MeetingVisibility>(nameof(Meeting), nameof(Visibility));
        
        [Required]
        [JsonPropertyName("visibility")]
        public MeetingVisibility Visibility
        {
            get { return _visibility.GetValue(); }
            set { _visibility.SetValue(value); }
        }
    
        private PropertyValue<MeetingModificationPreference> _modificationPreference = new PropertyValue<MeetingModificationPreference>(nameof(Meeting), nameof(ModificationPreference));
        
        [Required]
        [JsonPropertyName("modificationPreference")]
        public MeetingModificationPreference ModificationPreference
        {
            get { return _modificationPreference.GetValue(); }
            set { _modificationPreference.SetValue(value); }
        }
    
        private PropertyValue<MeetingJoiningPreference?> _joiningPreference = new PropertyValue<MeetingJoiningPreference?>(nameof(Meeting), nameof(JoiningPreference));
        
        [JsonPropertyName("joiningPreference")]
        public MeetingJoiningPreference? JoiningPreference
        {
            get { return _joiningPreference.GetValue(); }
            set { _joiningPreference.SetValue(value); }
        }
    
        private PropertyValue<MeetingOrganizer?> _organizer = new PropertyValue<MeetingOrganizer?>(nameof(Meeting), nameof(Organizer));
        
        [JsonPropertyName("organizer")]
        public MeetingOrganizer? Organizer
        {
            get { return _organizer.GetValue(); }
            set { _organizer.SetValue(value); }
        }
    
        private PropertyValue<long> _etag = new PropertyValue<long>(nameof(Meeting), nameof(Etag));
        
        [Required]
        [JsonPropertyName("etag")]
        public long Etag
        {
            get { return _etag.GetValue(); }
            set { _etag.SetValue(value); }
        }
    
        private PropertyValue<bool> _privateDataSubstituted = new PropertyValue<bool>(nameof(Meeting), nameof(IsPrivateDataSubstituted));
        
        [Required]
        [JsonPropertyName("privateDataSubstituted")]
        public bool IsPrivateDataSubstituted
        {
            get { return _privateDataSubstituted.GetValue(); }
            set { _privateDataSubstituted.SetValue(value); }
        }
    
        private PropertyValue<bool> _canModify = new PropertyValue<bool>(nameof(Meeting), nameof(CanModify));
        
        [Required]
        [JsonPropertyName("canModify")]
        public bool CanModify
        {
            get { return _canModify.GetValue(); }
            set { _canModify.SetValue(value); }
        }
    
        private PropertyValue<bool> _canDelete = new PropertyValue<bool>(nameof(Meeting), nameof(CanDelete));
        
        [Required]
        [JsonPropertyName("canDelete")]
        public bool CanDelete
        {
            get { return _canDelete.GetValue(); }
            set { _canDelete.SetValue(value); }
        }
    
        private PropertyValue<bool> _canJoin = new PropertyValue<bool>(nameof(Meeting), nameof(CanJoin));
        
        [Required]
        [JsonPropertyName("canJoin")]
        public bool CanJoin
        {
            get { return _canJoin.GetValue(); }
            set { _canJoin.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _externalParticipants = new PropertyValue<List<string>>(nameof(Meeting), nameof(ExternalParticipants));
        
        [Required]
        [JsonPropertyName("externalParticipants")]
        public List<string> ExternalParticipants
        {
            get { return _externalParticipants.GetValue(); }
            set { _externalParticipants.SetValue(value); }
        }
    
        private PropertyValue<string?> _linkToExternalSource = new PropertyValue<string?>(nameof(Meeting), nameof(LinkToExternalSource));
        
        [JsonPropertyName("linkToExternalSource")]
        public string? LinkToExternalSource
        {
            get { return _linkToExternalSource.GetValue(); }
            set { _linkToExternalSource.SetValue(value); }
        }
    
        private PropertyValue<List<MeetingAttachment>?> _eventAttachments = new PropertyValue<List<MeetingAttachment>?>(nameof(Meeting), nameof(EventAttachments));
        
        [JsonPropertyName("eventAttachments")]
        public List<MeetingAttachment>? EventAttachments
        {
            get { return _eventAttachments.GetValue(); }
            set { _eventAttachments.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _summary.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _locations.SetAccessPath(path, validateHasBeenSet);
            _profiles.SetAccessPath(path, validateHasBeenSet);
            _teams.SetAccessPath(path, validateHasBeenSet);
            _occurrenceRule.SetAccessPath(path, validateHasBeenSet);
            _origin.SetAccessPath(path, validateHasBeenSet);
            _conferenceLink.SetAccessPath(path, validateHasBeenSet);
            _visibility.SetAccessPath(path, validateHasBeenSet);
            _modificationPreference.SetAccessPath(path, validateHasBeenSet);
            _joiningPreference.SetAccessPath(path, validateHasBeenSet);
            _organizer.SetAccessPath(path, validateHasBeenSet);
            _etag.SetAccessPath(path, validateHasBeenSet);
            _privateDataSubstituted.SetAccessPath(path, validateHasBeenSet);
            _canModify.SetAccessPath(path, validateHasBeenSet);
            _canDelete.SetAccessPath(path, validateHasBeenSet);
            _canJoin.SetAccessPath(path, validateHasBeenSet);
            _externalParticipants.SetAccessPath(path, validateHasBeenSet);
            _linkToExternalSource.SetAccessPath(path, validateHasBeenSet);
            _eventAttachments.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
