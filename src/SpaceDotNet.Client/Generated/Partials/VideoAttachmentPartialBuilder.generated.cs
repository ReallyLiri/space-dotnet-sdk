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

namespace SpaceDotNet.Client.VideoAttachmentPartialBuilder
{
    public static class VideoAttachmentPartialExtensions
    {
        public static Partial<VideoAttachment> WithId(this Partial<VideoAttachment> it)
            => it.AddFieldName("id");
        
        public static Partial<VideoAttachment> WithName(this Partial<VideoAttachment> it)
            => it.AddFieldName("name");
        
        public static Partial<VideoAttachment> WithWidth(this Partial<VideoAttachment> it)
            => it.AddFieldName("width");
        
        public static Partial<VideoAttachment> WithHeight(this Partial<VideoAttachment> it)
            => it.AddFieldName("height");
        
        public static Partial<VideoAttachment> WithSizeBytes(this Partial<VideoAttachment> it)
            => it.AddFieldName("sizeBytes");
        
        public static Partial<VideoAttachment> WithPreviewBytes(this Partial<VideoAttachment> it)
            => it.AddFieldName("previewBytes");
        
    }
    
}
