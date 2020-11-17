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
    public partial class AbsenceClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public AbsenceClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Create an absence for a given profile (member).
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Edit absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<AbsenceRecord> CreateAbsenceAsync(string member, string reason, string description, DateTime since, DateTime till, string icon, bool available = false, string? location = null, List<CustomFieldValue>? customFieldValues = null, Func<Partial<AbsenceRecord>, Partial<AbsenceRecord>>? partial = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync<AbsencesPostRequest, AbsenceRecord>("POST", $"api/http/absences?$fields={(partial != null ? partial(new Partial<AbsenceRecord>()) : Partial<AbsenceRecord>.Default())}", 
                new AbsencesPostRequest { 
                    Member = member,
                    Reason = reason,
                    Description = description,
                    Location = location,
                    Since = since,
                    Till = till,
                    IsAvailable = available,
                    Icon = icon,
                    CustomFieldValues = customFieldValues,
                }
        , cancellationToken);
    
        /// <summary>
        /// Approve/unapprove an existing absence. Setting approve to true will approve the absence, false will remove the approval.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Approve absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task ApproveAbsenceAsync(string id, bool approve, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync("POST", $"api/http/absences/{id}/approve", 
                new AbsencesForIdApprovePostRequest { 
                    IsApprove = approve,
                }
        , cancellationToken);
    
        /// <summary>
        /// Search absences. Parameters are applied as 'AND' filters.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<Batch<AbsenceRecord>> GetAllAbsencesAsync(AbsenceListMode? viewMode = null, string? skip = null, int? top = 100, string? member = null, List<string>? members = null, string? location = null, string? team = null, DateTime? since = null, DateTime? till = null, string? reason = null, Func<Partial<Batch<AbsenceRecord>>, Partial<Batch<AbsenceRecord>>>? partial = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync<Batch<AbsenceRecord>>("GET", $"api/http/absences?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&member={member?.ToString() ?? "null"}&members={members?.JoinToString("members", it => it.ToString()) ?? "null"}&location={location?.ToString() ?? "null"}&team={team?.ToString() ?? "null"}&since={since?.ToString("yyyy-MM-dd") ?? "null"}&till={till?.ToString("yyyy-MM-dd") ?? "null"}&viewMode={(viewMode ?? AbsenceListMode.All).ToString()}&reason={reason?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<AbsenceRecord>>()) : Partial<Batch<AbsenceRecord>>.Default())}", cancellationToken);
        
        /// <summary>
        /// Search absences. Parameters are applied as 'AND' filters.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public IAsyncEnumerable<AbsenceRecord> GetAllAbsencesAsyncEnumerable(AbsenceListMode? viewMode = null, string? skip = null, int? top = 100, string? member = null, List<string>? members = null, string? location = null, string? team = null, DateTime? since = null, DateTime? till = null, string? reason = null, Func<Partial<AbsenceRecord>, Partial<AbsenceRecord>>? partial = null, CancellationToken cancellationToken = default)
            => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllAbsencesAsync(viewMode: viewMode, top: top, member: member, members: members, location: location, team: team, since: since, till: till, reason: reason, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<AbsenceRecord>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<AbsenceRecord>.Default())), skip, cancellationToken);
        
        /// <summary>
        /// Search absences. Parameters are applied as 'AND' filters.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<int> GetAllAbsencesCountAsync(AbsenceListMode? viewMode = null, string? member = null, List<string>? members = null, string? location = null, string? team = null, DateTime? since = null, DateTime? till = null, string? reason = null, CancellationToken cancellationToken = default)
            => (await GetAllAbsencesAsync(viewMode: viewMode, member: member, members: members, location: location, team: team, since: since, till: till, reason: reason, cancellationToken: cancellationToken, skip: null, top: 1)).TotalCount.GetValueOrDefault();
    
        /// <summary>
        /// Get absences for a given profile id.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<List<AbsenceRecord>> GetAllAbsencesByMemberAsync(string member, Func<Partial<AbsenceRecord>, Partial<AbsenceRecord>>? partial = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync<List<AbsenceRecord>>("GET", $"api/http/absences/member:{member}?$fields={(partial != null ? partial(new Partial<AbsenceRecord>()) : Partial<AbsenceRecord>.Default())}", cancellationToken);
    
        /// <summary>
        /// Get an absence.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<AbsenceRecord> GetAbsenceAsync(string id, Func<Partial<AbsenceRecord>, Partial<AbsenceRecord>>? partial = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync<AbsenceRecord>("GET", $"api/http/absences/{id}?$fields={(partial != null ? partial(new Partial<AbsenceRecord>()) : Partial<AbsenceRecord>.Default())}", cancellationToken);
    
        /// <summary>
        /// Create an existing absence. Optional parameters will be ignored when not specified, and updated otherwise.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Edit absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<AbsenceRecord> UpdateAbsenceAsync(string id, bool available, string? member = null, string? reason = null, string? description = null, string? location = null, DateTime? since = null, DateTime? till = null, string? icon = null, List<CustomFieldValue>? customFieldValues = null, Func<Partial<AbsenceRecord>, Partial<AbsenceRecord>>? partial = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync<AbsencesForIdPatchRequest, AbsenceRecord>("PATCH", $"api/http/absences/{id}?$fields={(partial != null ? partial(new Partial<AbsenceRecord>()) : Partial<AbsenceRecord>.Default())}", 
                new AbsencesForIdPatchRequest { 
                    Member = member,
                    Reason = reason,
                    Description = description,
                    Location = location,
                    Since = since,
                    Till = till,
                    IsAvailable = available,
                    Icon = icon,
                    CustomFieldValues = customFieldValues,
                }
        , cancellationToken);
    
        /// <summary>
        /// Archive/restore an existing absence. Setting delete to true will archive the absence, false will restore it.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Edit absences</term>
        /// </item>
        /// <item>
        /// <term>Create or edit past absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task DeleteAbsenceAsync(string id, bool delete = true, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync("DELETE", $"api/http/absences/{id}?delete={delete.ToString("l")}", cancellationToken);
    
        /// <summary>
        /// Delete approval for a given absence.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Approve absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task DeleteAbsenceApprovalAsync(string id, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync("DELETE", $"api/http/absences/{id}/delete-approval", cancellationToken);
    
        public AbsenceReasonClient AbsenceReasons => new AbsenceReasonClient(_connection);
        
        public partial class AbsenceReasonClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public AbsenceReasonClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Create a new absence reason.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit absence types</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<AbsenceReasonRecord> CreateAbsenceReasonAsync(string name, string description, bool defaultAvailability, bool approvalRequired, string? icon = null, Func<Partial<AbsenceReasonRecord>, Partial<AbsenceReasonRecord>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<AbsencesAbsenceReasonsPostRequest, AbsenceReasonRecord>("POST", $"api/http/absences/absence-reasons?$fields={(partial != null ? partial(new Partial<AbsenceReasonRecord>()) : Partial<AbsenceReasonRecord>.Default())}", 
                    new AbsencesAbsenceReasonsPostRequest { 
                        Name = name,
                        Description = description,
                        IsDefaultAvailability = defaultAvailability,
                        IsApprovalRequired = approvalRequired,
                        Icon = icon,
                    }
            , cancellationToken);
        
            /// <summary>
            /// Update an existing absence reason.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit absence types</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<AbsenceReasonRecord> CreateAbsenceReasonAsync(string id, string name, string description, bool defaultAvailability, bool approvalRequired, string? icon = null, Func<Partial<AbsenceReasonRecord>, Partial<AbsenceReasonRecord>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<AbsencesAbsenceReasonsForIdPostRequest, AbsenceReasonRecord>("POST", $"api/http/absences/absence-reasons/{id}?$fields={(partial != null ? partial(new Partial<AbsenceReasonRecord>()) : Partial<AbsenceReasonRecord>.Default())}", 
                    new AbsencesAbsenceReasonsForIdPostRequest { 
                        Name = name,
                        Description = description,
                        IsDefaultAvailability = defaultAvailability,
                        IsApprovalRequired = approvalRequired,
                        Icon = icon,
                    }
            , cancellationToken);
        
            /// <summary>
            /// Get available absence reasons.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View absence types</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<List<AbsenceReasonRecord>> GetAllAbsenceReasonsAsync(bool withArchived = false, Func<Partial<AbsenceReasonRecord>, Partial<AbsenceReasonRecord>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<List<AbsenceReasonRecord>>("GET", $"api/http/absences/absence-reasons?withArchived={withArchived.ToString("l")}&$fields={(partial != null ? partial(new Partial<AbsenceReasonRecord>()) : Partial<AbsenceReasonRecord>.Default())}", cancellationToken);
        
            /// <summary>
            /// Get an absence reason.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View absence types</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<AbsenceReasonRecord> GetAbsenceReasonAsync(string id, Func<Partial<AbsenceReasonRecord>, Partial<AbsenceReasonRecord>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<AbsenceReasonRecord>("GET", $"api/http/absences/absence-reasons/{id}?$fields={(partial != null ? partial(new Partial<AbsenceReasonRecord>()) : Partial<AbsenceReasonRecord>.Default())}", cancellationToken);
        
            /// <summary>
            /// Archive/restore an existing absence reason. Setting delete to true will archive the absence reason, false will restore it.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit absence types</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task DeleteAbsenceReasonAsync(string id, bool delete = true, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/absences/absence-reasons/{id}?delete={delete.ToString("l")}", cancellationToken);
        
        }
    
    }
    
}