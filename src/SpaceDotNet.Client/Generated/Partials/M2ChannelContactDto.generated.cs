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

namespace SpaceDotNet.Client.M2ChannelContactDtoExtensions
{
    public static class M2ChannelContactDtoPartialExtensions
    {
        public static Partial<M2ChannelContactDto> WithDefaultName(this Partial<M2ChannelContactDto> it)
            => it.AddFieldName("defaultName");
        
        public static Partial<M2ChannelContactDto> WithKey(this Partial<M2ChannelContactDto> it)
            => it.AddFieldName("key");
        
        public static Partial<M2ChannelContactDto> WithExt(this Partial<M2ChannelContactDto> it)
            => it.AddFieldName("ext");
        
        public static Partial<M2ChannelContactDto> WithExt(this Partial<M2ChannelContactDto> it, Func<Partial<M2ChannelContactInfoDto>, Partial<M2ChannelContactInfoDto>> partialBuilder)
            => it.AddFieldName("ext", partialBuilder(new Partial<M2ChannelContactInfoDto>(it)));
        
    }
    
}
