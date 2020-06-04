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

namespace SpaceDotNet.Client.PropagatedCodeDiscussionDtoExtensions
{
    public static class PropagatedCodeDiscussionDtoPartialExtensions
    {
        public static Partial<PropagatedCodeDiscussionDto> WithAnchor(this Partial<PropagatedCodeDiscussionDto> it)    => it.AddFieldName("anchor");
        
        public static Partial<PropagatedCodeDiscussionDto> WithAnchor(this Partial<PropagatedCodeDiscussionDto> it, Func<Partial<CodeDiscussionAnchorDto>, Partial<CodeDiscussionAnchorDto>> partialBuilder)    => it.AddFieldName("anchor", partialBuilder(new Partial<CodeDiscussionAnchorDto>()));
        
        public static Partial<PropagatedCodeDiscussionDto> WithDiscussion(this Partial<PropagatedCodeDiscussionDto> it)    => it.AddFieldName("discussion");
        
        public static Partial<PropagatedCodeDiscussionDto> WithDiscussion(this Partial<PropagatedCodeDiscussionDto> it, Func<Partial<CodeDiscussionRecordDto>, Partial<CodeDiscussionRecordDto>> partialBuilder)    => it.AddFieldName("discussion", partialBuilder(new Partial<CodeDiscussionRecordDto>()));
        
    }
    
}
