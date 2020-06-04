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

namespace SpaceDotNet.Client.ESAuthModuleDtoExtensions
{
    public static class ESAuthModuleDtoPartialExtensions
    {
        public static Partial<ESAuthModuleDto> WithId(this Partial<ESAuthModuleDto> it)    => it.AddFieldName("id");
        
        public static Partial<ESAuthModuleDto> WithKey(this Partial<ESAuthModuleDto> it)    => it.AddFieldName("key");
        
        public static Partial<ESAuthModuleDto> WithName(this Partial<ESAuthModuleDto> it)    => it.AddFieldName("name");
        
        public static Partial<ESAuthModuleDto> WithOrdinal(this Partial<ESAuthModuleDto> it)    => it.AddFieldName("ordinal");
        
        public static Partial<ESAuthModuleDto> WithEnabled(this Partial<ESAuthModuleDto> it)    => it.AddFieldName("enabled");
        
        public static Partial<ESAuthModuleDto> WithIconDataURI(this Partial<ESAuthModuleDto> it)    => it.AddFieldName("iconDataURI");
        
        public static Partial<ESAuthModuleDto> WithSettings(this Partial<ESAuthModuleDto> it)    => it.AddFieldName("settings");
        
        public static Partial<ESAuthModuleDto> WithSettings(this Partial<ESAuthModuleDto> it, Func<Partial<ESAuthModuleSettingsDto>, Partial<ESAuthModuleSettingsDto>> partialBuilder)    => it.AddFieldName("settings", partialBuilder(new Partial<ESAuthModuleSettingsDto>()));
        
    }
    
}
