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
    public class BlogsMarkdown2htmlRequest
         : IPropagatePropertyAccessPath
    {
        public BlogsMarkdown2htmlRequest() { }
        
        public BlogsMarkdown2htmlRequest(string markdown)
        {
            Markdown = markdown;
        }
        
        private PropertyValue<string> _markdown = new PropertyValue<string>(nameof(BlogsMarkdown2htmlRequest), nameof(Markdown));
        
        [Required]
        [JsonPropertyName("markdown")]
        public string Markdown
        {
            get { return _markdown.GetValue(); }
            set { _markdown.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _markdown.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
