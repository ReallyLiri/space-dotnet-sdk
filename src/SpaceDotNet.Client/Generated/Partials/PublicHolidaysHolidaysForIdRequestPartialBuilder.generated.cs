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

namespace SpaceDotNet.Client.PublicHolidaysHolidaysForIdRequestPartialBuilder
{
    public static class PublicHolidaysHolidaysForIdRequestPartialExtensions
    {
        public static Partial<PublicHolidaysHolidaysForIdRequest> WithCalendar(this Partial<PublicHolidaysHolidaysForIdRequest> it)
            => it.AddFieldName("calendar");
        
        public static Partial<PublicHolidaysHolidaysForIdRequest> WithName(this Partial<PublicHolidaysHolidaysForIdRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<PublicHolidaysHolidaysForIdRequest> WithDate(this Partial<PublicHolidaysHolidaysForIdRequest> it)
            => it.AddFieldName("date");
        
        public static Partial<PublicHolidaysHolidaysForIdRequest> WithWorkingDay(this Partial<PublicHolidaysHolidaysForIdRequest> it)
            => it.AddFieldName("workingDay");
        
    }
    
}