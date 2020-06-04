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

namespace SpaceDotNet.Client.FTSUserDtoExtensions
{
    public static class FTSUserDtoPartialExtensions
    {
        public static Partial<FTSUserDto> WithId(this Partial<FTSUserDto> it)    => it.AddFieldName("id");
        
        public static Partial<FTSUserDto> WithUsername(this Partial<FTSUserDto> it)    => it.AddFieldName("username");
        
        public static Partial<FTSUserDto> WithName(this Partial<FTSUserDto> it)    => it.AddFieldName("name");
        
        public static Partial<FTSUserDto> WithName(this Partial<FTSUserDto> it, Func<Partial<TDProfileNameDto>, Partial<TDProfileNameDto>> partialBuilder)    => it.AddFieldName("name", partialBuilder(new Partial<TDProfileNameDto>()));
        
        public static Partial<FTSUserDto> WithAvatar(this Partial<FTSUserDto> it)    => it.AddFieldName("avatar");
        
        public static Partial<FTSUserDto> WithLanguages(this Partial<FTSUserDto> it)    => it.AddFieldName("languages");
        
        public static Partial<FTSUserDto> WithLanguages(this Partial<FTSUserDto> it, Func<Partial<TDProfileNameDto>, Partial<TDProfileNameDto>> partialBuilder)    => it.AddFieldName("languages", partialBuilder(new Partial<TDProfileNameDto>()));
        
        public static Partial<FTSUserDto> WithNotAMember(this Partial<FTSUserDto> it)    => it.AddFieldName("notAMember");
        
    }
    
}
