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

namespace SpaceDotNet.Client.UpdateHolidayRequestDtoExtensions
{
    public static class UpdateHolidayRequestDtoPartialExtensions
    {
        public static Partial<UpdateHolidayRequestDto> WithCalendar(this Partial<UpdateHolidayRequestDto> it)    => it.AddFieldName("calendar");
        
        public static Partial<UpdateHolidayRequestDto> WithName(this Partial<UpdateHolidayRequestDto> it)    => it.AddFieldName("name");
        
        public static Partial<UpdateHolidayRequestDto> WithDate(this Partial<UpdateHolidayRequestDto> it)    => it.AddFieldName("date");
        
        public static Partial<UpdateHolidayRequestDto> WithWorkingDay(this Partial<UpdateHolidayRequestDto> it)    => it.AddFieldName("workingDay");
        
    }
    
}
