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
    public sealed class MessageSectionDto
         : MessageSectionElementDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MessageSection";
        
        public MessageSectionDto() { }
        
        public MessageSectionDto(List<MessageElementDto> elements, string? header = null, string? footer = null)
        {
            Header = header;
            Elements = elements;
            Footer = footer;
        }
        
        private PropertyValue<string?> _header = new PropertyValue<string?>(nameof(MessageSectionDto), nameof(Header));
        
        [JsonPropertyName("header")]
        public string? Header
        {
            get { return _header.GetValue(); }
            set { _header.SetValue(value); }
        }
    
        private PropertyValue<List<MessageElementDto>> _elements = new PropertyValue<List<MessageElementDto>>(nameof(MessageSectionDto), nameof(Elements));
        
        [Required]
        [JsonPropertyName("elements")]
        public List<MessageElementDto> Elements
        {
            get { return _elements.GetValue(); }
            set { _elements.SetValue(value); }
        }
    
        private PropertyValue<string?> _footer = new PropertyValue<string?>(nameof(MessageSectionDto), nameof(Footer));
        
        [JsonPropertyName("footer")]
        public string? Footer
        {
            get { return _footer.GetValue(); }
            set { _footer.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _header.SetAccessPath(path, validateHasBeenSet);
            _elements.SetAccessPath(path, validateHasBeenSet);
            _footer.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
