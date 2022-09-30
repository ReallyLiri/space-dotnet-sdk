// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public interface WebhookEvent
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static AbsenceApprovalWebhookEvent AbsenceApproval(KMetaMod meta, AbsenceRecord absence, TDMemberProfile member, Modification<bool> approved)
        => new AbsenceApprovalWebhookEvent(meta: meta, absence: absence, member: member, approved: approved);
    
    public static AbsenceWebhookEvent Absence(KMetaMod meta, AbsenceRecord absence, TDMemberProfile member, Modification<string>? icon = null, Modification<AbsenceReasonRecord>? reason = null, Modification<string>? description = null, Modification<DateTime>? since = null, Modification<DateTime>? till = null, Modification<TDLocation>? location = null, Modification<bool>? available = null)
        => new AbsenceWebhookEvent(meta: meta, absence: absence, member: member, icon: icon, reason: reason, description: description, since: since, till: till, location: location, available: available);
    
    public static ApplicationAuthorizationRequestedEvent ApplicationAuthorizationRequestedEvent(KMetaMod meta, ESApp application, AuthScope scope)
        => new ApplicationAuthorizationRequestedEvent(meta: meta, application: application, scope: scope);
    
    public static ApplicationAuthorizedWebhookEvent ApplicationAuthorized(KMetaMod meta, ESApp application, AuthScope scope)
        => new ApplicationAuthorizedWebhookEvent(meta: meta, application: application, scope: scope);
    
    public static ApplicationSshKeyWebhookEvent ApplicationSshKey(KMetaMod meta, ESApp application, Modification<string>? fingerprint = null, Modification<string>? comment = null)
        => new ApplicationSshKeyWebhookEvent(meta: meta, application: application, fingerprint: fingerprint, comment: comment);
    
    public static ApplicationUnfurlQueueItemsCreatedEvent ApplicationUnfurlQueueItemsCreatedEvent()
        => new ApplicationUnfurlQueueItemsCreatedEvent();
    
    public static ApplicationUnfurlTargetWebhookEvent ApplicationUnfurlTarget(KMetaMod meta, ESApp application, ApplicationUnfurlTarget target)
        => new ApplicationUnfurlTargetWebhookEvent(meta: meta, application: application, target: target);
    
    public static ApplicationWebhookEvent Application(KMetaMod meta, ESApp application, bool clientIdChanged, bool clientSecretChanged, bool verificationTokenChanged, bool signingKeyChanged, Modification<string>? name = null, Modification<TDMemberProfile>? owner = null, Modification<bool>? archived = null, Modification<string>? endpointURI = null)
        => new ApplicationWebhookEvent(meta: meta, application: application, clientIdChanged: clientIdChanged, clientSecretChanged: clientSecretChanged, verificationTokenChanged: verificationTokenChanged, signingKeyChanged: signingKeyChanged, name: name, owner: owner, archived: archived, endpointURI: endpointURI);
    
    public static AutomationJobEvent AutomationJobEvent(KMetaMod meta, string executionId, PRProject project, string repositoryName, string jobName, long executionNumber, JobExecutionTrigger trigger, DateTime triggerTime, Modification<JobExecutionStatus>? status = null, Modification<List<FailureConditionType>>? failureReasons = null, Modification<CPrincipal>? stoppedBy = null, Modification<DateTime>? startTime = null, Modification<DateTime>? endTime = null)
        => new AutomationJobEvent(meta: meta, executionId: executionId, project: project, repositoryName: repositoryName, jobName: jobName, executionNumber: executionNumber, trigger: trigger, triggerTime: triggerTime, status: status, failureReasons: failureReasons, stoppedBy: stoppedBy, startTime: startTime, endTime: endTime);
    
    public static BlogWebhookEvent Blog(KMetaMod meta, ArticleRecord article, bool textChanged, string? action = null, Modification<TDMemberProfile>? author = null, Modification<DateTime>? created = null, Modification<string>? title = null, Modification<bool>? unpublished = null, Modification<List<TDTeam>>? teams = null, Modification<List<TDLocation>>? locations = null, Modification<long>? externalEntityInfo = null)
        => new BlogWebhookEvent(meta: meta, article: article, textChanged: textChanged, action: action, author: author, created: created, title: title, unpublished: unpublished, teams: teams, locations: locations, externalEntityInfo: externalEntityInfo);
    
    public static BusinessEntityRelationEvent BusinessEntityRelationEvent(KMetaMod meta, string relation, string entity, TDMemberProfile member, Modification<DateTime>? since = null, Modification<DateTime>? till = null, Modification<bool>? archived = null)
        => new BusinessEntityRelationEvent(meta: meta, relation: relation, entity: entity, member: member, since: since, till: till, archived: archived);
    
    public static ChannelEvent ChannelEvent(KMetaMod meta, M2ChannelRecord channel, Modification<string>? name = null, Modification<string>? description = null, Modification<string>? icon = null, bool? restored = null, bool? archived = null)
        => new ChannelEvent(meta: meta, channel: channel, name: name, description: description, icon: icon, restored: restored, archived: archived);
    
    public static ChatMessageCreatedEvent ChatMessageCreatedEvent(string channelId, ChannelItemRecord message, string? threadId = null)
        => new ChatMessageCreatedEvent(channelId: channelId, message: message, threadId: threadId);
    
    public static ChatMessageDeletedEvent ChatMessageDeletedEvent(string channelId, ChannelItemRecord message, string? threadId = null)
        => new ChatMessageDeletedEvent(channelId: channelId, message: message, threadId: threadId);
    
    public static ChatMessageReactionAddedEvent ChatMessageReactionAddedEvent(string messageId, string channelId, CPrincipal actor, string emoji, int newCount, string? threadId = null)
        => new ChatMessageReactionAddedEvent(messageId: messageId, channelId: channelId, actor: actor, emoji: emoji, newCount: newCount, threadId: threadId);
    
    public static ChatMessageReactionRemovedEvent ChatMessageReactionRemovedEvent(string messageId, string channelId, CPrincipal actor, string emoji, int newCount, string? threadId = null)
        => new ChatMessageReactionRemovedEvent(messageId: messageId, channelId: channelId, actor: actor, emoji: emoji, newCount: newCount, threadId: threadId);
    
    public static ChatMessageUpdatedEvent ChatMessageUpdatedEvent(string channelId, ChannelItemRecord message, string? threadId = null, Modification<DateTime>? edited = null, Modification<bool>? pinned = null)
        => new ChatMessageUpdatedEvent(channelId: channelId, message: message, threadId: threadId, edited: edited, pinned: pinned);
    
    public static CodeReviewWebhookEvent CodeReview(ProjectKey projectKey, string repository, string reviewId, string title, bool isMergeRequest)
        => new CodeReviewWebhookEvent(projectKey: projectKey, repository: repository, reviewId: reviewId, title: title, isMergeRequest: isMergeRequest);
    
    public static CustomEmojiAddedEvent CustomEmojiAddedEvent(string emoji, CPrincipal owner, string attachmentId, DateTime uploadedAt)
        => new CustomEmojiAddedEvent(emoji: emoji, owner: owner, attachmentId: attachmentId, uploadedAt: uploadedAt);
    
    public static CustomEmojiDeletedEvent CustomEmojiDeletedEvent(string emoji, CPrincipal owner)
        => new CustomEmojiDeletedEvent(emoji: emoji, owner: owner);
    
    public static CustomEmojiUpdatedEvent CustomEmojiUpdatedEvent(string emoji, CPrincipal owner, Modification<string>? attachmentId = null, Modification<DateTime>? uploadedAt = null)
        => new CustomEmojiUpdatedEvent(emoji: emoji, owner: owner, attachmentId: attachmentId, uploadedAt: uploadedAt);
    
    public static DeploymentWebhookEvent Deployment(KMetaMod meta, string projectKey, string targetId, string deploymentId, Modification<DeploymentStatus>? statusMod = null)
        => new DeploymentWebhookEvent(meta: meta, projectKey: projectKey, targetId: targetId, deploymentId: deploymentId, statusMod: statusMod);
    
    public static DocumentEditorsChangedEvent DocumentEditorsChangedEvent(KMetaMod meta, string document)
        => new DocumentEditorsChangedEvent(meta: meta, document: document);
    
    public static DocumentMetaWebhookEvent DocumentMeta(KMetaMod meta, string document, Modification<bool>? deleted = null, Modification<bool>? published = null)
        => new DocumentMetaWebhookEvent(meta: meta, document: document, deleted: deleted, published: published);
    
    public static DocumentWebhookEvent Document(KMetaMod meta, string document, List<CPrincipal> changeAuthors, DateTime version, DateTime @base)
        => new DocumentWebhookEvent(meta: meta, document: document, changeAuthors: changeAuthors, version: version, @base: @base);
    
    public static EmailBouncedEvent EmailBouncedEvent(string email, string reason)
        => new EmailBouncedEvent(email: email, reason: reason);
    
    public static FeatureFlagWebhookEvent FeatureFlag(KMetaMod meta, string name, int? issueNumber = null, Modification<bool>? enabledForAll = null, Modification<bool>? selfManageable = null, List<TDTeam>? addedTeams = null, List<TDTeam>? addedProfiles = null, List<TDMemberProfile>? removedTeams = null, List<TDMemberProfile>? removedProfiles = null)
        => new FeatureFlagWebhookEvent(meta: meta, name: name, issueNumber: issueNumber, enabledForAll: enabledForAll, selfManageable: selfManageable, addedTeams: addedTeams, addedProfiles: addedProfiles, removedTeams: removedTeams, removedProfiles: removedProfiles);
    
    public static GoogleIntegrationDisconnectedEvent GoogleIntegrationDisconnectedEvent(TDMemberProfile member)
        => new GoogleIntegrationDisconnectedEvent(member: member);
    
    public static IssueImportTransactionWebhookEvent IssueImportTransaction(KMetaMod meta, ImportTransactionRecord importTransaction)
        => new IssueImportTransactionWebhookEvent(meta: meta, importTransaction: importTransaction);
    
    public static IssueWebhookEvent Issue(KMetaMod meta, Issue issue, Modification<string>? title = null, Modification<string>? description = null, Modification<TDMemberProfile>? assignee = null, Modification<IssueStatus>? status = null, Modification<DateTime>? dueDate = null, Modification<List<PlanningTag>>? tagDelta = null, Modification<List<Topic>>? topicDelta = null, Modification<List<Checklist>>? checklistDelta = null, Modification<List<SprintRecord>>? sprintDelta = null, IssueWebhookCustomFieldUpdate? customFieldUpdate = null, Modification<bool>? deleted = null)
        => new IssueWebhookEvent(meta: meta, issue: issue, title: title, description: description, assignee: assignee, status: status, dueDate: dueDate, tagDelta: tagDelta, topicDelta: topicDelta, checklistDelta: checklistDelta, sprintDelta: sprintDelta, customFieldUpdate: customFieldUpdate, deleted: deleted);
    
    public static LocationEvent LocationEvent(KMetaMod meta, TDLocation location)
        => new LocationEvent(meta: meta, location: location);
    
    public static MeetingWebhookEvent Meeting(KMetaMod meta, MeetingRecord meeting)
        => new MeetingWebhookEvent(meta: meta, meeting: meeting);
    
    public static PingWebhookEvent Ping(string webhookName)
        => new PingWebhookEvent(webhookName: webhookName);
    
    public static ProfileOrganizationEvent ProfileOrganizationEvent(KMetaMod meta, TDMemberProfile member, bool joinedOrganization, bool leftOrganization)
        => new ProfileOrganizationEvent(meta: meta, member: member, joinedOrganization: joinedOrganization, leftOrganization: leftOrganization);
    
    public static ProjectEvent ProjectEvent(KMetaMod meta, PRProject project)
        => new ProjectEvent(meta: meta, project: project);
    
    public static SPackageRepositoryWebhookEvent SPackageRepository(ProjectKey projectKey, string repository, PackageType repositoryType, PackageRepositoryEventAction action, PackageVersionRef packageInfo)
        => new SPackageRepositoryWebhookEvent(projectKey: projectKey, repository: repository, repositoryType: repositoryType, action: action, packageInfo: packageInfo);
    
    public static SRepoCommitsWebhookEvent SRepoCommits(ProjectKey projectKey, string repository, GitCommitInfoWithChanges commit)
        => new SRepoCommitsWebhookEvent(projectKey: projectKey, repository: repository, commit: commit);
    
    public static SRepoHeadsWebhookEvent SRepoHeads(ProjectKey projectKey, string repository, RepoChanges changes)
        => new SRepoHeadsWebhookEvent(projectKey: projectKey, repository: repository, changes: changes);
    
    public static TeamEvent TeamEvent(KMetaMod meta, TDTeam team)
        => new TeamEvent(meta: meta, team: team);
    
    public static TeamMembershipEvent TeamMembershipEvent(KMetaMod meta, TDMembership membership, Modification<TDTeam>? team = null, Modification<TDRole>? role = null, Modification<bool>? lead = null, Modification<TDMemberProfile>? manager = null, Modification<DateTime>? since = null, Modification<DateTime>? till = null, Modification<bool>? deleted = null, Modification<TDMemberProfile>? approvedBy = null)
        => new TeamMembershipEvent(meta: meta, membership: membership, team: team, role: role, lead: lead, manager: manager, since: since, till: till, deleted: deleted, approvedBy: approvedBy);
    
}

