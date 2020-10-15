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
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.JobExecutionPartialBuilder
{
    public static class JobExecutionPartialExtensions
    {
        public static Partial<JobExecution> WithExecutionId(this Partial<JobExecution> it)
            => it.AddFieldName("executionId");
        
        public static Partial<JobExecution> WithExecutionNumber(this Partial<JobExecution> it)
            => it.AddFieldName("executionNumber");
        
        public static Partial<JobExecution> WithJobId(this Partial<JobExecution> it)
            => it.AddFieldName("jobId");
        
        public static Partial<JobExecution> WithJobName(this Partial<JobExecution> it)
            => it.AddFieldName("jobName");
        
        public static Partial<JobExecution> WithBranch(this Partial<JobExecution> it)
            => it.AddFieldName("branch");
        
        public static Partial<JobExecution> WithStatus(this Partial<JobExecution> it)
            => it.AddFieldName("status");
        
        public static Partial<JobExecution> WithStatus(this Partial<JobExecution> it, Func<Partial<ExecutionStatus>, Partial<ExecutionStatus>> partialBuilder)
            => it.AddFieldName("status", partialBuilder(new Partial<ExecutionStatus>(it)));
        
        public static Partial<JobExecution> WithTriggeredTime(this Partial<JobExecution> it)
            => it.AddFieldName("triggeredTime");
        
        public static Partial<JobExecution> WithStartedTime(this Partial<JobExecution> it)
            => it.AddFieldName("startedTime");
        
        public static Partial<JobExecution> WithFinishedTime(this Partial<JobExecution> it)
            => it.AddFieldName("finishedTime");
        
        public static Partial<JobExecution> WithChangesFromExclude(this Partial<JobExecution> it)
            => it.AddFieldName("changesFromExclude");
        
        public static Partial<JobExecution> WithChangesCount(this Partial<JobExecution> it)
            => it.AddFieldName("changesCount");
        
        public static Partial<JobExecution> WithPredictedEndTime(this Partial<JobExecution> it)
            => it.AddFieldName("predictedEndTime");
        
        public static Partial<JobExecution> WithPredictedEndTime(this Partial<JobExecution> it, Func<Partial<Estimation>, Partial<Estimation>> partialBuilder)
            => it.AddFieldName("predictedEndTime", partialBuilder(new Partial<Estimation>(it)));
        
        public static Partial<JobExecution> WithFailureConditions(this Partial<JobExecution> it)
            => it.AddFieldName("failureConditions");
        
        public static Partial<JobExecution> WithFailureConditions(this Partial<JobExecution> it, Func<Partial<FailureCondition>, Partial<FailureCondition>> partialBuilder)
            => it.AddFieldName("failureConditions", partialBuilder(new Partial<FailureCondition>(it)));
        
    }
    
}
