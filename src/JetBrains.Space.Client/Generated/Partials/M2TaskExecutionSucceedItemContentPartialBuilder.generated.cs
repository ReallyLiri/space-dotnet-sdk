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

namespace JetBrains.Space.Client.M2TaskExecutionSucceedItemContentPartialBuilder;

public static class M2TaskExecutionSucceedItemContentPartialExtensions
{
    public static Partial<M2TaskExecutionSucceedItemContent> WithTaskExecutionId(this Partial<M2TaskExecutionSucceedItemContent> it)
        => it.AddFieldName("taskExecutionId");
    
    public static Partial<M2TaskExecutionSucceedItemContent> WithTaskExecutionName(this Partial<M2TaskExecutionSucceedItemContent> it)
        => it.AddFieldName("taskExecutionName");
    
    public static Partial<M2TaskExecutionSucceedItemContent> WithRepoName(this Partial<M2TaskExecutionSucceedItemContent> it)
        => it.AddFieldName("repoName");
    
    public static Partial<M2TaskExecutionSucceedItemContent> WithBranchName(this Partial<M2TaskExecutionSucceedItemContent> it)
        => it.AddFieldName("branchName");
    
    public static Partial<M2TaskExecutionSucceedItemContent> WithCommit(this Partial<M2TaskExecutionSucceedItemContent> it)
        => it.AddFieldName("commit");
    
    public static Partial<M2TaskExecutionSucceedItemContent> WithShortCommitMessage(this Partial<M2TaskExecutionSucceedItemContent> it)
        => it.AddFieldName("shortCommitMessage");
    
    public static Partial<M2TaskExecutionSucceedItemContent> WithProject(this Partial<M2TaskExecutionSucceedItemContent> it)
        => it.AddFieldName("project");
    
    public static Partial<M2TaskExecutionSucceedItemContent> WithProject(this Partial<M2TaskExecutionSucceedItemContent> it, Func<Partial<ProjectKey>, Partial<ProjectKey>> partialBuilder)
        => it.AddFieldName("project", partialBuilder(new Partial<ProjectKey>(it)));
    
    public static Partial<M2TaskExecutionSucceedItemContent> WithFinishDateTime(this Partial<M2TaskExecutionSucceedItemContent> it)
        => it.AddFieldName("finishDateTime");
    
    public static Partial<M2TaskExecutionSucceedItemContent> WithTriggerInfo(this Partial<M2TaskExecutionSucceedItemContent> it)
        => it.AddFieldName("triggerInfo");
    
    public static Partial<M2TaskExecutionSucceedItemContent> WithDetails(this Partial<M2TaskExecutionSucceedItemContent> it)
        => it.AddFieldName("details");
    
}

