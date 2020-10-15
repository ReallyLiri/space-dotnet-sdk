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
    public abstract class ESOAuth2AuthModuleSettings
         : ESFederatedAuthModuleSettings, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "ES_OAuth2AuthModuleSettings";
        
        public static ESAzureAuthModuleSettings ESAzureAuthModuleSettings(string tenantId, string clientId, string clientSecret, bool registerNewUsers, bool emailVerified)
            => new ESAzureAuthModuleSettings(tenantId: tenantId, clientId: clientId, clientSecret: clientSecret, registerNewUsers: registerNewUsers, emailVerified: emailVerified);
        
        public static ESGithubAuthModuleSettings ESGithubAuthModuleSettings(string githubUrl, string clientId, string clientSecret, bool registerNewUsers, List<string> organizations)
            => new ESGithubAuthModuleSettings(githubUrl: githubUrl, clientId: clientId, clientSecret: clientSecret, registerNewUsers: registerNewUsers, organizations: organizations);
        
        public static ESGoogleAuthModuleSettings ESGoogleAuthModuleSettings(string clientId, string clientSecret, bool registerNewUsers, List<string> domains)
            => new ESGoogleAuthModuleSettings(clientId: clientId, clientSecret: clientSecret, registerNewUsers: registerNewUsers, domains: domains);
        
        public static ESHubAuthModuleSettings ESHubAuthModuleSettings(string hubUrl, string clientId, string clientSecret, bool? registerNewUsers = null, string? orgAuthProviderName = null, List<string>? groups = null)
            => new ESHubAuthModuleSettings(hubUrl: hubUrl, clientId: clientId, clientSecret: clientSecret, registerNewUsers: null, orgAuthProviderName: null, groups: null);
        
        public static ESOIDCAuthModuleSettings ESOIDCAuthModuleSettings(string clientId, string clientSecret, bool registerNewUsers, string issuer, string authorizationEndpoint, string tokenEndpoint, string tokenKeysEndpoint, string userInfoEndpoint, List<string> domains, string? discoveryUrl = null)
            => new ESOIDCAuthModuleSettings(clientId: clientId, clientSecret: clientSecret, registerNewUsers: registerNewUsers, issuer: issuer, authorizationEndpoint: authorizationEndpoint, tokenEndpoint: tokenEndpoint, tokenKeysEndpoint: tokenKeysEndpoint, userInfoEndpoint: userInfoEndpoint, domains: domains, discoveryUrl: null);
        
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
