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

namespace SpaceDotNet.Client.HATypeDtoDtoExtensions
{
    public static class HATypeDtoDtoPartialExtensions
    {
        public static Partial<HATypeDtoDto> WithDto(this Partial<HATypeDtoDto> it)
            => it.AddFieldName("dto");
        
        public static Partial<HATypeDtoDto> WithDto(this Partial<HATypeDtoDto> it, Func<Partial<HADtoDto>, Partial<HADtoDto>> partialBuilder)
            => it.AddFieldName("dto", partialBuilder(new Partial<HADtoDto>(it)));
        
        public static Partial<HATypeDtoDto> WithNullable(this Partial<HATypeDtoDto> it)
            => it.AddFieldName("nullable");
        
        public static Partial<HATypeDtoDto> WithOptional(this Partial<HATypeDtoDto> it)
            => it.AddFieldName("optional");
        
    }
    
}
