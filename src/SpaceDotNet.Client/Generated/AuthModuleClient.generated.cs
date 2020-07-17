// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
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
        public async Task<ESAuthModuleDto> CreateAuthModuleAsync(string key, string name, bool enabled, ESAuthModuleSettingsDto settings, Func<Partial<ESAuthModuleDto>, Partial<ESAuthModuleDto>>? partial = null)
            => await _connection.RequestResourceAsync<AuthModulesPostRequest, ESAuthModuleDto>("POST", $"api/http/auth-modules?$fields={(partial != null ? partial(new Partial<ESAuthModuleDto>()) : Partial<ESAuthModuleDto>.Default())}", 
                new AuthModulesPostRequest { 
                    Key = key,
                    Name = name,
                    Enabled = enabled,
                    Settings = settings,
                }
        );
    
        /// <summary>
        /// Define the order of authentication modules. This affects the order of the federated authentication module buttons on the sign-in page.
        /// </summary>
        public async Task ReorderAsync(List<string> order)
            => await _connection.RequestResourceAsync("POST", $"api/http/auth-modules/reorder", 
                new AuthModulesReorderPostRequest { 
                    Order = order,
                }
        );
    
        public async Task<SamlMetadataResponseDto> SamlMetadataAsync(string id, string idpUrl, string idpEntityId, string idpCertificateSHA256, string spEntityId, SSLKeystoreDto? sslKeystore = null, string? contactProfileId = null, Func<Partial<SamlMetadataResponseDto>, Partial<SamlMetadataResponseDto>>? partial = null)
            => await _connection.RequestResourceAsync<AuthModulesForIdSamlMetadataPostRequest, SamlMetadataResponseDto>("POST", $"api/http/auth-modules/{id}/saml-metadata?$fields={(partial != null ? partial(new Partial<SamlMetadataResponseDto>()) : Partial<SamlMetadataResponseDto>.Default())}", 
                new AuthModulesForIdSamlMetadataPostRequest { 
                    IdpUrl = idpUrl,
                    IdpEntityId = idpEntityId,
                    IdpCertificateSHA256 = idpCertificateSHA256,
                    SpEntityId = spEntityId,
                    SslKeystore = sslKeystore,
                    ContactProfileId = contactProfileId,
                }
        );
    
        /// <summary>
        /// Get all authentication modules.
        /// </summary>
        public async Task<List<ESAuthModuleDto>> GetAllAuthModulesAsync(bool withDisabled = false, Func<Partial<ESAuthModuleDto>, Partial<ESAuthModuleDto>>? partial = null)
            => await _connection.RequestResourceAsync<List<ESAuthModuleDto>>("GET", $"api/http/auth-modules?withDisabled={withDisabled.ToString().ToLowerInvariant()}&$fields={(partial != null ? partial(new Partial<ESAuthModuleDto>()) : Partial<ESAuthModuleDto>.Default())}");
    
        /// <summary>
        /// Get an existing authentication module.
        /// </summary>
        public async Task<ESAuthModuleDto> GetAuthModuleByKeyAsync(string key, Func<Partial<ESAuthModuleDto>, Partial<ESAuthModuleDto>>? partial = null)
            => await _connection.RequestResourceAsync<ESAuthModuleDto>("GET", $"api/http/auth-modules/key:{key}?$fields={(partial != null ? partial(new Partial<ESAuthModuleDto>()) : Partial<ESAuthModuleDto>.Default())}");
    
        /// <summary>
        /// Update an existing authentication module. Optional parameters will be ignored when not specified, and updated otherwise.
        /// </summary>
        public async Task UpdateAuthModuleAsync(string id, string? key = null, string? name = null, bool? enabled = null, ESAuthModuleSettingsDto? settings = null)
            => await _connection.RequestResourceAsync("PATCH", $"api/http/auth-modules/{id}", 
                new AuthModulesForIdPatchRequest { 
                    Key = key,
                    Name = name,
                    Enabled = enabled,
                    Settings = settings,
                }
        );
    
        /// <summary>
        /// Delete an existing authentication module.
        /// </summary>
        public async Task DeleteAuthModuleAsync(string id)
            => await _connection.RequestResourceAsync("DELETE", $"api/http/auth-modules/{id}");
    
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
            public async Task<TDMemberProfileDto> TestBuiltInSettingsAsync(ESBuiltinAuthModuleSettingsDto settings, string username, string password, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>>? partial = null)
                => await _connection.RequestResourceAsync<AuthModulesTestBuiltInPostRequest, TDMemberProfileDto>("POST", $"api/http/auth-modules/test/built-in?$fields={(partial != null ? partial(new Partial<TDMemberProfileDto>()) : Partial<TDMemberProfileDto>.Default())}", 
                    new AuthModulesTestBuiltInPostRequest { 
                        Settings = settings,
                        Username = username,
                        Password = password,
                    }
            );
        
            /// <summary>
            /// For a username/password combination, test LDAP authentication with updated settings.
            /// </summary>
            public async Task<ESDefaultProfileLoginDetailsDto> TestLDAPSettingsAsync(ESLdapAuthModuleSettingsDto settings, string username, string password, Func<Partial<ESDefaultProfileLoginDetailsDto>, Partial<ESDefaultProfileLoginDetailsDto>>? partial = null)
                => await _connection.RequestResourceAsync<AuthModulesTestLdapPostRequest, ESDefaultProfileLoginDetailsDto>("POST", $"api/http/auth-modules/test/ldap?$fields={(partial != null ? partial(new Partial<ESDefaultProfileLoginDetailsDto>()) : Partial<ESDefaultProfileLoginDetailsDto>.Default())}", 
                    new AuthModulesTestLdapPostRequest { 
                        Settings = settings,
                        Username = username,
                        Password = password,
                    }
            );
        
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
            public async Task<List<AuthModuleUsageDto>> GetAllUsagesAsync(Func<Partial<AuthModuleUsageDto>, Partial<AuthModuleUsageDto>>? partial = null)
                => await _connection.RequestResourceAsync<List<AuthModuleUsageDto>>("GET", $"api/http/auth-modules/usages?$fields={(partial != null ? partial(new Partial<AuthModuleUsageDto>()) : Partial<AuthModuleUsageDto>.Default())}");
        
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
            public async Task ChangeAsync(string id, string identifier, string oldPassword, string newPassword)
                => await _connection.RequestResourceAsync("POST", $"api/http/auth-modules/{id}/logins/{identifier}/change", 
                    new AuthModulesForIdLoginsForIdentifierChangePostRequest { 
                        OldPassword = oldPassword,
                        NewPassword = newPassword,
                    }
            );
        
            /// <summary>
            /// Request a password reset for a given authentication module (id) and profile (identifier).
            /// </summary>
            public async Task ResetAsync(string id, string identifier)
                => await _connection.RequestResourceAsync("POST", $"api/http/auth-modules/{id}/logins/{identifier}/reset");
        
            /// <summary>
            /// Detach a profile login from an authentication module. The id parameter refers to the authentication module, the identifier parameter refers to the login.
            /// </summary>
            public async Task DeleteLoginAsync(string identifier, string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/auth-modules/{id}/logins/{identifier}");
        
        }
    
    }
    
}
