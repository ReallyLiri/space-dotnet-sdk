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

namespace SpaceDotNet.Client.CalendarsMeetingsPostRequestPartialBuilder
{
    public static class CalendarsMeetingsPostRequestPartialExtensions
    {
        public static Partial<CalendarsMeetingsPostRequest> WithSummary(this Partial<CalendarsMeetingsPostRequest> it)
            => it.AddFieldName("summary");
        
        public static Partial<CalendarsMeetingsPostRequest> WithDescription(this Partial<CalendarsMeetingsPostRequest> it)
            => it.AddFieldName("description");
        
        public static Partial<CalendarsMeetingsPostRequest> WithOccurrenceRule(this Partial<CalendarsMeetingsPostRequest> it)
            => it.AddFieldName("occurrenceRule");
        
        public static Partial<CalendarsMeetingsPostRequest> WithOccurrenceRule(this Partial<CalendarsMeetingsPostRequest> it, Func<Partial<CalendarEventSpec>, Partial<CalendarEventSpec>> partialBuilder)
            => it.AddFieldName("occurrenceRule", partialBuilder(new Partial<CalendarEventSpec>(it)));
        
        public static Partial<CalendarsMeetingsPostRequest> WithLocations(this Partial<CalendarsMeetingsPostRequest> it)
            => it.AddFieldName("locations");
        
        public static Partial<CalendarsMeetingsPostRequest> WithProfiles(this Partial<CalendarsMeetingsPostRequest> it)
            => it.AddFieldName("profiles");
        
        public static Partial<CalendarsMeetingsPostRequest> WithExternalParticipants(this Partial<CalendarsMeetingsPostRequest> it)
            => it.AddFieldName("externalParticipants");
        
        public static Partial<CalendarsMeetingsPostRequest> WithTeams(this Partial<CalendarsMeetingsPostRequest> it)
            => it.AddFieldName("teams");
        
        public static Partial<CalendarsMeetingsPostRequest> WithVisibility(this Partial<CalendarsMeetingsPostRequest> it)
            => it.AddFieldName("visibility");
        
        public static Partial<CalendarsMeetingsPostRequest> WithVisibility(this Partial<CalendarsMeetingsPostRequest> it, Func<Partial<MeetingVisibility>, Partial<MeetingVisibility>> partialBuilder)
            => it.AddFieldName("visibility", partialBuilder(new Partial<MeetingVisibility>(it)));
        
        public static Partial<CalendarsMeetingsPostRequest> WithModificationPreference(this Partial<CalendarsMeetingsPostRequest> it)
            => it.AddFieldName("modificationPreference");
        
        public static Partial<CalendarsMeetingsPostRequest> WithModificationPreference(this Partial<CalendarsMeetingsPostRequest> it, Func<Partial<MeetingModificationPreference>, Partial<MeetingModificationPreference>> partialBuilder)
            => it.AddFieldName("modificationPreference", partialBuilder(new Partial<MeetingModificationPreference>(it)));
        
        public static Partial<CalendarsMeetingsPostRequest> WithJoiningPreference(this Partial<CalendarsMeetingsPostRequest> it)
            => it.AddFieldName("joiningPreference");
        
        public static Partial<CalendarsMeetingsPostRequest> WithJoiningPreference(this Partial<CalendarsMeetingsPostRequest> it, Func<Partial<MeetingJoiningPreference>, Partial<MeetingJoiningPreference>> partialBuilder)
            => it.AddFieldName("joiningPreference", partialBuilder(new Partial<MeetingJoiningPreference>(it)));
        
        public static Partial<CalendarsMeetingsPostRequest> WithIsNotifyOnExport(this Partial<CalendarsMeetingsPostRequest> it)
            => it.AddFieldName("notifyOnExport");
        
        public static Partial<CalendarsMeetingsPostRequest> WithOrganizer(this Partial<CalendarsMeetingsPostRequest> it)
            => it.AddFieldName("organizer");
        
    }
    
}
