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

public partial class PermissionRoleClient : ISpaceClient
{
    private readonly Connection _connection;
    
    public PermissionRoleClient(Connection connection)
    {
        _connection = connection;
    }
    
    /// <summary>
    /// Create new custom permission role in specified permission context
    /// </summary>
    /// <remarks>
    /// Required permissions:
    /// <list type="bullet">
    /// <item>
    /// <term>Grant permissions to other members</term>
    /// </item>
    /// <item>
    /// <term>Manage project permission scheme</term>
    /// </item>
    /// <item>
    /// <term>Manage channels</term>
    /// </item>
    /// </list>
    /// </remarks>
    public async Task<RoleDTO> CreateRoleAsync(PermissionContextIdentifier contextIdentifier, string name, Func<Partial<RoleDTO>, Partial<RoleDTO>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        queryParameters.Append("$fields", (partial != null ? partial(new Partial<RoleDTO>()) : Partial<RoleDTO>.Default()).ToString());
        
        return await _connection.RequestResourceAsync<PermissionRolesCreatePostRequest, RoleDTO>("POST", $"api/http/permission-roles/create{queryParameters.ToQueryString()}", 
            new PermissionRolesCreatePostRequest
            { 
                ContextIdentifier = contextIdentifier,
                Name = name,
            }, requestHeaders: null, cancellationToken: cancellationToken);
    }
    

    /// <summary>
    /// List all permission roles in permission context
    /// </summary>
    /// <remarks>
    /// Required permissions:
    /// <list type="bullet">
    /// <item>
    /// <term>Grant permissions to other members</term>
    /// </item>
    /// <item>
    /// <term>View project details</term>
    /// </item>
    /// <item>
    /// <term>View channel info</term>
    /// </item>
    /// </list>
    /// </remarks>
    public async Task<List<RoleDTO>> GetRolesAsync(PermissionContextIdentifier contextIdentifier, Func<Partial<RoleDTO>, Partial<RoleDTO>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        queryParameters.Append("$fields", (partial != null ? partial(new Partial<RoleDTO>()) : Partial<RoleDTO>.Default()).ToString());
        
        return await _connection.RequestResourceAsync<PermissionRolesGetPostRequest, List<RoleDTO>>("POST", $"api/http/permission-roles/get{queryParameters.ToQueryString()}", 
            new PermissionRolesGetPostRequest
            { 
                ContextIdentifier = contextIdentifier,
            }, requestHeaders: null, cancellationToken: cancellationToken);
    }
    

    /// <summary>
    /// Reset permissions for the role to the standard ones. Only applicable to roles with PermissionRoleType = PREDEFINED, not applicable to custom roles.
    /// </summary>
    /// <remarks>
    /// Required permissions:
    /// <list type="bullet">
    /// <item>
    /// <term>Grant permissions to other members</term>
    /// </item>
    /// <item>
    /// <term>Manage project permission scheme</term>
    /// </item>
    /// <item>
    /// <term>Manage channels</term>
    /// </item>
    /// </list>
    /// </remarks>
    public async Task ResetRolePermissionsToDefaultAsync(string roleId, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        
        await _connection.RequestResourceAsync("POST", $"api/http/permission-roles/{roleId}/reset-role-permissions-to-default{queryParameters.ToQueryString()}", requestHeaders: null, cancellationToken: cancellationToken);
    }
    

    /// <summary>
    /// Update custom permission role name
    /// </summary>
    /// <remarks>
    /// Required permissions:
    /// <list type="bullet">
    /// <item>
    /// <term>Grant permissions to other members</term>
    /// </item>
    /// <item>
    /// <term>Manage project permission scheme</term>
    /// </item>
    /// <item>
    /// <term>Manage channels</term>
    /// </item>
    /// </list>
    /// </remarks>
    public async Task UpdateRoleAsync(string roleId, string name, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        
        await _connection.RequestResourceAsync("PATCH", $"api/http/permission-roles/{roleId}{queryParameters.ToQueryString()}", 
            new PermissionRolesForRoleIdPatchRequest
            { 
                Name = name,
            }, requestHeaders: null, cancellationToken: cancellationToken);
    }
    

    /// <summary>
    /// Delete custom permission role
    /// </summary>
    /// <remarks>
    /// Required permissions:
    /// <list type="bullet">
    /// <item>
    /// <term>Grant permissions to other members</term>
    /// </item>
    /// <item>
    /// <term>Manage project permission scheme</term>
    /// </item>
    /// <item>
    /// <term>Manage channels</term>
    /// </item>
    /// </list>
    /// </remarks>
    public async Task DeleteRoleAsync(string roleId, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        
        await _connection.RequestResourceAsync("DELETE", $"api/http/permission-roles/{roleId}{queryParameters.ToQueryString()}", requestHeaders: null, cancellationToken: cancellationToken);
    }
    

    public TwoFaRequirementClient TwoFaRequirement => new TwoFaRequirementClient(_connection);
    
    public partial class TwoFaRequirementClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public TwoFaRequirementClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Get 2FA requirement for permission role
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Grant permissions to other members</term>
        /// </item>
        /// <item>
        /// <term>Manage project permission scheme</term>
        /// </item>
        /// <item>
        /// <term>Manage channels</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<TwoFactorAuthenticationRequirement> Get2faRequirementAsync(string roleId, Func<Partial<TwoFactorAuthenticationRequirement>, Partial<TwoFactorAuthenticationRequirement>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<TwoFactorAuthenticationRequirement>()) : Partial<TwoFactorAuthenticationRequirement>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<TwoFactorAuthenticationRequirement>("GET", $"api/http/permission-roles/{roleId}/2-fa-requirement{queryParameters.ToQueryString()}", requestHeaders: null, cancellationToken: cancellationToken);
        }
        
    
        /// <summary>
        /// Set 2FA requirement for permission role
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Grant permissions to other members</term>
        /// </item>
        /// <item>
        /// <term>Manage project permission scheme</term>
        /// </item>
        /// <item>
        /// <term>Manage channels</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task Set2faRequirementAsync(string roleId, bool? required = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("PATCH", $"api/http/permission-roles/{roleId}/2-fa-requirement{queryParameters.ToQueryString()}", 
                new PermissionRolesForRoleId2FaRequirementPatchRequest
                { 
                    IsRequired = required,
                }, requestHeaders: null, cancellationToken: cancellationToken);
        }
        
    
    }

    public PermissionClient Permissions => new PermissionClient(_connection);
    
    public partial class PermissionClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public PermissionClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Grant permissions to the specified role. You can get the list of all permissions applicable to the role using "Get all" method.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Grant permissions to other members</term>
        /// </item>
        /// <item>
        /// <term>Manage project permission scheme</term>
        /// </item>
        /// <item>
        /// <term>Manage channels</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task GrantRolePermissionsAsync(string roleId, List<string> rightCodes, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("POST", $"api/http/permission-roles/{roleId}/permissions{queryParameters.ToQueryString()}", 
                new PermissionRolesForRoleIdPermissionsPostRequest
                { 
                    RightCodes = rightCodes,
                }, requestHeaders: null, cancellationToken: cancellationToken);
        }
        
    
        /// <summary>
        /// Get role permissions
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Grant permissions to other members</term>
        /// </item>
        /// <item>
        /// <term>View project details</term>
        /// </item>
        /// <item>
        /// <term>View channel info</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<List<RightDTO>> GetRolePermissionsAsync(string roleId, Func<Partial<RightDTO>, Partial<RightDTO>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<RightDTO>()) : Partial<RightDTO>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<List<RightDTO>>("GET", $"api/http/permission-roles/{roleId}/permissions{queryParameters.ToQueryString()}", requestHeaders: null, cancellationToken: cancellationToken);
        }
        
    
        /// <summary>
        /// Revoke permissions from the specified role.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Grant permissions to other members</term>
        /// </item>
        /// <item>
        /// <term>Manage project permission scheme</term>
        /// </item>
        /// <item>
        /// <term>Manage channels</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task RevokeRolePermissionsAsync(string roleId, List<string> rightCodes, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("rightCodes", rightCodes.Select(it => it));
            
            await _connection.RequestResourceAsync("DELETE", $"api/http/permission-roles/{roleId}/permissions{queryParameters.ToQueryString()}", requestHeaders: null, cancellationToken: cancellationToken);
        }
        
    
    }

    public ProfileClient Profiles => new ProfileClient(_connection);
    
    public partial class ProfileClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public ProfileClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Assign permission role to the profile
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Grant permissions to other members</term>
        /// </item>
        /// <item>
        /// <term>Manage project permission scheme</term>
        /// </item>
        /// <item>
        /// <term>Manage channels</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task AddRoleMemberAsync(string roleId, ProfileIdentifier profile, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("POST", $"api/http/permission-roles/{roleId}/profiles/{profile}{queryParameters.ToQueryString()}", requestHeaders: null, cancellationToken: cancellationToken);
        }
        
    
        /// <summary>
        /// Get list of profiles with the specified role
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Grant permissions to other members</term>
        /// </item>
        /// <item>
        /// <term>View project details</term>
        /// </item>
        /// <item>
        /// <term>View channel info</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<List<TDMemberProfile>> GetRoleMembersAsync(string roleId, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<TDMemberProfile>()) : Partial<TDMemberProfile>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<List<TDMemberProfile>>("GET", $"api/http/permission-roles/{roleId}/profiles{queryParameters.ToQueryString()}", requestHeaders: null, cancellationToken: cancellationToken);
        }
        
    
        /// <summary>
        /// Remove permission role from the profile
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Grant permissions to other members</term>
        /// </item>
        /// <item>
        /// <term>Manage project permission scheme</term>
        /// </item>
        /// <item>
        /// <term>Manage channels</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task RemoveRoleMemberAsync(string roleId, ProfileIdentifier profile, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("DELETE", $"api/http/permission-roles/{roleId}/profiles/{profile}{queryParameters.ToQueryString()}", requestHeaders: null, cancellationToken: cancellationToken);
        }
        
    
    }

    public TeamClient Teams => new TeamClient(_connection);
    
    public partial class TeamClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public TeamClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Assign permission role to the team
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Grant permissions to other members</term>
        /// </item>
        /// <item>
        /// <term>Manage project permission scheme</term>
        /// </item>
        /// <item>
        /// <term>Manage channels</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task AddRoleTeamAsync(string roleId, TeamIdentifier team, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("POST", $"api/http/permission-roles/{roleId}/teams/{team}{queryParameters.ToQueryString()}", requestHeaders: null, cancellationToken: cancellationToken);
        }
        
    
        /// <summary>
        /// Get list of teams with the specified role
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Grant permissions to other members</term>
        /// </item>
        /// <item>
        /// <term>View project details</term>
        /// </item>
        /// <item>
        /// <term>View channel info</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<List<TDTeam>> GetRoleTeamsAsync(string roleId, Func<Partial<TDTeam>, Partial<TDTeam>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<TDTeam>()) : Partial<TDTeam>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<List<TDTeam>>("GET", $"api/http/permission-roles/{roleId}/teams{queryParameters.ToQueryString()}", requestHeaders: null, cancellationToken: cancellationToken);
        }
        
    
        /// <summary>
        /// Remove permission role from the team
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Grant permissions to other members</term>
        /// </item>
        /// <item>
        /// <term>Manage project permission scheme</term>
        /// </item>
        /// <item>
        /// <term>Manage channels</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task RemoveRoleTeamAsync(string roleId, TeamIdentifier team, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("DELETE", $"api/http/permission-roles/{roleId}/teams/{team}{queryParameters.ToQueryString()}", requestHeaders: null, cancellationToken: cancellationToken);
        }
        
    
    }

}

