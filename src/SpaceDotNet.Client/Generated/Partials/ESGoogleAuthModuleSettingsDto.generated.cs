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

namespace SpaceDotNet.Client.ESGoogleAuthModuleSettingsDtoExtensions
{
    public static class ESGoogleAuthModuleSettingsDtoPartialExtensions
    {
        public static Partial<ESGoogleAuthModuleSettingsDto> WithClientId(this Partial<ESGoogleAuthModuleSettingsDto> it)    => it.AddFieldName("clientId");
        
        public static Partial<ESGoogleAuthModuleSettingsDto> WithClientSecret(this Partial<ESGoogleAuthModuleSettingsDto> it)    => it.AddFieldName("clientSecret");
        
        public static Partial<ESGoogleAuthModuleSettingsDto> WithRegisterNewUsers(this Partial<ESGoogleAuthModuleSettingsDto> it)    => it.AddFieldName("registerNewUsers");
        
        public static Partial<ESGoogleAuthModuleSettingsDto> WithDomains(this Partial<ESGoogleAuthModuleSettingsDto> it)    => it.AddFieldName("domains");
        
    }
    
}
