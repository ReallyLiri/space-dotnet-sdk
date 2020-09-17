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

namespace SpaceDotNet.Client.M2TaskExecutionFailureItemContentPartialBuilder
{
    public static class M2TaskExecutionFailureItemContentPartialExtensions
    {
        public static Partial<M2TaskExecutionFailureItemContent> WithTaskExecutionId(this Partial<M2TaskExecutionFailureItemContent> it)
            => it.AddFieldName("taskExecutionId");
        
        public static Partial<M2TaskExecutionFailureItemContent> WithTaskExecutionName(this Partial<M2TaskExecutionFailureItemContent> it)
            => it.AddFieldName("taskExecutionName");
        
        public static Partial<M2TaskExecutionFailureItemContent> WithRepoName(this Partial<M2TaskExecutionFailureItemContent> it)
            => it.AddFieldName("repoName");
        
        public static Partial<M2TaskExecutionFailureItemContent> WithBranchName(this Partial<M2TaskExecutionFailureItemContent> it)
            => it.AddFieldName("branchName");
        
        public static Partial<M2TaskExecutionFailureItemContent> WithCommit(this Partial<M2TaskExecutionFailureItemContent> it)
            => it.AddFieldName("commit");
        
        public static Partial<M2TaskExecutionFailureItemContent> WithShortCommitMessage(this Partial<M2TaskExecutionFailureItemContent> it)
            => it.AddFieldName("shortCommitMessage");
        
        public static Partial<M2TaskExecutionFailureItemContent> WithProject(this Partial<M2TaskExecutionFailureItemContent> it)
            => it.AddFieldName("project");
        
        public static Partial<M2TaskExecutionFailureItemContent> WithProject(this Partial<M2TaskExecutionFailureItemContent> it, Func<Partial<ProjectKey>, Partial<ProjectKey>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<ProjectKey>(it)));
        
        public static Partial<M2TaskExecutionFailureItemContent> WithFinishDateTime(this Partial<M2TaskExecutionFailureItemContent> it)
            => it.AddFieldName("finishDateTime");
        
        public static Partial<M2TaskExecutionFailureItemContent> WithTriggerInfo(this Partial<M2TaskExecutionFailureItemContent> it)
            => it.AddFieldName("triggerInfo");
        
        public static Partial<M2TaskExecutionFailureItemContent> WithDetails(this Partial<M2TaskExecutionFailureItemContent> it)
            => it.AddFieldName("details");
        
    }
    
}