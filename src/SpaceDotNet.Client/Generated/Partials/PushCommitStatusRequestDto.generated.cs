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

namespace SpaceDotNet.Client.PushCommitStatusRequestDtoExtensions
{
    public static class PushCommitStatusRequestDtoPartialExtensions
    {
        public static Partial<PushCommitStatusRequestDto> WithBranch(this Partial<PushCommitStatusRequestDto> it)    => it.AddFieldName("branch");
        
        public static Partial<PushCommitStatusRequestDto> WithChanges(this Partial<PushCommitStatusRequestDto> it)    => it.AddFieldName("changes");
        
        public static Partial<PushCommitStatusRequestDto> WithExecutionStatus(this Partial<PushCommitStatusRequestDto> it)    => it.AddFieldName("executionStatus");
        
        public static Partial<PushCommitStatusRequestDto> WithExecutionStatus(this Partial<PushCommitStatusRequestDto> it, Func<Partial<ExecutionStatus>, Partial<ExecutionStatus>> partialBuilder)    => it.AddFieldName("executionStatus", partialBuilder(new Partial<ExecutionStatus>()));
        
        public static Partial<PushCommitStatusRequestDto> WithUrl(this Partial<PushCommitStatusRequestDto> it)    => it.AddFieldName("url");
        
        public static Partial<PushCommitStatusRequestDto> WithExternalServiceName(this Partial<PushCommitStatusRequestDto> it)    => it.AddFieldName("externalServiceName");
        
        public static Partial<PushCommitStatusRequestDto> WithTaskName(this Partial<PushCommitStatusRequestDto> it)    => it.AddFieldName("taskName");
        
        public static Partial<PushCommitStatusRequestDto> WithTaskId(this Partial<PushCommitStatusRequestDto> it)    => it.AddFieldName("taskId");
        
        public static Partial<PushCommitStatusRequestDto> WithTimestamp(this Partial<PushCommitStatusRequestDto> it)    => it.AddFieldName("timestamp");
        
        public static Partial<PushCommitStatusRequestDto> WithDescription(this Partial<PushCommitStatusRequestDto> it)    => it.AddFieldName("description");
        
    }
    
}
