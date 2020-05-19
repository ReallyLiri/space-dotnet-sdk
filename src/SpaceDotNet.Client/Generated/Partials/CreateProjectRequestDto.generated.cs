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

namespace SpaceDotNet.Client.CreateProjectRequestExtensions
{
    public static class CreateProjectRequestDtoPartialExtensions
    {
        public static Partial<CreateProjectRequestDto> WithKey(this Partial<CreateProjectRequestDto> it)
            => it.AddFieldName("key");
        
        public static Partial<CreateProjectRequestDto> WithKey(this Partial<CreateProjectRequestDto> it, Func<Partial<ProjectKeyDto>, Partial<ProjectKeyDto>> partialBuilder)
            => it.AddFieldName("key", partialBuilder(new Partial<ProjectKeyDto>()));
        
        public static Partial<CreateProjectRequestDto> WithName(this Partial<CreateProjectRequestDto> it)
            => it.AddFieldName("name");
        
        public static Partial<CreateProjectRequestDto> WithDescription(this Partial<CreateProjectRequestDto> it)
            => it.AddFieldName("description");
        
        public static Partial<CreateProjectRequestDto> WithPrivate(this Partial<CreateProjectRequestDto> it)
            => it.AddFieldName("private");
        
        public static Partial<CreateProjectRequestDto> WithTags(this Partial<CreateProjectRequestDto> it)
            => it.AddFieldName("tags");
        
        public static Partial<CreateProjectRequestDto> WithTags(this Partial<CreateProjectRequestDto> it, Func<Partial<string>, Partial<string>> partialBuilder)
            => it.AddFieldName("tags", partialBuilder(new Partial<string>()));
        
    }
    
}