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

namespace SpaceDotNet.Client.ChecklistDtoExtensions
{
    public static class ChecklistDtoPartialExtensions
    {
        public static Partial<ChecklistDto> WithId(this Partial<ChecklistDto> it)
            => it.AddFieldName("id");
        
        public static Partial<ChecklistDto> WithArchived(this Partial<ChecklistDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<ChecklistDto> WithProjectId(this Partial<ChecklistDto> it)
            => it.AddFieldName("projectId");
        
        public static Partial<ChecklistDto> WithProject(this Partial<ChecklistDto> it)
            => it.AddFieldName("project");
        
        public static Partial<ChecklistDto> WithProject(this Partial<ChecklistDto> it, Func<Partial<PRProjectDto>, Partial<PRProjectDto>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<PRProjectDto>(it)));
        
        public static Partial<ChecklistDto> WithOwner(this Partial<ChecklistDto> it)
            => it.AddFieldName("owner");
        
        public static Partial<ChecklistDto> WithOwner(this Partial<ChecklistDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("owner", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
        public static Partial<ChecklistDto> WithName(this Partial<ChecklistDto> it)
            => it.AddFieldName("name");
        
        public static Partial<ChecklistDto> WithRoot(this Partial<ChecklistDto> it)
            => it.AddFieldName("root");
        
        public static Partial<ChecklistDto> WithRoot(this Partial<ChecklistDto> it, Func<Partial<PlanItemDto>, Partial<PlanItemDto>> partialBuilder)
            => it.AddFieldName("root", partialBuilder(new Partial<PlanItemDto>(it)));
        
        public static Partial<ChecklistDto> WithRootTag(this Partial<ChecklistDto> it)
            => it.AddFieldName("rootTag");
        
        public static Partial<ChecklistDto> WithRootTag(this Partial<ChecklistDto> it, Func<Partial<PlanningTagDto>, Partial<PlanningTagDto>> partialBuilder)
            => it.AddFieldName("rootTag", partialBuilder(new Partial<PlanningTagDto>(it)));
        
        public static Partial<ChecklistDto> WithDescription(this Partial<ChecklistDto> it)
            => it.AddFieldName("description");
        
        public static Partial<ChecklistDto> WithTotalItemsCount(this Partial<ChecklistDto> it)
            => it.AddFieldName("totalItemsCount");
        
        public static Partial<ChecklistDto> WithDoneItemsCount(this Partial<ChecklistDto> it)
            => it.AddFieldName("doneItemsCount");
        
        public static Partial<ChecklistDto> WithUpdatedTime(this Partial<ChecklistDto> it)
            => it.AddFieldName("updatedTime");
        
    }
    
}
