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
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public partial class CalendarClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public CalendarClient(Connection connection)
        {
            _connection = connection;
        }
        
        public AbsenceEventClient AbsenceEvents => new AbsenceEventClient(_connection);
        
        public partial class AbsenceEventClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public AbsenceEventClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get/search absences. Parameters are applied as 'AND' filters.
            /// </summary>
            public async Task<List<AbsenceEvent>> GetAllAbsenceEventsAsync(DateTime dateFrom, DateTime dateTo, string? team = null, string? location = null, string? role = null, Func<Partial<AbsenceEvent>, Partial<AbsenceEvent>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<List<AbsenceEvent>>("GET", $"api/http/calendars/absence-events?dateFrom={dateFrom.ToString("yyyy-MM-dd")}&dateTo={dateTo.ToString("yyyy-MM-dd")}&team={team?.ToString() ?? "null"}&location={location?.ToString() ?? "null"}&role={role?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<AbsenceEvent>()) : Partial<AbsenceEvent>.Default())}", cancellationToken);
        
        }
    
        public BirthdayEventClient BirthdayEvents => new BirthdayEventClient(_connection);
        
        public partial class BirthdayEventClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public BirthdayEventClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get/search birthdays. Parameters are applied as 'AND' filters.
            /// </summary>
            public async Task<List<BirthdayEvent>> GetAllBirthdayEventsAsync(DateTime dateFrom, DateTime dateTo, string? team = null, string? location = null, string? role = null, Func<Partial<BirthdayEvent>, Partial<BirthdayEvent>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<List<BirthdayEvent>>("GET", $"api/http/calendars/birthday-events?dateFrom={dateFrom.ToString("yyyy-MM-dd")}&dateTo={dateTo.ToString("yyyy-MM-dd")}&team={team?.ToString() ?? "null"}&location={location?.ToString() ?? "null"}&role={role?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<BirthdayEvent>()) : Partial<BirthdayEvent>.Default())}", cancellationToken);
        
            public StarredClient Starred => new StarredClient(_connection);
            
            public partial class StarredClient : ISpaceClient
            {
                private readonly Connection _connection;
                
                public StarredClient(Connection connection)
                {
                    _connection = connection;
                }
                
                /// <summary>
                /// Get/search birthdays in a specific time period for starred profiles.
                /// </summary>
                public async Task<List<BirthdayEvent>> GetAllStarredBirthdayEventsAsync(DateTime dateFrom, DateTime dateTo, Func<Partial<BirthdayEvent>, Partial<BirthdayEvent>>? partial = null, CancellationToken cancellationToken = default)
                    => await _connection.RequestResourceAsync<List<BirthdayEvent>>("GET", $"api/http/calendars/birthday-events/starred?dateFrom={dateFrom.ToString("yyyy-MM-dd")}&dateTo={dateTo.ToString("yyyy-MM-dd")}&$fields={(partial != null ? partial(new Partial<BirthdayEvent>()) : Partial<BirthdayEvent>.Default())}", cancellationToken);
            
            }
        
        }
    
        public EventParticipationClient EventParticipations => new EventParticipationClient(_connection);
        
        public partial class EventParticipationClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public EventParticipationClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Update RSVP / calendar event participation status for a calendar event attached to an article.
            /// </summary>
            public async Task<MeetingRecord> UpdateEventParticipationAsync(string id, EventParticipationStatus newStatus, Func<Partial<MeetingRecord>, Partial<MeetingRecord>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<CalendarsEventParticipationsForIdPatchRequest, MeetingRecord>("PATCH", $"api/http/calendars/event-participations/{id}?$fields={(partial != null ? partial(new Partial<MeetingRecord>()) : Partial<MeetingRecord>.Default())}", 
                    new CalendarsEventParticipationsForIdPatchRequest { 
                        NewStatus = newStatus,
                    }
            , cancellationToken);
        
        }
    
        public EventClient Events => new EventClient(_connection);
        
        public partial class EventClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public EventClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get calendar events attached to an article in a specific time period.
            /// </summary>
            public async Task<List<MeetingRecord>> GetAllEventsAsync(DateTime dateFrom, DateTime dateTo, Func<Partial<MeetingRecord>, Partial<MeetingRecord>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<List<MeetingRecord>>("GET", $"api/http/calendars/events?dateFrom={dateFrom.ToString("yyyy-MM-dd")}&dateTo={dateTo.ToString("yyyy-MM-dd")}&$fields={(partial != null ? partial(new Partial<MeetingRecord>()) : Partial<MeetingRecord>.Default())}", cancellationToken);
        
            /// <summary>
            /// Get a calendar event attached to an article.
            /// </summary>
            public async Task<MeetingRecord> GetEventAsync(string id, Func<Partial<MeetingRecord>, Partial<MeetingRecord>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<MeetingRecord>("GET", $"api/http/calendars/events/{id}?$fields={(partial != null ? partial(new Partial<MeetingRecord>()) : Partial<MeetingRecord>.Default())}", cancellationToken);
        
        }
    
        public HolidayClient Holidays => new HolidayClient(_connection);
        
        public partial class HolidayClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public HolidayClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get/search holidays. Parameters are applied as 'AND' filters.
            /// </summary>
            public async Task<List<HolidaysEvent>> GetAllHolidaysAsync(DateTime startDate, DateTime endDate, string? team = null, string? location = null, string? role = null, bool? workingDays = null, Func<Partial<HolidaysEvent>, Partial<HolidaysEvent>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<List<HolidaysEvent>>("GET", $"api/http/calendars/holidays?startDate={startDate.ToString("yyyy-MM-dd")}&endDate={endDate.ToString("yyyy-MM-dd")}&team={team?.ToString() ?? "null"}&location={location?.ToString() ?? "null"}&role={role?.ToString() ?? "null"}&workingDays={workingDays?.ToString("l") ?? "null"}&$fields={(partial != null ? partial(new Partial<HolidaysEvent>()) : Partial<HolidaysEvent>.Default())}", cancellationToken);
        
        }
    
        public MeetingClient Meetings => new MeetingClient(_connection);
        
        public partial class MeetingClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public MeetingClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Create a meeting.
            /// </summary>
            public async Task<Meeting> CreateMeetingAsync(string summary, CalendarEventSpec occurrenceRule, List<string>? locations = null, List<string>? profiles = null, List<string>? externalParticipants = null, List<string>? teams = null, MeetingVisibility? visibility = null, MeetingModificationPreference? modificationPreference = null, MeetingJoiningPreference? joiningPreference = null, bool notifyOnExport = true, string? description = null, string? organizer = null, Func<Partial<Meeting>, Partial<Meeting>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<CalendarsMeetingsPostRequest, Meeting>("POST", $"api/http/calendars/meetings?$fields={(partial != null ? partial(new Partial<Meeting>()) : Partial<Meeting>.Default())}", 
                    new CalendarsMeetingsPostRequest { 
                        Summary = summary,
                        Description = description,
                        OccurrenceRule = occurrenceRule,
                        Locations = (locations ?? new List<string>()),
                        Profiles = (profiles ?? new List<string>()),
                        ExternalParticipants = (externalParticipants ?? new List<string>()),
                        Teams = (teams ?? new List<string>()),
                        Visibility = (visibility ?? MeetingVisibility.EVERYONE),
                        ModificationPreference = (modificationPreference ?? MeetingModificationPreference.PARTICIPANTS),
                        JoiningPreference = (joiningPreference ?? MeetingJoiningPreference.NOBODY),
                        IsNotifyOnExport = notifyOnExport,
                        Organizer = organizer,
                    }
            , cancellationToken);
        
            /// <summary>
            /// Search meetings by name, location, time period and other parameters. Parameters are applied as 'AND' filters while values in lists of locations, profiles and teams have 'OR' semantics.
            /// </summary>
            public async Task<Batch<Meeting>> GetAllMeetingsAsync(string summaryQuery = "", List<string>? locationsQuery = null, List<string>? profiles = null, List<string>? teams = null, bool includePrivate = false, bool includeArchived = false, bool includeMeetingInstances = true, string? skip = null, int? top = 100, DateTime? startingAfter = null, DateTime? endingAfter = null, DateTime? endingBefore = null, DateTime? startingBefore = null, string? organizer = null, Func<Partial<Batch<Meeting>>, Partial<Batch<Meeting>>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Batch<Meeting>>("GET", $"api/http/calendars/meetings?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&summaryQuery={summaryQuery.ToString()}&locationsQuery={(locationsQuery ?? new List<string>()).JoinToString("locationsQuery", it => it.ToString())}&startingAfter={startingAfter?.ToString("yyyy-MM-ddTHH:mm:ss.fffZ") ?? "null"}&endingAfter={endingAfter?.ToString("yyyy-MM-ddTHH:mm:ss.fffZ") ?? "null"}&endingBefore={endingBefore?.ToString("yyyy-MM-ddTHH:mm:ss.fffZ") ?? "null"}&startingBefore={startingBefore?.ToString("yyyy-MM-ddTHH:mm:ss.fffZ") ?? "null"}&profiles={(profiles ?? new List<string>()).JoinToString("profiles", it => it.ToString())}&teams={(teams ?? new List<string>()).JoinToString("teams", it => it.ToString())}&organizer={organizer?.ToString() ?? "null"}&includePrivate={includePrivate.ToString("l")}&includeArchived={includeArchived.ToString("l")}&includeMeetingInstances={includeMeetingInstances.ToString("l")}&$fields={(partial != null ? partial(new Partial<Batch<Meeting>>()) : Partial<Batch<Meeting>>.Default())}", cancellationToken);
            
            /// <summary>
            /// Search meetings by name, location, time period and other parameters. Parameters are applied as 'AND' filters while values in lists of locations, profiles and teams have 'OR' semantics.
            /// </summary>
            public IAsyncEnumerable<Meeting> GetAllMeetingsAsyncEnumerable(string summaryQuery = "", List<string>? locationsQuery = null, List<string>? profiles = null, List<string>? teams = null, bool includePrivate = false, bool includeArchived = false, bool includeMeetingInstances = true, string? skip = null, int? top = 100, DateTime? startingAfter = null, DateTime? endingAfter = null, DateTime? endingBefore = null, DateTime? startingBefore = null, string? organizer = null, Func<Partial<Meeting>, Partial<Meeting>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllMeetingsAsync(summaryQuery: summaryQuery, locationsQuery: locationsQuery, profiles: profiles, teams: teams, includePrivate: includePrivate, includeArchived: includeArchived, includeMeetingInstances: includeMeetingInstances, top: top, startingAfter: startingAfter, endingAfter: endingAfter, endingBefore: endingBefore, startingBefore: startingBefore, organizer: organizer, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<Meeting>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<Meeting>.Default())), skip, cancellationToken);
            
            /// <summary>
            /// Search meetings by name, location, time period and other parameters. Parameters are applied as 'AND' filters while values in lists of locations, profiles and teams have 'OR' semantics.
            /// </summary>
            public async Task<int> GetAllMeetingsCountAsync(string summaryQuery = "", List<string>? locationsQuery = null, List<string>? profiles = null, List<string>? teams = null, bool includePrivate = false, bool includeArchived = false, bool includeMeetingInstances = true, DateTime? startingAfter = null, DateTime? endingAfter = null, DateTime? endingBefore = null, DateTime? startingBefore = null, string? organizer = null, CancellationToken cancellationToken = default)
                => (await GetAllMeetingsAsync(summaryQuery: summaryQuery, locationsQuery: locationsQuery, profiles: profiles, teams: teams, includePrivate: includePrivate, includeArchived: includeArchived, includeMeetingInstances: includeMeetingInstances, startingAfter: startingAfter, endingAfter: endingAfter, endingBefore: endingBefore, startingBefore: startingBefore, organizer: organizer, cancellationToken: cancellationToken, skip: null, top: 1)).TotalCount.GetValueOrDefault();
        
            /// <summary>
            /// Search for the next meeting occurrence that starts after the provided time point or after the current time if it is not specified
            /// </summary>
            public async Task<MeetingOccurrenceTime> GetNextMeetingOccurrenceAsync(string meetingId, DateTime? since = null, Func<Partial<MeetingOccurrenceTime>, Partial<MeetingOccurrenceTime>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<MeetingOccurrenceTime>("GET", $"api/http/calendars/meetings/next-occurrence?meetingId={meetingId.ToString()}&since={since?.ToString("yyyy-MM-ddTHH:mm:ss.fffZ") ?? "null"}&$fields={(partial != null ? partial(new Partial<MeetingOccurrenceTime>()) : Partial<MeetingOccurrenceTime>.Default())}", cancellationToken);
        
            /// <summary>
            /// Search for occurrences of a meeting that start in the provided time interval. Interval limits are inclusive, response is limited by the first 1_000 results by default.
            /// </summary>
            public async Task<List<MeetingOccurrenceTime>> GetMeetingOccurrencesForPeriodAsync(string meetingId, DateTime since, DateTime until, int? limit = null, Func<Partial<MeetingOccurrenceTime>, Partial<MeetingOccurrenceTime>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<List<MeetingOccurrenceTime>>("GET", $"api/http/calendars/meetings/occurrences?meetingId={meetingId.ToString()}&since={since.ToString("yyyy-MM-ddTHH:mm:ss.fffZ")}&until={until.ToString("yyyy-MM-ddTHH:mm:ss.fffZ")}&limit={limit?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<MeetingOccurrenceTime>()) : Partial<MeetingOccurrenceTime>.Default())}", cancellationToken);
        
            public async Task<Meeting> GetMeetingAsync(string id, Func<Partial<Meeting>, Partial<Meeting>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Meeting>("GET", $"api/http/calendars/meetings/{id}?$fields={(partial != null ? partial(new Partial<Meeting>()) : Partial<Meeting>.Default())}", cancellationToken);
        
            /// <summary>
            /// Patch a meeting. Only not-null parameters and not empty diffs will be applied.
            /// </summary>
            public async Task<Meeting> UpdateMeetingAsync(string id, Diff locationsDiff, Diff profilesDiff, Diff externalParticipantsDiff, Diff teamsDiff, bool notifyOnExport = true, RecurrentModification? modificationKind = null, string? summary = null, string? description = null, CalendarEventSpec? occurrenceRule = null, MeetingVisibility? visibility = null, MeetingModificationPreference? modificationPreference = null, MeetingJoiningPreference? joiningPreference = null, string? organizer = null, DateTime? targetDate = null, Func<Partial<Meeting>, Partial<Meeting>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<CalendarsMeetingsForIdPatchRequest, Meeting>("PATCH", $"api/http/calendars/meetings/{id}?$fields={(partial != null ? partial(new Partial<Meeting>()) : Partial<Meeting>.Default())}", 
                    new CalendarsMeetingsForIdPatchRequest { 
                        Summary = summary,
                        Description = description,
                        OccurrenceRule = occurrenceRule,
                        LocationsDiff = locationsDiff,
                        ProfilesDiff = profilesDiff,
                        ExternalParticipantsDiff = externalParticipantsDiff,
                        TeamsDiff = teamsDiff,
                        Visibility = visibility,
                        ModificationPreference = modificationPreference,
                        JoiningPreference = joiningPreference,
                        IsNotifyOnExport = notifyOnExport,
                        Organizer = organizer,
                        TargetDate = targetDate,
                        ModificationKind = (modificationKind ?? RecurrentModification.All),
                    }
            , cancellationToken);
        
            public async Task<Meeting> DeleteMeetingAsync(string id, RecurrentModification? modificationKind = null, DateTime? targetDate = null, Func<Partial<Meeting>, Partial<Meeting>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Meeting>("DELETE", $"api/http/calendars/meetings/{id}?targetDate={targetDate?.ToString("yyyy-MM-ddTHH:mm:ss.fffZ") ?? "null"}&modificationKind={(modificationKind ?? RecurrentModification.All).ToString()}&$fields={(partial != null ? partial(new Partial<Meeting>()) : Partial<Meeting>.Default())}", cancellationToken);
        
        }
    
        public MembershipEventClient MembershipEvents => new MembershipEventClient(_connection);
        
        public partial class MembershipEventClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public MembershipEventClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get/search membership events. Parameters are applied as 'AND' filters.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View memberships</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<List<MembershipEvent>> GetAllMembershipEventsAsync(DateTime dateFrom, DateTime dateTo, string? team = null, string? location = null, string? role = null, Func<Partial<MembershipEvent>, Partial<MembershipEvent>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<List<MembershipEvent>>("GET", $"api/http/calendars/membership-events?dateFrom={dateFrom.ToString("yyyy-MM-dd")}&dateTo={dateTo.ToString("yyyy-MM-dd")}&team={team?.ToString() ?? "null"}&location={location?.ToString() ?? "null"}&role={role?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<MembershipEvent>()) : Partial<MembershipEvent>.Default())}", cancellationToken);
        
        }
    
        public NonWorkingDaysEventClient NonWorkingDaysEvents => new NonWorkingDaysEventClient(_connection);
        
        public partial class NonWorkingDaysEventClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public NonWorkingDaysEventClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get/search non-working day events. Parameters are applied as 'AND' filters.
            /// </summary>
            public async Task<List<NonWorkingDaysEvent>> GetAllNonWorkingDaysEventsAsync(DateTime dateFrom, DateTime dateTo, string? member = null, string? team = null, string? location = null, string? role = null, Func<Partial<NonWorkingDaysEvent>, Partial<NonWorkingDaysEvent>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<List<NonWorkingDaysEvent>>("GET", $"api/http/calendars/non-working-days-events?dateFrom={dateFrom.ToString("yyyy-MM-dd")}&dateTo={dateTo.ToString("yyyy-MM-dd")}&member={member?.ToString() ?? "null"}&team={team?.ToString() ?? "null"}&location={location?.ToString() ?? "null"}&role={role?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<NonWorkingDaysEvent>()) : Partial<NonWorkingDaysEvent>.Default())}", cancellationToken);
        
        }
    
    }
    
}
