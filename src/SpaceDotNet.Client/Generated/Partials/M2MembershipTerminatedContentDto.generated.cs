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

namespace SpaceDotNet.Client.M2MembershipTerminatedContentDtoExtensions
{
    public static class M2MembershipTerminatedContentDtoPartialExtensions
    {
        public static Partial<M2MembershipTerminatedContentDto> WithMembership(this Partial<M2MembershipTerminatedContentDto> it)    => it.AddFieldName("membership");
        
        public static Partial<M2MembershipTerminatedContentDto> WithMembership(this Partial<M2MembershipTerminatedContentDto> it, Func<Partial<TDMembershipDto>, Partial<TDMembershipDto>> partialBuilder)    => it.AddFieldName("membership", partialBuilder(new Partial<TDMembershipDto>()));
        
    }
    
}
