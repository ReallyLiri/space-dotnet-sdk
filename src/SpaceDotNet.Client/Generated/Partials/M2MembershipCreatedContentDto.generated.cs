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

namespace SpaceDotNet.Client.M2MembershipCreatedContentDtoExtensions
{
    public static class M2MembershipCreatedContentDtoPartialExtensions
    {
        public static Partial<M2MembershipCreatedContentDto> WithMembership(this Partial<M2MembershipCreatedContentDto> it)
            => it.AddFieldName("membership");
        
        public static Partial<M2MembershipCreatedContentDto> WithMembership(this Partial<M2MembershipCreatedContentDto> it, Func<Partial<TDMembershipDto>, Partial<TDMembershipDto>> partialBuilder)
            => it.AddFieldName("membership", partialBuilder(new Partial<TDMembershipDto>(it)));
        
    }
    
}
