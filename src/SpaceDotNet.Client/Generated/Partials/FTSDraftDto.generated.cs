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

namespace SpaceDotNet.Client.FTSDraftDtoExtensions
{
    public static class FTSDraftDtoPartialExtensions
    {
        public static Partial<FTSDraftDto> WithId(this Partial<FTSDraftDto> it)    => it.AddFieldName("id");
        
        public static Partial<FTSDraftDto> WithTitle(this Partial<FTSDraftDto> it)    => it.AddFieldName("title");
        
        public static Partial<FTSDraftDto> WithAuthor(this Partial<FTSDraftDto> it)    => it.AddFieldName("author");
        
        public static Partial<FTSDraftDto> WithAuthor(this Partial<FTSDraftDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)    => it.AddFieldName("author", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<FTSDraftDto> WithDate(this Partial<FTSDraftDto> it)    => it.AddFieldName("date");
        
        public static Partial<FTSDraftDto> WithSnippets(this Partial<FTSDraftDto> it)    => it.AddFieldName("snippets");
        
        public static Partial<FTSDraftDto> WithSnippets(this Partial<FTSDraftDto> it, Func<Partial<FTSSnippetDto>, Partial<FTSSnippetDto>> partialBuilder)    => it.AddFieldName("snippets", partialBuilder(new Partial<FTSSnippetDto>()));
        
    }
    
}
