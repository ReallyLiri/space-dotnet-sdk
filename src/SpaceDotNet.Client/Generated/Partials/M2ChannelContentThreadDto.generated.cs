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

namespace SpaceDotNet.Client.M2ChannelContentThreadDtoExtensions
{
    public static class M2ChannelContentThreadDtoPartialExtensions
    {
        public static Partial<M2ChannelContentThreadDto> WithRecord(this Partial<M2ChannelContentThreadDto> it)
            => it.AddFieldName("record");
        
        public static Partial<M2ChannelContentThreadDto> WithRecord(this Partial<M2ChannelContentThreadDto> it, Func<Partial<ChannelItemRecordDto>, Partial<ChannelItemRecordDto>> partialBuilder)
            => it.AddFieldName("record", partialBuilder(new Partial<ChannelItemRecordDto>(it)));
        
        public static Partial<M2ChannelContentThreadDto> WithParent(this Partial<M2ChannelContentThreadDto> it)
            => it.AddFieldName("parent");
        
        public static Partial<M2ChannelContentThreadDto> WithParent(this Partial<M2ChannelContentThreadDto> it, Func<Partial<M2ChannelRecordDto>, Partial<M2ChannelRecordDto>> partialBuilder)
            => it.AddFieldName("parent", partialBuilder(new Partial<M2ChannelRecordDto>(it)));
        
    }
    
}
