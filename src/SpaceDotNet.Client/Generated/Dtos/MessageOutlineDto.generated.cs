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
    public sealed class MessageOutlineDto
         : IPropagatePropertyAccessPath
    {
        public MessageOutlineDto() { }
        
        public MessageOutlineDto(string text, ApiIconDto? icon = null)
        {
            Icon = icon;
            Text = text;
        }
        
        private PropertyValue<ApiIconDto?> _icon = new PropertyValue<ApiIconDto?>(nameof(MessageOutlineDto), nameof(Icon));
        
        [JsonPropertyName("icon")]
        public ApiIconDto? Icon
        {
            get { return _icon.GetValue(); }
            set { _icon.SetValue(value); }
        }
    
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(MessageOutlineDto), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get { return _text.GetValue(); }
            set { _text.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _icon.SetAccessPath(path, validateHasBeenSet);
            _text.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
