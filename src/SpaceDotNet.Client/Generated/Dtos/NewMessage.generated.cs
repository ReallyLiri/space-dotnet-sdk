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
    public sealed class NewMessage
         : ChatModification, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "NewMessage";
        
        public NewMessage() { }
        
        public NewMessage(string text, string temporaryId, bool pending, List<Attachment>? attachments = null, string? draftTag = null)
        {
            Text = text;
            TemporaryId = temporaryId;
            Attachments = attachments;
            IsPending = pending;
            DraftTag = draftTag;
        }
        
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(NewMessage), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get { return _text.GetValue(); }
            set { _text.SetValue(value); }
        }
    
        private PropertyValue<string> _temporaryId = new PropertyValue<string>(nameof(NewMessage), nameof(TemporaryId));
        
        [Required]
        [JsonPropertyName("temporaryId")]
        public string TemporaryId
        {
            get { return _temporaryId.GetValue(); }
            set { _temporaryId.SetValue(value); }
        }
    
        private PropertyValue<List<Attachment>?> _attachments = new PropertyValue<List<Attachment>?>(nameof(NewMessage), nameof(Attachments));
        
        [JsonPropertyName("attachments")]
        public List<Attachment>? Attachments
        {
            get { return _attachments.GetValue(); }
            set { _attachments.SetValue(value); }
        }
    
        private PropertyValue<bool> _pending = new PropertyValue<bool>(nameof(NewMessage), nameof(IsPending));
        
        [Required]
        [JsonPropertyName("pending")]
        public bool IsPending
        {
            get { return _pending.GetValue(); }
            set { _pending.SetValue(value); }
        }
    
        private PropertyValue<string?> _draftTag = new PropertyValue<string?>(nameof(NewMessage), nameof(DraftTag));
        
        [JsonPropertyName("draftTag")]
        public string? DraftTag
        {
            get { return _draftTag.GetValue(); }
            set { _draftTag.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _text.SetAccessPath(path, validateHasBeenSet);
            _temporaryId.SetAccessPath(path, validateHasBeenSet);
            _attachments.SetAccessPath(path, validateHasBeenSet);
            _pending.SetAccessPath(path, validateHasBeenSet);
            _draftTag.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
