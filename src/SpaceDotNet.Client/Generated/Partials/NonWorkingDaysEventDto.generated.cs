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

namespace SpaceDotNet.Client.NonWorkingDaysEventDtoExtensions
{
    public static class NonWorkingDaysEventDtoPartialExtensions
    {
        public static Partial<NonWorkingDaysEventDto> WithProfile(this Partial<NonWorkingDaysEventDto> it)
            => it.AddFieldName("profile");
        
        public static Partial<NonWorkingDaysEventDto> WithProfile(this Partial<NonWorkingDaysEventDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("profile", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
        public static Partial<NonWorkingDaysEventDto> WithDays(this Partial<NonWorkingDaysEventDto> it)
            => it.AddFieldName("days");
        
        public static Partial<NonWorkingDaysEventDto> WithDays(this Partial<NonWorkingDaysEventDto> it, Func<Partial<NonWorkingDaysDto>, Partial<NonWorkingDaysDto>> partialBuilder)
            => it.AddFieldName("days", partialBuilder(new Partial<NonWorkingDaysDto>(it)));
        
    }
    
}
