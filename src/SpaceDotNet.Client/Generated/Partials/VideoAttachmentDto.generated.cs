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

namespace SpaceDotNet.Client.VideoAttachmentDtoExtensions
{
    public static class VideoAttachmentDtoPartialExtensions
    {
        public static Partial<VideoAttachmentDto> WithId(this Partial<VideoAttachmentDto> it)
            => it.AddFieldName("id");
        
        public static Partial<VideoAttachmentDto> WithName(this Partial<VideoAttachmentDto> it)
            => it.AddFieldName("name");
        
        public static Partial<VideoAttachmentDto> WithWidth(this Partial<VideoAttachmentDto> it)
            => it.AddFieldName("width");
        
        public static Partial<VideoAttachmentDto> WithHeight(this Partial<VideoAttachmentDto> it)
            => it.AddFieldName("height");
        
        public static Partial<VideoAttachmentDto> WithSizeBytes(this Partial<VideoAttachmentDto> it)
            => it.AddFieldName("sizeBytes");
        
        public static Partial<VideoAttachmentDto> WithPreviewBytes(this Partial<VideoAttachmentDto> it)
            => it.AddFieldName("previewBytes");
        
    }
    
}
