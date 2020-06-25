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
    public abstract class ESOAuth2AuthModuleSettingsDto
         : ESFederatedAuthModuleSettingsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "ES_OAuth2AuthModuleSettings";
        
        public static ESAzureAuthModuleSettingsDto ESAzureAuthModuleSettings(string tenantId, string clientId, string clientSecret, bool registerNewUsers, bool emailVerified)
            => new ESAzureAuthModuleSettingsDto(tenantId: tenantId, clientId: clientId, clientSecret: clientSecret, registerNewUsers: registerNewUsers, emailVerified: emailVerified);
        
        public static ESGithubAuthModuleSettingsDto ESGithubAuthModuleSettings(string githubUrl, string clientId, string clientSecret, bool registerNewUsers, List<string> organizations)
            => new ESGithubAuthModuleSettingsDto(githubUrl: githubUrl, clientId: clientId, clientSecret: clientSecret, registerNewUsers: registerNewUsers, organizations: organizations);
        
        public static ESGoogleAuthModuleSettingsDto ESGoogleAuthModuleSettings(string clientId, string clientSecret, bool registerNewUsers, List<string> domains)
            => new ESGoogleAuthModuleSettingsDto(clientId: clientId, clientSecret: clientSecret, registerNewUsers: registerNewUsers, domains: domains);
        
        public static ESHubAuthModuleSettingsDto ESHubAuthModuleSettings(string hubUrl, string clientId, string clientSecret, bool? registerNewUsers = null, string? orgAuthProviderName = null, List<string>? groups = null)
            => new ESHubAuthModuleSettingsDto(hubUrl: hubUrl, clientId: clientId, clientSecret: clientSecret, registerNewUsers: null, orgAuthProviderName: null, groups: null);
        
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
