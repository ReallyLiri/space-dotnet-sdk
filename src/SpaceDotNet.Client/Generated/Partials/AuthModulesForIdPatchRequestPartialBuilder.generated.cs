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

namespace SpaceDotNet.Client.AuthModulesForIdPatchRequestPartialBuilder
{
    public static class AuthModulesForIdPatchRequestPartialExtensions
    {
        public static Partial<AuthModulesForIdPatchRequest> WithKey(this Partial<AuthModulesForIdPatchRequest> it)
            => it.AddFieldName("key");
        
        public static Partial<AuthModulesForIdPatchRequest> WithName(this Partial<AuthModulesForIdPatchRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<AuthModulesForIdPatchRequest> WithEnabled(this Partial<AuthModulesForIdPatchRequest> it)
            => it.AddFieldName("enabled");
        
        public static Partial<AuthModulesForIdPatchRequest> WithSettings(this Partial<AuthModulesForIdPatchRequest> it)
            => it.AddFieldName("settings");
        
        public static Partial<AuthModulesForIdPatchRequest> WithSettings(this Partial<AuthModulesForIdPatchRequest> it, Func<Partial<ESAuthModuleSettingsDto>, Partial<ESAuthModuleSettingsDto>> partialBuilder)
            => it.AddFieldName("settings", partialBuilder(new Partial<ESAuthModuleSettingsDto>(it)));
        
    }
    
}