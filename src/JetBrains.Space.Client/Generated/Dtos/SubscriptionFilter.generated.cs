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

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public interface SubscriptionFilter
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static AbsenceCommonSubscriptionFilter AbsenceCommon(List<AbsenceReasonRecord> reasons)
            => new AbsenceCommonSubscriptionFilter(reasons: reasons);
        
        public static ApplicationsSubscriptionFilter Applications(ESApp? application = null)
            => new ApplicationsSubscriptionFilter(application: application);
        
        public static AutomationJobSubscriptionFilter AutomationJob(List<PRProject> projects, string? repositoryName = null, List<string>? branchSpec = null, List<string>? jobs = null)
            => new AutomationJobSubscriptionFilter(projects: projects, repositoryName: repositoryName, branchSpec: branchSpec, jobs: jobs);
        
        public static BlogCommonSubscriptionFilter BlogCommon(List<TDTeam> teams, List<TDLocation> locations, List<TDMemberProfile> authors)
            => new BlogCommonSubscriptionFilter(teams: teams, locations: locations, authors: authors);
        
        public static CodeReviewSubscriptionFilter CodeReview(List<TDMemberProfile> authors, List<TDMemberProfile> participants, List<string> branchSpec, List<string> pathSpec, string titleRegex, PRProject? project = null, string? repository = null)
            => new CodeReviewSubscriptionFilter(authors: authors, participants: participants, branchSpec: branchSpec, pathSpec: pathSpec, titleRegex: titleRegex, project: project, repository: repository);
        
        public static DocumentCustomSubscriptionFilter DocumentCustom(List<KbDocumentItem> documents, PRProject? project = null, List<KBBook>? books = null, List<KbFolderItem>? folders = null)
            => new DocumentCustomSubscriptionFilter(documents: documents, project: project, books: books, folders: folders);
        
        public static MemberCommonSubscriptionFilter MemberCommon(List<TDTeam> teams, List<TDLocation> locations)
            => new MemberCommonSubscriptionFilter(teams: teams, locations: locations);
        
        public static ProjectCommonSubscriptionFilter ProjectCommon(PRProject? project = null)
            => new ProjectCommonSubscriptionFilter(project: project);
        
        public static RepoCommitsSubscriptionFilter RepoCommits(List<PRProject> projects, string repository, RepoCommitsSubscriptionFilterSpec spec)
            => new RepoCommitsSubscriptionFilter(projects: projects, repository: repository, spec: spec);
        
        public static RepoHeadsSubscriptionFilter RepoHeads(List<PRProject> projects, string repository)
            => new RepoHeadsSubscriptionFilter(projects: projects, repository: repository);
        
    }
    
}
