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

namespace SpaceDotNet.Client.M2AbsenceItemApprovedContentDtoExtensions
{
    public static class M2AbsenceItemApprovedContentDtoPartialExtensions
    {
        public static Partial<M2AbsenceItemApprovedContentDto> WithAbsence(this Partial<M2AbsenceItemApprovedContentDto> it)    => it.AddFieldName("absence");
        
        public static Partial<M2AbsenceItemApprovedContentDto> WithAbsence(this Partial<M2AbsenceItemApprovedContentDto> it, Func<Partial<AbsenceRecordDto>, Partial<AbsenceRecordDto>> partialBuilder)    => it.AddFieldName("absence", partialBuilder(new Partial<AbsenceRecordDto>()));
        
        public static Partial<M2AbsenceItemApprovedContentDto> WithBy(this Partial<M2AbsenceItemApprovedContentDto> it)    => it.AddFieldName("by");
        
        public static Partial<M2AbsenceItemApprovedContentDto> WithBy(this Partial<M2AbsenceItemApprovedContentDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)    => it.AddFieldName("by", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<M2AbsenceItemApprovedContentDto> WithApprove(this Partial<M2AbsenceItemApprovedContentDto> it)    => it.AddFieldName("approve");
        
    }
    
}
