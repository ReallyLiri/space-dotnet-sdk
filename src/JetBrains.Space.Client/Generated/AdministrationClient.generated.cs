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

public partial class AdministrationClient : ISpaceClient
{
    private readonly Connection _connection;
    
    public AdministrationClient(Connection connection)
    {
        _connection = connection;
    }
    
    public SupportClient Support => new SupportClient(_connection);
    
    public partial class SupportClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public SupportClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Create a profile for support
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Grant permissions to other members</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<SupportProfileDTO> CreateSupportAsync(Func<Partial<SupportProfileDTO>, Partial<SupportProfileDTO>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<SupportProfileDTO>()) : Partial<SupportProfileDTO>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<SupportProfileDTO>("POST", $"api/http/administration/support{queryParameters.ToQueryString()}", requestHeaders: null, cancellationToken: cancellationToken);
        }
        
    
    }

    public UserAgreementClient UserAgreement => new UserAgreementClient(_connection);
    
    public partial class UserAgreementClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public UserAgreementClient(Connection connection)
        {
            _connection = connection;
        }
        
        public async Task<UAUserAgreement> GetUserAgreementAsync(Func<Partial<UAUserAgreement>, Partial<UAUserAgreement>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<UAUserAgreement>()) : Partial<UAUserAgreement>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<UAUserAgreement>("GET", $"api/http/administration/user-agreement{queryParameters.ToQueryString()}", requestHeaders: null, cancellationToken: cancellationToken);
        }
        
    
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Grant permissions to other members</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<UAUserAgreement> UploadNewUserAgreementAsync(string newContent, bool invalidate, Func<Partial<UAUserAgreement>, Partial<UAUserAgreement>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<UAUserAgreement>()) : Partial<UAUserAgreement>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<AdministrationUserAgreementPatchRequest, UAUserAgreement>("PATCH", $"api/http/administration/user-agreement{queryParameters.ToQueryString()}", 
                new AdministrationUserAgreementPatchRequest
                { 
                    NewContent = newContent,
                    IsInvalidate = invalidate,
                }, requestHeaders: null, cancellationToken: cancellationToken);
        }
        
    
        public EnabledClient Enabled => new EnabledClient(_connection);
        
        public partial class EnabledClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public EnabledClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Grant permissions to other members</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task EnableDisableUserAgreementAsync(bool enabled, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("POST", $"api/http/administration/user-agreement/enabled{queryParameters.ToQueryString()}", 
                    new AdministrationUserAgreementEnabledPostRequest
                    { 
                        IsEnabled = enabled,
                    }, requestHeaders: null, cancellationToken: cancellationToken);
            }
            
        
            public async Task<bool> IsUserAgreementEnabledAsync(Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                return await _connection.RequestResourceAsync<bool>("GET", $"api/http/administration/user-agreement/enabled{queryParameters.ToQueryString()}", requestHeaders: null, cancellationToken: cancellationToken);
            }
            
        
        }
    
        public StatuClient Status => new StatuClient(_connection);
        
        public partial class StatuClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public StatuClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Grant permissions to other members</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<Batch<UAUserAgreementStatus>> GetAllUserAgreementStatusesAsync(string query = "", bool activeProfilesOnly = true, string? skip = null, int? top = 100, bool? accepted = null, Func<Partial<Batch<UAUserAgreementStatus>>, Partial<Batch<UAUserAgreementStatus>>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                if (skip != null) queryParameters.Append("$skip", skip);
                if (top != null) queryParameters.Append("$top", top?.ToString());
                queryParameters.Append("query", query);
                if (accepted != null) queryParameters.Append("accepted", accepted?.ToString("l"));
                queryParameters.Append("activeProfilesOnly", activeProfilesOnly.ToString("l"));
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<Batch<UAUserAgreementStatus>>()) : Partial<Batch<UAUserAgreementStatus>>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<Batch<UAUserAgreementStatus>>("GET", $"api/http/administration/user-agreement/status{queryParameters.ToQueryString()}", requestHeaders: null, cancellationToken: cancellationToken);
            }
            
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Grant permissions to other members</term>
            /// </item>
            /// </list>
            /// </remarks>
            public IAsyncEnumerable<UAUserAgreementStatus> GetAllUserAgreementStatusesAsyncEnumerable(string query = "", bool activeProfilesOnly = true, string? skip = null, int? top = 100, bool? accepted = null, Func<Partial<UAUserAgreementStatus>, Partial<UAUserAgreementStatus>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllUserAgreementStatusesAsync(query: query, activeProfilesOnly: activeProfilesOnly, top: top, accepted: accepted, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<UAUserAgreementStatus>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<UAUserAgreementStatus>.Default())), skip, cancellationToken);
        
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Grant permissions to other members</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<UAUserAgreementStatus> GetUserAgreementStatusForAProfileAsync(ProfileIdentifier profile, Func<Partial<UAUserAgreementStatus>, Partial<UAUserAgreementStatus>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<UAUserAgreementStatus>()) : Partial<UAUserAgreementStatus>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<UAUserAgreementStatus>("GET", $"api/http/administration/user-agreement/status/{profile}{queryParameters.ToQueryString()}", requestHeaders: null, cancellationToken: cancellationToken);
            }
            
        
        }
    
    }

}

