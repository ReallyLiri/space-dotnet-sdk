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

namespace SpaceDotNet.Client
{
    public interface IssueChangedM2DetailsDto
         : M2ItemContentDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static IssueAssigneeChangedDetailsDto IssueAssigneeChangedDetails(TDMemberProfileDto? oldAssignee = null, TDMemberProfileDto? newAssignee = null)
            => new IssueAssigneeChangedDetailsDto(oldAssignee: null, newAssignee: null);
        
        public static IssueAttachmentsChangedDetailsDto IssueAttachmentsChangedDetails(List<string>? addedNames = null, List<string>? removedNames = null)
            => new IssueAttachmentsChangedDetailsDto(addedNames: null, removedNames: null);
        
        public static IssueChecklistsChangedDetailsDto IssueChecklistsChangedDetails(List<ChecklistDto>? addedChecklists = null, List<ChecklistDto>? removedChecklists = null)
            => new IssueChecklistsChangedDetailsDto(addedChecklists: null, removedChecklists: null);
        
        public static IssueCreatedDetailsDto IssueCreatedDetails(IssueDto? issue = null)
            => new IssueCreatedDetailsDto(issue: null);
        
        public static IssueDeletedDetailsDto IssueDeletedDetails()
            => new IssueDeletedDetailsDto();
        
        public static IssueDescriptionChangedDetailsDto IssueDescriptionChangedDetails(string? oldDescription = null, string? newDescription = null)
            => new IssueDescriptionChangedDetailsDto(oldDescription: null, newDescription: null);
        
        public static IssueDueDateChangedDetailsDto IssueDueDateChangedDetails(SpaceDate? oldDueDate = null, SpaceDate? newDueDate = null)
            => new IssueDueDateChangedDetailsDto(oldDueDate: null, newDueDate: null);
        
        public static IssueStatusChangedDetailsDto IssueStatusChangedDetails(IssueStatusDto oldStatus, IssueStatusDto newStatus)
            => new IssueStatusChangedDetailsDto(oldStatus: oldStatus, newStatus: newStatus);
        
        public static IssueTagsChangedDetailsDto IssueTagsChangedDetails(List<PlanningTagDto>? addedTags = null, List<PlanningTagDto>? removedTags = null)
            => new IssueTagsChangedDetailsDto(addedTags: null, removedTags: null);
        
        public static IssueTitleChangedDetailsDto IssueTitleChangedDetails(string oldTitle, string newTitle)
            => new IssueTitleChangedDetailsDto(oldTitle: oldTitle, newTitle: newTitle);
        
    }
    
}
