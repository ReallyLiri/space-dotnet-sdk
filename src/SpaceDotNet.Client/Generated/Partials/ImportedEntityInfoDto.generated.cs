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

namespace SpaceDotNet.Client.ImportedEntityInfoDtoExtensions
{
    public static class ImportedEntityInfoDtoPartialExtensions
    {
        public static Partial<ImportedEntityInfoDto> WithSource(this Partial<ImportedEntityInfoDto> it)    => it.AddFieldName("source");
        
        public static Partial<ImportedEntityInfoDto> WithSource(this Partial<ImportedEntityInfoDto> it, Func<Partial<ImportSourceDto>, Partial<ImportSourceDto>> partialBuilder)    => it.AddFieldName("source", partialBuilder(new Partial<ImportSourceDto>()));
        
        public static Partial<ImportedEntityInfoDto> WithExternalName(this Partial<ImportedEntityInfoDto> it)    => it.AddFieldName("externalName");
        
        public static Partial<ImportedEntityInfoDto> WithExternalUrl(this Partial<ImportedEntityInfoDto> it)    => it.AddFieldName("externalUrl");
        
    }
    
}
