// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.CodeReviewParticipantPartialBuilder
{
    public static class CodeReviewParticipantPartialExtensions
    {
        public static Partial<CodeReviewParticipant> WithUser(this Partial<CodeReviewParticipant> it)
            => it.AddFieldName("user");
        
        public static Partial<CodeReviewParticipant> WithUser(this Partial<CodeReviewParticipant> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("user", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<CodeReviewParticipant> WithRole(this Partial<CodeReviewParticipant> it)
            => it.AddFieldName("role");
        
        public static Partial<CodeReviewParticipant> WithRole(this Partial<CodeReviewParticipant> it, Func<Partial<CodeReviewParticipantRole>, Partial<CodeReviewParticipantRole>> partialBuilder)
            => it.AddFieldName("role", partialBuilder(new Partial<CodeReviewParticipantRole>(it)));
        
        public static Partial<CodeReviewParticipant> WithState(this Partial<CodeReviewParticipant> it)
            => it.AddFieldName("state");
        
        public static Partial<CodeReviewParticipant> WithState(this Partial<CodeReviewParticipant> it, Func<Partial<ReviewerState>, Partial<ReviewerState>> partialBuilder)
            => it.AddFieldName("state", partialBuilder(new Partial<ReviewerState>(it)));
        
        public static Partial<CodeReviewParticipant> WithIsTheirTurn(this Partial<CodeReviewParticipant> it)
            => it.AddFieldName("theirTurn");
        
        public static Partial<CodeReviewParticipant> WithQualityGateSlots(this Partial<CodeReviewParticipant> it)
            => it.AddFieldName("qualityGateSlots");
        
        public static Partial<CodeReviewParticipant> WithQualityGateSlots(this Partial<CodeReviewParticipant> it, Func<Partial<CodeReviewParticipantQualityGateSlot>, Partial<CodeReviewParticipantQualityGateSlot>> partialBuilder)
            => it.AddFieldName("qualityGateSlots", partialBuilder(new Partial<CodeReviewParticipantQualityGateSlot>(it)));
        
        public static Partial<CodeReviewParticipant> WithAddedAt(this Partial<CodeReviewParticipant> it)
            => it.AddFieldName("addedAt");
        
    }
    
}
