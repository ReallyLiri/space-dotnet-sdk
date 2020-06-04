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

namespace SpaceDotNet.Client.UpdateInvitationRequestDtoExtensions
{
    public static class UpdateInvitationRequestDtoPartialExtensions
    {
        public static Partial<UpdateInvitationRequestDto> WithInviteeEmail(this Partial<UpdateInvitationRequestDto> it)    => it.AddFieldName("inviteeEmail");
        
        public static Partial<UpdateInvitationRequestDto> WithInviteeFirstName(this Partial<UpdateInvitationRequestDto> it)    => it.AddFieldName("inviteeFirstName");
        
        public static Partial<UpdateInvitationRequestDto> WithInviteeLastName(this Partial<UpdateInvitationRequestDto> it)    => it.AddFieldName("inviteeLastName");
        
        public static Partial<UpdateInvitationRequestDto> WithTeam(this Partial<UpdateInvitationRequestDto> it)    => it.AddFieldName("team");
        
        public static Partial<UpdateInvitationRequestDto> WithTeam(this Partial<UpdateInvitationRequestDto> it, Func<Partial<TDTeamDto>, Partial<TDTeamDto>> partialBuilder)    => it.AddFieldName("team", partialBuilder(new Partial<TDTeamDto>()));
        
        public static Partial<UpdateInvitationRequestDto> WithRole(this Partial<UpdateInvitationRequestDto> it)    => it.AddFieldName("role");
        
        public static Partial<UpdateInvitationRequestDto> WithRole(this Partial<UpdateInvitationRequestDto> it, Func<Partial<TDRoleDto>, Partial<TDRoleDto>> partialBuilder)    => it.AddFieldName("role", partialBuilder(new Partial<TDRoleDto>()));
        
    }
    
}
