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
    public sealed class PostMessageActionDto
         : MessageActionDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "PostMessageAction";
        
        public PostMessageActionDto() { }
        
        public PostMessageActionDto(string actionId, string payload)
        {
            ActionId = actionId;
            Payload = payload;
        }
        
        private PropertyValue<string> _actionId = new PropertyValue<string>(nameof(PostMessageActionDto), nameof(ActionId));
        
        [Required]
        [JsonPropertyName("actionId")]
        public string ActionId
        {
            get { return _actionId.GetValue(); }
            set { _actionId.SetValue(value); }
        }
    
        private PropertyValue<string> _payload = new PropertyValue<string>(nameof(PostMessageActionDto), nameof(Payload));
        
        [Required]
        [JsonPropertyName("payload")]
        public string Payload
        {
            get { return _payload.GetValue(); }
            set { _payload.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _actionId.SetAccessPath(path, validateHasBeenSet);
            _payload.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
