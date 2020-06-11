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

namespace SpaceDotNet.Client.FTSProfileDtoExtensions
{
    public static class FTSProfileDtoPartialExtensions
    {
        public static Partial<FTSProfileDto> WithProfile(this Partial<FTSProfileDto> it)
            => it.AddFieldName("profile");
        
        public static Partial<FTSProfileDto> WithProfile(this Partial<FTSProfileDto> it, Func<Partial<FTSUserDto>, Partial<FTSUserDto>> partialBuilder)
            => it.AddFieldName("profile", partialBuilder(new Partial<FTSUserDto>(it)));
        
        public static Partial<FTSProfileDto> WithSnippets(this Partial<FTSProfileDto> it)
            => it.AddFieldName("snippets");
        
        public static Partial<FTSProfileDto> WithSnippets(this Partial<FTSProfileDto> it, Func<Partial<FTSSnippetDto>, Partial<FTSSnippetDto>> partialBuilder)
            => it.AddFieldName("snippets", partialBuilder(new Partial<FTSSnippetDto>(it)));
        
        public static Partial<FTSProfileDto> WithMember(this Partial<FTSProfileDto> it)
            => it.AddFieldName("member");
        
        public static Partial<FTSProfileDto> WithMember(this Partial<FTSProfileDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("member", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
    }
    
}
