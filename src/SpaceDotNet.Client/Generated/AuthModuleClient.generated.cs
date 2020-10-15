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
    public partial class AuthModuleClient
    {
        private readonly Connection _connection;
        
        public AuthModuleClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Create a new authentication module. Settings are specific to the type of authentication module being created.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Manage authentication modules</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<ESAuthModule> CreateAuthModuleAsync(string key, string name, bool enabled, ESAuthModuleSettings settings, Func<Partial<ESAuthModule>, Partial<ESAuthModule>>? partial = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync<AuthModulesPostRequest, ESAuthModule>("POST", $"api/http/auth-modules?$fields={(partial != null ? partial(new Partial<ESAuthModule>()) : Partial<ESAuthModule>.Default())}", 
                new AuthModulesPostRequest { 
                    Key = key,
                    Name = name,
                    IsEnabled = enabled,
                    Settings = settings,
                }
        , cancellationToken);
    
        /// <summary>
        /// Define the order of authentication modules. This affects the order of the federated authentication module buttons on the sign-in page.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Manage authentication modules</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task ReorderAsync(List<string> order, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync("POST", $"api/http/auth-modules/reorder", 
                new AuthModulesReorderPostRequest { 
                    Order = order,
                }
        , cancellationToken);
    
        public async Task<SamlMetadataResponse> SamlMetadataAsync(string id, string idpUrl, string idpEntityId, string idpCertificateSHA256, string spEntityId, SSLKeystore? sslKeystore = null, string? contactProfileId = null, Func<Partial<SamlMetadataResponse>, Partial<SamlMetadataResponse>>? partial = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync<AuthModulesForIdSamlMetadataPostRequest, SamlMetadataResponse>("POST", $"api/http/auth-modules/{id}/saml-metadata?$fields={(partial != null ? partial(new Partial<SamlMetadataResponse>()) : Partial<SamlMetadataResponse>.Default())}", 
                new AuthModulesForIdSamlMetadataPostRequest { 
                    IdpUrl = idpUrl,
                    IdpEntityId = idpEntityId,
                    IdpCertificateSHA256 = idpCertificateSHA256,
                    SpEntityId = spEntityId,
                    SslKeystore = sslKeystore,
                    ContactProfileId = contactProfileId,
                }
        , cancellationToken);
    
        /// <summary>
        /// Get all authentication modules.
        /// </summary>
        public async Task<List<ESAuthModule>> GetAllAuthModulesAsync(bool withDisabled = false, Func<Partial<ESAuthModule>, Partial<ESAuthModule>>? partial = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync<List<ESAuthModule>>("GET", $"api/http/auth-modules?withDisabled={withDisabled.ToString().ToLowerInvariant()}&$fields={(partial != null ? partial(new Partial<ESAuthModule>()) : Partial<ESAuthModule>.Default())}", cancellationToken);
    
        /// <summary>
        /// Automatically discovers the endpoints for the OpenID Connect provider via discovery document
        /// </summary>
        public async Task<OIDCDiscovery> DiscoverOidcAsync(string discoveryEndpoint, Func<Partial<OIDCDiscovery>, Partial<OIDCDiscovery>>? partial = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync<OIDCDiscovery>("GET", $"api/http/auth-modules/discover-oidc?discoveryEndpoint={discoveryEndpoint.ToString()}&$fields={(partial != null ? partial(new Partial<OIDCDiscovery>()) : Partial<OIDCDiscovery>.Default())}", cancellationToken);
    
        /// <summary>
        /// Get an existing authentication module.
        /// </summary>
        public async Task<ESAuthModule> GetAuthModuleByKeyAsync(string key, Func<Partial<ESAuthModule>, Partial<ESAuthModule>>? partial = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync<ESAuthModule>("GET", $"api/http/auth-modules/key:{key}?$fields={(partial != null ? partial(new Partial<ESAuthModule>()) : Partial<ESAuthModule>.Default())}", cancellationToken);
    
        /// <summary>
        /// Update an existing authentication module. Optional parameters will be ignored when not specified, and updated otherwise.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Manage authentication modules</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task UpdateAuthModuleAsync(string id, string? key = null, string? name = null, bool? enabled = null, ESAuthModuleSettings? settings = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync("PATCH", $"api/http/auth-modules/{id}", 
                new AuthModulesForIdPatchRequest { 
                    Key = key,
                    Name = name,
                    IsEnabled = enabled,
                    Settings = settings,
                }
        , cancellationToken);
    
        /// <summary>
        /// Delete an existing authentication module.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Manage authentication modules</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task DeleteAuthModuleAsync(string id, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync("DELETE", $"api/http/auth-modules/{id}", cancellationToken);
    
        public TestClient Test => new TestClient(_connection);
        
        public partial class TestClient
        {
            private readonly Connection _connection;
            
            public TestClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// For a username/password combination, test built-in authentication with updated settings.
            /// </summary>
            public async Task<TDMemberProfile> TestBuiltInSettingsAsync(ESBuiltinAuthModuleSettings settings, string username, string password, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<AuthModulesTestBuiltInPostRequest, TDMemberProfile>("POST", $"api/http/auth-modules/test/built-in?$fields={(partial != null ? partial(new Partial<TDMemberProfile>()) : Partial<TDMemberProfile>.Default())}", 
                    new AuthModulesTestBuiltInPostRequest { 
                        Settings = settings,
                        Username = username,
                        Password = password,
                    }
            , cancellationToken);
        
            /// <summary>
            /// For a username/password combination, test LDAP authentication with updated settings.
            /// </summary>
            public async Task<ESDefaultProfileLoginDetails> TestLDAPSettingsAsync(ESLdapAuthModuleSettings settings, string username, string password, Func<Partial<ESDefaultProfileLoginDetails>, Partial<ESDefaultProfileLoginDetails>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<AuthModulesTestLdapPostRequest, ESDefaultProfileLoginDetails>("POST", $"api/http/auth-modules/test/ldap?$fields={(partial != null ? partial(new Partial<ESDefaultProfileLoginDetails>()) : Partial<ESDefaultProfileLoginDetails>.Default())}", 
                    new AuthModulesTestLdapPostRequest { 
                        Settings = settings,
                        Username = username,
                        Password = password,
                    }
            , cancellationToken);
        
        }
    
        public ThrottledLoginClient ThrottledLogins => new ThrottledLoginClient(_connection);
        
        public partial class ThrottledLoginClient
        {
            private readonly Connection _connection;
            
            public ThrottledLoginClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Returns logins that are currently subjected to rate limits when logging in to Space.
            /// </summary>
            public async Task<Batch<ThrottledLogin>> GetThrottledLoginsAsync(string? skip = null, int? top = 100, string? login = null, Func<Partial<Batch<ThrottledLogin>>, Partial<Batch<ThrottledLogin>>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Batch<ThrottledLogin>>("GET", $"api/http/auth-modules/throttled-logins?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&login={login?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<ThrottledLogin>>()) : Partial<Batch<ThrottledLogin>>.Default())}", cancellationToken);
            
            /// <summary>
            /// Returns logins that are currently subjected to rate limits when logging in to Space.
            /// </summary>
            public IAsyncEnumerable<ThrottledLogin> GetThrottledLoginsAsyncEnumerable(string? skip = null, int? top = 100, string? login = null, Func<Partial<ThrottledLogin>, Partial<ThrottledLogin>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetThrottledLoginsAsync(top: top, login: login, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<ThrottledLogin>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<ThrottledLogin>.Default())), skip, cancellationToken);
        
            /// <summary>
            /// Resets the counter that tracks failed login attempts for the account with the specified ID. The member who uses this account is no longer blocked from attempting to log in to Space.
            /// </summary>
            public async Task ResetThrottlingStatusAsync(string id, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync("PATCH", $"api/http/auth-modules/throttled-logins/{id}", cancellationToken);
        
        }
    
        public UsageClient Usages => new UsageClient(_connection);
        
        public partial class UsageClient
        {
            private readonly Connection _connection;
            
            public UsageClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Retrieve a list of authentication module usage count.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Manage authentication modules</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<List<AuthModuleUsage>> GetAllUsagesAsync(Func<Partial<AuthModuleUsage>, Partial<AuthModuleUsage>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<List<AuthModuleUsage>>("GET", $"api/http/auth-modules/usages?$fields={(partial != null ? partial(new Partial<AuthModuleUsage>()) : Partial<AuthModuleUsage>.Default())}", cancellationToken);
        
        }
    
        public LoginClient Logins => new LoginClient(_connection);
        
        public partial class LoginClient
        {
            private readonly Connection _connection;
            
            public LoginClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Change password for a given authentication module (id) and profile (identifier).
            /// </summary>
            public async Task ChangeAsync(string id, string identifier, string oldPassword, string newPassword, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync("POST", $"api/http/auth-modules/{id}/logins/{identifier}/change", 
                    new AuthModulesForIdLoginsForIdentifierChangePostRequest { 
                        OldPassword = oldPassword,
                        NewPassword = newPassword,
                    }
            , cancellationToken);
        
            /// <summary>
            /// Request a password reset for a given authentication module (id) and profile (identifier).
            /// </summary>
            public async Task ResetAsync(string id, string identifier, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync("POST", $"api/http/auth-modules/{id}/logins/{identifier}/reset", cancellationToken);
        
            /// <summary>
            /// Detach a profile login from an authentication module. The id parameter refers to the authentication module, the identifier parameter refers to the login.
            /// </summary>
            public async Task DeleteLoginAsync(string identifier, string id, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/auth-modules/{id}/logins/{identifier}", cancellationToken);
        
        }
    
    }
    
}
