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

namespace SpaceDotNet.Client.CreateAuthModuleRequestDtoExtensions
{
    public static class CreateAuthModuleRequestDtoPartialExtensions
    {
        public static Partial<CreateAuthModuleRequestDto> WithKey(this Partial<CreateAuthModuleRequestDto> it)    => it.AddFieldName("key");
        
        public static Partial<CreateAuthModuleRequestDto> WithName(this Partial<CreateAuthModuleRequestDto> it)    => it.AddFieldName("name");
        
        public static Partial<CreateAuthModuleRequestDto> WithEnabled(this Partial<CreateAuthModuleRequestDto> it)    => it.AddFieldName("enabled");
        
        public static Partial<CreateAuthModuleRequestDto> WithSettings(this Partial<CreateAuthModuleRequestDto> it)    => it.AddFieldName("settings");
        
        public static Partial<CreateAuthModuleRequestDto> WithSettings(this Partial<CreateAuthModuleRequestDto> it, Func<Partial<ESAuthModuleSettingsDto>, Partial<ESAuthModuleSettingsDto>> partialBuilder)    => it.AddFieldName("settings", partialBuilder(new Partial<ESAuthModuleSettingsDto>()));
        
    }
    
}
