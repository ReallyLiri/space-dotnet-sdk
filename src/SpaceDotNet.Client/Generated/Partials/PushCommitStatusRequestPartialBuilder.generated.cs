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

namespace SpaceDotNet.Client.PushCommitStatusRequestPartialBuilder
{
    public static class PushCommitStatusRequestPartialExtensions
    {
        public static Partial<PushCommitStatusRequest> WithBranch(this Partial<PushCommitStatusRequest> it)
            => it.AddFieldName("branch");
        
        public static Partial<PushCommitStatusRequest> WithChanges(this Partial<PushCommitStatusRequest> it)
            => it.AddFieldName("changes");
        
        public static Partial<PushCommitStatusRequest> WithExecutionStatus(this Partial<PushCommitStatusRequest> it)
            => it.AddFieldName("executionStatus");
        
        public static Partial<PushCommitStatusRequest> WithExecutionStatus(this Partial<PushCommitStatusRequest> it, Func<Partial<ExecutionStatus>, Partial<ExecutionStatus>> partialBuilder)
            => it.AddFieldName("executionStatus", partialBuilder(new Partial<ExecutionStatus>(it)));
        
        public static Partial<PushCommitStatusRequest> WithUrl(this Partial<PushCommitStatusRequest> it)
            => it.AddFieldName("url");
        
        public static Partial<PushCommitStatusRequest> WithExternalServiceName(this Partial<PushCommitStatusRequest> it)
            => it.AddFieldName("externalServiceName");
        
        public static Partial<PushCommitStatusRequest> WithTaskName(this Partial<PushCommitStatusRequest> it)
            => it.AddFieldName("taskName");
        
        public static Partial<PushCommitStatusRequest> WithTaskId(this Partial<PushCommitStatusRequest> it)
            => it.AddFieldName("taskId");
        
        public static Partial<PushCommitStatusRequest> WithTimestamp(this Partial<PushCommitStatusRequest> it)
            => it.AddFieldName("timestamp");
        
        public static Partial<PushCommitStatusRequest> WithDescription(this Partial<PushCommitStatusRequest> it)
            => it.AddFieldName("description");
        
    }
    
}