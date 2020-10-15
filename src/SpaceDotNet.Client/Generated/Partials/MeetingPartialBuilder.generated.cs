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

namespace SpaceDotNet.Client.MeetingPartialBuilder
{
    public static class MeetingPartialExtensions
    {
        public static Partial<Meeting> WithId(this Partial<Meeting> it)
            => it.AddFieldName("id");
        
        public static Partial<Meeting> WithIsArchived(this Partial<Meeting> it)
            => it.AddFieldName("archived");
        
        public static Partial<Meeting> WithSummary(this Partial<Meeting> it)
            => it.AddFieldName("summary");
        
        public static Partial<Meeting> WithDescription(this Partial<Meeting> it)
            => it.AddFieldName("description");
        
        public static Partial<Meeting> WithLocations(this Partial<Meeting> it)
            => it.AddFieldName("locations");
        
        public static Partial<Meeting> WithLocations(this Partial<Meeting> it, Func<Partial<TDLocation>, Partial<TDLocation>> partialBuilder)
            => it.AddFieldName("locations", partialBuilder(new Partial<TDLocation>(it)));
        
        public static Partial<Meeting> WithProfiles(this Partial<Meeting> it)
            => it.AddFieldName("profiles");
        
        public static Partial<Meeting> WithProfiles(this Partial<Meeting> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("profiles", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<Meeting> WithTeams(this Partial<Meeting> it)
            => it.AddFieldName("teams");
        
        public static Partial<Meeting> WithTeams(this Partial<Meeting> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("teams", partialBuilder(new Partial<TDTeam>(it)));
        
        public static Partial<Meeting> WithOccurrenceRule(this Partial<Meeting> it)
            => it.AddFieldName("occurrenceRule");
        
        public static Partial<Meeting> WithOccurrenceRule(this Partial<Meeting> it, Func<Partial<CalendarEventSpec>, Partial<CalendarEventSpec>> partialBuilder)
            => it.AddFieldName("occurrenceRule", partialBuilder(new Partial<CalendarEventSpec>(it)));
        
        public static Partial<Meeting> WithOrigin(this Partial<Meeting> it)
            => it.AddFieldName("origin");
        
        public static Partial<Meeting> WithOrigin(this Partial<Meeting> it, Func<Partial<MeetingOrigin>, Partial<MeetingOrigin>> partialBuilder)
            => it.AddFieldName("origin", partialBuilder(new Partial<MeetingOrigin>(it)));
        
        public static Partial<Meeting> WithConferenceLink(this Partial<Meeting> it)
            => it.AddFieldName("conferenceLink");
        
        public static Partial<Meeting> WithVisibility(this Partial<Meeting> it)
            => it.AddFieldName("visibility");
        
        public static Partial<Meeting> WithVisibility(this Partial<Meeting> it, Func<Partial<MeetingVisibility>, Partial<MeetingVisibility>> partialBuilder)
            => it.AddFieldName("visibility", partialBuilder(new Partial<MeetingVisibility>(it)));
        
        public static Partial<Meeting> WithModificationPreference(this Partial<Meeting> it)
            => it.AddFieldName("modificationPreference");
        
        public static Partial<Meeting> WithModificationPreference(this Partial<Meeting> it, Func<Partial<MeetingModificationPreference>, Partial<MeetingModificationPreference>> partialBuilder)
            => it.AddFieldName("modificationPreference", partialBuilder(new Partial<MeetingModificationPreference>(it)));
        
        public static Partial<Meeting> WithJoiningPreference(this Partial<Meeting> it)
            => it.AddFieldName("joiningPreference");
        
        public static Partial<Meeting> WithJoiningPreference(this Partial<Meeting> it, Func<Partial<MeetingJoiningPreference>, Partial<MeetingJoiningPreference>> partialBuilder)
            => it.AddFieldName("joiningPreference", partialBuilder(new Partial<MeetingJoiningPreference>(it)));
        
        public static Partial<Meeting> WithOrganizer(this Partial<Meeting> it)
            => it.AddFieldName("organizer");
        
        public static Partial<Meeting> WithOrganizer(this Partial<Meeting> it, Func<Partial<MeetingOrganizer>, Partial<MeetingOrganizer>> partialBuilder)
            => it.AddFieldName("organizer", partialBuilder(new Partial<MeetingOrganizer>(it)));
        
        public static Partial<Meeting> WithEtag(this Partial<Meeting> it)
            => it.AddFieldName("etag");
        
        public static Partial<Meeting> WithIsPrivateDataSubstituted(this Partial<Meeting> it)
            => it.AddFieldName("privateDataSubstituted");
        
        public static Partial<Meeting> WithCanModify(this Partial<Meeting> it)
            => it.AddFieldName("canModify");
        
        public static Partial<Meeting> WithCanDelete(this Partial<Meeting> it)
            => it.AddFieldName("canDelete");
        
        public static Partial<Meeting> WithCanJoin(this Partial<Meeting> it)
            => it.AddFieldName("canJoin");
        
        public static Partial<Meeting> WithExternalParticipants(this Partial<Meeting> it)
            => it.AddFieldName("externalParticipants");
        
        public static Partial<Meeting> WithLinkToExternalSource(this Partial<Meeting> it)
            => it.AddFieldName("linkToExternalSource");
        
        public static Partial<Meeting> WithEventAttachments(this Partial<Meeting> it)
            => it.AddFieldName("eventAttachments");
        
        public static Partial<Meeting> WithEventAttachments(this Partial<Meeting> it, Func<Partial<MeetingAttachment>, Partial<MeetingAttachment>> partialBuilder)
            => it.AddFieldName("eventAttachments", partialBuilder(new Partial<MeetingAttachment>(it)));
        
    }
    
}
