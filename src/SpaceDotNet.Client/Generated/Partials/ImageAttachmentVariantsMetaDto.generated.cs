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

namespace SpaceDotNet.Client.ImageAttachmentVariantsMetaDtoExtensions
{
    public static class ImageAttachmentVariantsMetaDtoPartialExtensions
    {
        public static Partial<ImageAttachmentVariantsMetaDto> WithId(this Partial<ImageAttachmentVariantsMetaDto> it)
            => it.AddFieldName("id");
        
        public static Partial<ImageAttachmentVariantsMetaDto> WithName(this Partial<ImageAttachmentVariantsMetaDto> it)
            => it.AddFieldName("name");
        
        public static Partial<ImageAttachmentVariantsMetaDto> WithWidth(this Partial<ImageAttachmentVariantsMetaDto> it)
            => it.AddFieldName("width");
        
        public static Partial<ImageAttachmentVariantsMetaDto> WithHeight(this Partial<ImageAttachmentVariantsMetaDto> it)
            => it.AddFieldName("height");
        
    }
    
}
