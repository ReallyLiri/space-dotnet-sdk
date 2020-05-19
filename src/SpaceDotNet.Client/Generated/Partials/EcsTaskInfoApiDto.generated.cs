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

namespace SpaceDotNet.Client.EcsTaskInfoApiExtensions
{
    public static class EcsTaskInfoApiDtoPartialExtensions
    {
        public static Partial<EcsTaskInfoApiDto> WithTaskArn(this Partial<EcsTaskInfoApiDto> it)
            => it.AddFieldName("taskArn");
        
        public static Partial<EcsTaskInfoApiDto> WithContainers(this Partial<EcsTaskInfoApiDto> it)
            => it.AddFieldName("containers");
        
        public static Partial<EcsTaskInfoApiDto> WithContainers(this Partial<EcsTaskInfoApiDto> it, Func<Partial<EcsTaskContainerInfoDto>, Partial<EcsTaskContainerInfoDto>> partialBuilder)
            => it.AddFieldName("containers", partialBuilder(new Partial<EcsTaskContainerInfoDto>()));
        
        public static Partial<EcsTaskInfoApiDto> WithDesiredStatus(this Partial<EcsTaskInfoApiDto> it)
            => it.AddFieldName("desiredStatus");
        
        public static Partial<EcsTaskInfoApiDto> WithLastStatus(this Partial<EcsTaskInfoApiDto> it)
            => it.AddFieldName("lastStatus");
        
        public static Partial<EcsTaskInfoApiDto> WithPullStartedAt(this Partial<EcsTaskInfoApiDto> it)
            => it.AddFieldName("pullStartedAt");
        
        public static Partial<EcsTaskInfoApiDto> WithStoppedAt(this Partial<EcsTaskInfoApiDto> it)
            => it.AddFieldName("stoppedAt");
        
        public static Partial<EcsTaskInfoApiDto> WithExecution(this Partial<EcsTaskInfoApiDto> it)
            => it.AddFieldName("execution");
        
    }
    
}