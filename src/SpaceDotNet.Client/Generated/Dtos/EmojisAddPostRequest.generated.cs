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

namespace SpaceDotNet.Client
{
    public class EmojisAddPostRequest
         : IPropagatePropertyAccessPath
    {
        public EmojisAddPostRequest() { }
        
        public EmojisAddPostRequest(string emoji, string attachmentId)
        {
            Emoji = emoji;
            AttachmentId = attachmentId;
        }
        
        private PropertyValue<string> _emoji = new PropertyValue<string>(nameof(EmojisAddPostRequest), nameof(Emoji));
        
        [Required]
        [JsonPropertyName("emoji")]
        public string Emoji
        {
            get { return _emoji.GetValue(); }
            set { _emoji.SetValue(value); }
        }
    
        private PropertyValue<string> _attachmentId = new PropertyValue<string>(nameof(EmojisAddPostRequest), nameof(AttachmentId));
        
        [Required]
        [JsonPropertyName("attachmentId")]
        public string AttachmentId
        {
            get { return _attachmentId.GetValue(); }
            set { _attachmentId.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _emoji.SetAccessPath(path, validateHasBeenSet);
            _attachmentId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
