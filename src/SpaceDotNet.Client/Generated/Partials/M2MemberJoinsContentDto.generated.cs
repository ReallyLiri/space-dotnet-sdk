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

namespace SpaceDotNet.Client.M2MemberJoinsContentDtoExtensions
{
    public static class M2MemberJoinsContentDtoPartialExtensions
    {
        public static Partial<M2MemberJoinsContentDto> WithMember(this Partial<M2MemberJoinsContentDto> it)
            => it.AddFieldName("member");
        
        public static Partial<M2MemberJoinsContentDto> WithMember(this Partial<M2MemberJoinsContentDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("member", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
    }
    
}
