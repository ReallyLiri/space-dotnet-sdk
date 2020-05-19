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

namespace SpaceDotNet.Client.IssueChecklistsChangedDetailsExtensions
{
    public static class IssueChecklistsChangedDetailsDtoPartialExtensions
    {
        public static Partial<IssueChecklistsChangedDetailsDto> WithAddedChecklists(this Partial<IssueChecklistsChangedDetailsDto> it)
            => it.AddFieldName("addedChecklists");
        
        public static Partial<IssueChecklistsChangedDetailsDto> WithAddedChecklists(this Partial<IssueChecklistsChangedDetailsDto> it, Func<Partial<ChecklistDto>, Partial<ChecklistDto>> partialBuilder)
            => it.AddFieldName("addedChecklists", partialBuilder(new Partial<ChecklistDto>()));
        
        public static Partial<IssueChecklistsChangedDetailsDto> WithRemovedChecklists(this Partial<IssueChecklistsChangedDetailsDto> it)
            => it.AddFieldName("removedChecklists");
        
        public static Partial<IssueChecklistsChangedDetailsDto> WithRemovedChecklists(this Partial<IssueChecklistsChangedDetailsDto> it, Func<Partial<ChecklistDto>, Partial<ChecklistDto>> partialBuilder)
            => it.AddFieldName("removedChecklists", partialBuilder(new Partial<ChecklistDto>()));
        
    }
    
}