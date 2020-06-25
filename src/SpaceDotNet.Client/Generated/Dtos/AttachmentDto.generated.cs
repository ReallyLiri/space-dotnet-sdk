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

namespace SpaceDotNet.Client
{
    public interface AttachmentDto
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static DeletedAttachmentDto Deleted(string deletedIdentity)
            => new DeletedAttachmentDto(deletedIdentity: deletedIdentity);
        
        public static FileAttachmentDto File(string id, long sizeBytes, string filename)
            => new FileAttachmentDto(id: id, sizeBytes: sizeBytes, filename: filename);
        
        public static ImageAttachmentDto Image(string id, int width, int height, string? name = null, string? previewBytes = null, List<ImageAttachmentVariantDto>? variants = null)
            => new ImageAttachmentDto(id: id, width: width, height: height, name: null, previewBytes: null, variants: null);
        
        public static ProfileLinkPreviewDto ProfileLinkPreview(TDMemberProfileDto profile)
            => new ProfileLinkPreviewDto(profile: profile);
        
        public static UnfurlAttachmentDto Unfurl(UnfurlDto unfurl, string? id = null)
            => new UnfurlAttachmentDto(unfurl: unfurl, id: null);
        
        public static VideoAttachmentDto Video(string id, long sizeBytes, string? name = null, int? width = null, int? height = null, string? previewBytes = null)
            => new VideoAttachmentDto(id: id, sizeBytes: sizeBytes, name: null, width: null, height: null, previewBytes: null);
        
    }
    
}
