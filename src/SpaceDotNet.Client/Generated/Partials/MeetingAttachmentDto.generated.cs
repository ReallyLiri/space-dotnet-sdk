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

namespace SpaceDotNet.Client.MeetingAttachmentDtoExtensions
{
    public static class MeetingAttachmentDtoPartialExtensions
    {
        public static Partial<MeetingAttachmentDto> WithFileUrl(this Partial<MeetingAttachmentDto> it)    => it.AddFieldName("fileUrl");
        
        public static Partial<MeetingAttachmentDto> WithTitle(this Partial<MeetingAttachmentDto> it)    => it.AddFieldName("title");
        
        public static Partial<MeetingAttachmentDto> WithMimeType(this Partial<MeetingAttachmentDto> it)    => it.AddFieldName("mimeType");
        
        public static Partial<MeetingAttachmentDto> WithFileId(this Partial<MeetingAttachmentDto> it)    => it.AddFieldName("fileId");
        
        public static Partial<MeetingAttachmentDto> WithSource(this Partial<MeetingAttachmentDto> it)    => it.AddFieldName("source");
        
    }
    
}
