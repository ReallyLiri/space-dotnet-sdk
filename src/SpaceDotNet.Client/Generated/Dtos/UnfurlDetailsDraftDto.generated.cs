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
    public sealed class UnfurlDetailsDraftDto
         : UnfurlDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "UnfurlDetailsDraft";
        
        public UnfurlDetailsDraftDto() { }
        
        public UnfurlDetailsDraftDto(string draft, string title)
        {
            Draft = draft;
            Title = title;
        }
        
        private PropertyValue<string> _draft = new PropertyValue<string>(nameof(UnfurlDetailsDraftDto), nameof(Draft));
        
        [Required]
        [JsonPropertyName("draft")]
        public string Draft
        {
            get { return _draft.GetValue(); }
            set { _draft.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(UnfurlDetailsDraftDto), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _draft.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
