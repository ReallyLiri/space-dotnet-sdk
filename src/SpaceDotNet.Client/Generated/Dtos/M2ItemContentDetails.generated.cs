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
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public interface M2ItemContentDetails
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static M2AbsenceItemApproveDeletedContent M2AbsenceItemApproveDeletedContent(AbsenceRecord absence, TDMemberProfile by, bool approve)
            => new M2AbsenceItemApproveDeletedContent(absence: absence, by: by, approve: approve);
        
        public static M2AbsenceItemApprovedContent M2AbsenceItemApprovedContent(AbsenceRecord absence, TDMemberProfile by, bool approve)
            => new M2AbsenceItemApprovedContent(absence: absence, by: by, approve: approve);
        
        public static M2AbsenceItemContent M2AbsenceItemContent(AbsenceRecord absence, TDMemberProfile? by = null)
            => new M2AbsenceItemContent(absence: absence, by: null);
        
        public static M2AbsenceItemDeletedContent M2AbsenceItemDeletedContent(AbsenceRecord absence, TDMemberProfile? by = null)
            => new M2AbsenceItemDeletedContent(absence: absence, by: null);
        
        public static M2AbsenceItemUpdatedContent M2AbsenceItemUpdatedContent(AbsenceRecord absence, Modification<AbsenceReasonRecord>? reason = null, Modification<string>? description = null, Modification<SpaceDate>? since = null, Modification<SpaceDate>? till = null, TDMemberProfile? by = null)
            => new M2AbsenceItemUpdatedContent(absence: absence, reason: null, description: null, since: null, till: null, by: null);
        
        public static M2ChannelArchivedItemDetails M2ChannelArchivedItemDetails()
            => new M2ChannelArchivedItemDetails();
        
        public static M2ChannelCreatedItemDetails M2ChannelCreatedItemDetails()
            => new M2ChannelCreatedItemDetails();
        
        public static M2ChannelFeedIntroItemDetails M2ChannelFeedIntroItemDetails()
            => new M2ChannelFeedIntroItemDetails();
        
        public static M2ChannelRestoredItemDetails M2ChannelRestoredItemDetails()
            => new M2ChannelRestoredItemDetails();
        
        public static M2DraftEditorAddedItemContent M2DraftEditorAddedItemContent(string id, string title)
            => new M2DraftEditorAddedItemContent(id: id, title: title);
        
        public static M2DraftEditorTeamAddedItemContent M2DraftEditorTeamAddedItemContent(string id, TDTeam team, string title)
            => new M2DraftEditorTeamAddedItemContent(id: id, team: team, title: title);
        
        public static M2ExternalStatusFailureItemContent M2ExternalStatusFailureItemContent(string repository, string branch, string url, string externalServiceName, string taskName, string? projectId = null, RevisionAuthorInfo? revisionInfo = null, LastChanges? changesInfo = null, long? timestamp = null, string? description = null)
            => new M2ExternalStatusFailureItemContent(repository: repository, branch: branch, url: url, externalServiceName: externalServiceName, taskName: taskName, projectId: null, revisionInfo: null, changesInfo: null, timestamp: null, description: null);
        
        public static M2ExternalStatusSucceedItemContent M2ExternalStatusSucceedItemContent(string repository, string branch, string url, string externalServiceName, string taskName, string? projectId = null, RevisionAuthorInfo? revisionInfo = null, LastChanges? changesInfo = null, long? timestamp = null, string? description = null)
            => new M2ExternalStatusSucceedItemContent(repository: repository, branch: branch, url: url, externalServiceName: externalServiceName, taskName: taskName, projectId: null, revisionInfo: null, changesInfo: null, timestamp: null, description: null);
        
        public static M2MaintenanceActionContent M2MaintenanceActionContent(string action, bool success, string details)
            => new M2MaintenanceActionContent(action: action, success: success, details: details);
        
        public static M2MemberContent M2MemberContent()
            => new M2MemberContent();
        
        public static M2MembershipContent M2MembershipContent()
            => new M2MembershipContent();
        
        public static M2PollContent M2PollContent(PollRecord poll)
            => new M2PollContent(poll: poll);
        
        public static M2TaskExecutionFailureItemContent M2TaskExecutionFailureItemContent(string taskExecutionId, string taskExecutionName, string repoName, string branchName, string commit, string shortCommitMessage, ProjectKey project, long finishDateTime, string triggerInfo, string details)
            => new M2TaskExecutionFailureItemContent(taskExecutionId: taskExecutionId, taskExecutionName: taskExecutionName, repoName: repoName, branchName: branchName, commit: commit, shortCommitMessage: shortCommitMessage, project: project, finishDateTime: finishDateTime, triggerInfo: triggerInfo, details: details);
        
        public static M2TaskExecutionSucceedItemContent M2TaskExecutionSucceedItemContent(string taskExecutionId, string taskExecutionName, string repoName, string branchName, string commit, string shortCommitMessage, ProjectKey project, long finishDateTime, string triggerInfo, string details)
            => new M2TaskExecutionSucceedItemContent(taskExecutionId: taskExecutionId, taskExecutionName: taskExecutionName, repoName: repoName, branchName: branchName, commit: commit, shortCommitMessage: shortCommitMessage, project: project, finishDateTime: finishDateTime, triggerInfo: triggerInfo, details: details);
        
        public static M2TextItemContent M2TextItemContent(bool? markdown = null)
            => new M2TextItemContent(markdown: null);
        
        public static M2UserLeftChannel M2UserLeftChannel()
            => new M2UserLeftChannel();
        
        public static MCMessage MCMessage(string style, List<MCElement> content, MCOutline? outline = null, string? serviceId = null, string? supplementaryData = null, M2ItemContentDetails? extension = null)
            => new MCMessage(style: style, content: content, outline: null, serviceId: null, supplementaryData: null, extension: null);
        
        public static MCMessageCommonDetails MCMessageCommonDetails()
            => new MCMessageCommonDetails();
        
        public static MembersAddedItemDetails MembersAddedItemDetails(List<CPrincipal> principals, List<string> othersDisplayNames)
            => new MembersAddedItemDetails(principals: principals, othersDisplayNames: othersDisplayNames);
        
        public static StickerContentDetails StickerContentDetails(Sticker sticker, StickerPackInfo? pack = null)
            => new StickerContentDetails(sticker: sticker, pack: null);
        
        public static TeamAddedItemDetails TeamAddedItemDetails(TDTeam team)
            => new TeamAddedItemDetails(team: team);
        
    }
    
}
