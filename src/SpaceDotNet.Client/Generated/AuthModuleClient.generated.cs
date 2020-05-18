// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.4528729+00:00
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
        
        public async Task<ESAuthModuleDto> CreateAuthModule(CreateAuthModuleRequestDto data)
            => await _connection.RequestResourceAsync<CreateAuthModuleRequestDto, ESAuthModuleDto>("POST", $"api/http/auth-modules?$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(ESAuthModuleDto)), data);        
        
        /// <summary>
        /// Define order of auth modules. It affects the order of the federated auth module buttons on the sign-in page.
        /// </summary>
        public async Task Reorder(ReorderRequestDto data)
            => await _connection.RequestResourceAsync<ReorderRequestDto>("POST", $"api/http/auth-modules/reorder", data);        
        
        public async Task<SamlMetadataResponseDto> SamlMetadata(string id, SamlMetadataRequestDto data)
            => await _connection.RequestResourceAsync<SamlMetadataRequestDto, SamlMetadataResponseDto>("POST", $"api/http/auth-modules/{id}/saml-metadata?$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(SamlMetadataResponseDto)), data);        
        
        public async Task<List<ESAuthModuleDto>> GetAllAuthModules(bool withDisabled)
            => await _connection.RequestResourceAsync<List<ESAuthModuleDto>>("GET", $"api/http/auth-modules?withDisabled={withDisabled.ToString().ToLowerInvariant()}&$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(List<ESAuthModuleDto>)));        
        
        public async Task<ESAuthModuleDto> GetAuthModuleByKey(string key)
            => await _connection.RequestResourceAsync<ESAuthModuleDto>("GET", $"api/http/auth-modules/key:{key}?$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(ESAuthModuleDto)));        
        
        public async Task UpdateAuthModule(string id, UpdateAuthModuleRequestDto data)
            => await _connection.RequestResourceAsync<UpdateAuthModuleRequestDto>("PATCH", $"api/http/auth-modules/{id}", data);        
        
        public async Task DeleteAuthModule(string id)
            => await _connection.RequestResourceAsync("DELETE", $"api/http/auth-modules/{id}");        
        
        public TestClient Test => new TestClient(_connection);
        
        public partial class TestClient
        {
            private readonly Connection _connection;
            
            public TestClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<TDMemberProfileDto> TestBuiltInSettings(TestBuiltInSettingsRequestDto data)
                => await _connection.RequestResourceAsync<TestBuiltInSettingsRequestDto, TDMemberProfileDto>("POST", $"api/http/auth-modules/test/built-in?$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(TDMemberProfileDto)), data);            
            
            public async Task<ESDefaultProfileLoginDetailsDto> TestLDAPSettings(TestLDAPSettingsRequestDto data)
                => await _connection.RequestResourceAsync<TestLDAPSettingsRequestDto, ESDefaultProfileLoginDetailsDto>("POST", $"api/http/auth-modules/test/ldap?$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(ESDefaultProfileLoginDetailsDto)), data);            
            
        }
        
        public UsageClient Usages => new UsageClient(_connection);
        
        public partial class UsageClient
        {
            private readonly Connection _connection;
            
            public UsageClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<List<AuthModuleUsageDto>> GetAllUsages()
                => await _connection.RequestResourceAsync<List<AuthModuleUsageDto>>("GET", $"api/http/auth-modules/usages?$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(List<AuthModuleUsageDto>)));            
            
        }
        
        public LoginClient Logins => new LoginClient(_connection);
        
        public partial class LoginClient
        {
            private readonly Connection _connection;
            
            public LoginClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task Change(string id, string identifier, ChangeRequestDto data)
                => await _connection.RequestResourceAsync<ChangeRequestDto>("POST", $"api/http/auth-modules/{id}/logins/{identifier}/change", data);            
            
            public async Task Reset(string id, string identifier)
                => await _connection.RequestResourceAsync("POST", $"api/http/auth-modules/{id}/logins/{identifier}/reset");            
            
            public async Task DeleteLogin(string identifier, string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/auth-modules/{id}/logins/{identifier}");            
            
        }
        
    }
    
}
