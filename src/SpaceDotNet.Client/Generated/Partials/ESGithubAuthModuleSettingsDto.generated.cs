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

namespace SpaceDotNet.Client.ESGithubAuthModuleSettingsDtoExtensions
{
    public static class ESGithubAuthModuleSettingsDtoPartialExtensions
    {
        public static Partial<ESGithubAuthModuleSettingsDto> WithGithubUrl(this Partial<ESGithubAuthModuleSettingsDto> it)
            => it.AddFieldName("githubUrl");
        
        public static Partial<ESGithubAuthModuleSettingsDto> WithClientId(this Partial<ESGithubAuthModuleSettingsDto> it)
            => it.AddFieldName("clientId");
        
        public static Partial<ESGithubAuthModuleSettingsDto> WithClientSecret(this Partial<ESGithubAuthModuleSettingsDto> it)
            => it.AddFieldName("clientSecret");
        
        public static Partial<ESGithubAuthModuleSettingsDto> WithRegisterNewUsers(this Partial<ESGithubAuthModuleSettingsDto> it)
            => it.AddFieldName("registerNewUsers");
        
        public static Partial<ESGithubAuthModuleSettingsDto> WithOrganizations(this Partial<ESGithubAuthModuleSettingsDto> it)
            => it.AddFieldName("organizations");
        
    }
    
}
