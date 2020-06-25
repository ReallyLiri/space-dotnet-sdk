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
    public sealed class UnfurlAttachmentDto
         : AttachmentDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "UnfurlAttachment";
        
        public UnfurlAttachmentDto() { }
        
        public UnfurlAttachmentDto(UnfurlDto unfurl, string? id = null)
        {
            Unfurl = unfurl;
            Id = id;
        }
        
        private PropertyValue<UnfurlDto> _unfurl = new PropertyValue<UnfurlDto>(nameof(UnfurlAttachmentDto), nameof(Unfurl));
        
        [Required]
        [JsonPropertyName("unfurl")]
        public UnfurlDto Unfurl
        {
            get { return _unfurl.GetValue(); }
            set { _unfurl.SetValue(value); }
        }
    
        private PropertyValue<string?> _id = new PropertyValue<string?>(nameof(UnfurlAttachmentDto), nameof(Id));
        
        [JsonPropertyName("id")]
        public string? Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _unfurl.SetAccessPath(path, validateHasBeenSet);
            _id.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
