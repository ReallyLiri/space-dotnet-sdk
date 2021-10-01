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

namespace JetBrains.Space.Client.ProjectsForProjectCodeReviewsMergeRequestsPostRequestPartialBuilder;

public static class ProjectsForProjectCodeReviewsMergeRequestsPostRequestPartialExtensions
{
    public static Partial<ProjectsForProjectCodeReviewsMergeRequestsPostRequest> WithRepository(this Partial<ProjectsForProjectCodeReviewsMergeRequestsPostRequest> it)
        => it.AddFieldName("repository");
    
    public static Partial<ProjectsForProjectCodeReviewsMergeRequestsPostRequest> WithSourceBranch(this Partial<ProjectsForProjectCodeReviewsMergeRequestsPostRequest> it)
        => it.AddFieldName("sourceBranch");
    
    public static Partial<ProjectsForProjectCodeReviewsMergeRequestsPostRequest> WithTargetBranch(this Partial<ProjectsForProjectCodeReviewsMergeRequestsPostRequest> it)
        => it.AddFieldName("targetBranch");
    
    public static Partial<ProjectsForProjectCodeReviewsMergeRequestsPostRequest> WithTitle(this Partial<ProjectsForProjectCodeReviewsMergeRequestsPostRequest> it)
        => it.AddFieldName("title");
    
    public static Partial<ProjectsForProjectCodeReviewsMergeRequestsPostRequest> WithReviewers(this Partial<ProjectsForProjectCodeReviewsMergeRequestsPostRequest> it)
        => it.AddFieldName("reviewers");
    
    public static Partial<ProjectsForProjectCodeReviewsMergeRequestsPostRequest> WithReviewers(this Partial<ProjectsForProjectCodeReviewsMergeRequestsPostRequest> it, Func<Partial<ReviewerParam>, Partial<ReviewerParam>> partialBuilder)
        => it.AddFieldName("reviewers", partialBuilder(new Partial<ReviewerParam>(it)));
    
}

