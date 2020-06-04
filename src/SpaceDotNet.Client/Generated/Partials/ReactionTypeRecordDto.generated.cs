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

namespace SpaceDotNet.Client.ReactionTypeRecordDtoExtensions
{
    public static class ReactionTypeRecordDtoPartialExtensions
    {
        public static Partial<ReactionTypeRecordDto> WithId(this Partial<ReactionTypeRecordDto> it)    => it.AddFieldName("id");
        
        public static Partial<ReactionTypeRecordDto> WithArchived(this Partial<ReactionTypeRecordDto> it)    => it.AddFieldName("archived");
        
        public static Partial<ReactionTypeRecordDto> WithData(this Partial<ReactionTypeRecordDto> it)    => it.AddFieldName("data");
        
        public static Partial<ReactionTypeRecordDto> WithData(this Partial<ReactionTypeRecordDto> it, Func<Partial<ReactionDataDto>, Partial<ReactionDataDto>> partialBuilder)    => it.AddFieldName("data", partialBuilder(new Partial<ReactionDataDto>()));
        
        public static Partial<ReactionTypeRecordDto> WithProvider(this Partial<ReactionTypeRecordDto> it)    => it.AddFieldName("provider");
        
        public static Partial<ReactionTypeRecordDto> WithProvider(this Partial<ReactionTypeRecordDto> it, Func<Partial<CPrincipalDto>, Partial<CPrincipalDto>> partialBuilder)    => it.AddFieldName("provider", partialBuilder(new Partial<CPrincipalDto>()));
        
        public static Partial<ReactionTypeRecordDto> WithAddedAt(this Partial<ReactionTypeRecordDto> it)    => it.AddFieldName("addedAt");
        
        public static Partial<ReactionTypeRecordDto> WithOrder(this Partial<ReactionTypeRecordDto> it)    => it.AddFieldName("order");
        
    }
    
}
