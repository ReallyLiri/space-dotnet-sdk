// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.UnfurlDetailsSprintDtoPartialBuilder
{
    public static class UnfurlDetailsSprintDtoPartialExtensions
    {
        public static Partial<UnfurlDetailsSprintDto> WithProject(this Partial<UnfurlDetailsSprintDto> it)
            => it.AddFieldName("project");
        
        public static Partial<UnfurlDetailsSprintDto> WithProject(this Partial<UnfurlDetailsSprintDto> it, Func<Partial<PRProjectDto>, Partial<PRProjectDto>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<PRProjectDto>(it)));
        
        public static Partial<UnfurlDetailsSprintDto> WithSprint(this Partial<UnfurlDetailsSprintDto> it)
            => it.AddFieldName("sprint");
        
        public static Partial<UnfurlDetailsSprintDto> WithSprint(this Partial<UnfurlDetailsSprintDto> it, Func<Partial<SprintRecordDto>, Partial<SprintRecordDto>> partialBuilder)
            => it.AddFieldName("sprint", partialBuilder(new Partial<SprintRecordDto>(it)));
        
    }
    
}