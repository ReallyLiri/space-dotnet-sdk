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
    public sealed class CodeDiscussionSnippetPlainSnippet
         : CodeDiscussionSnippet, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "CodeDiscussionSnippet.PlainSnippet";
        
        public CodeDiscussionSnippetPlainSnippet() { }
        
        public CodeDiscussionSnippetPlainSnippet(List<CodeLine> lines)
        {
            Lines = lines;
        }
        
        private PropertyValue<List<CodeLine>> _lines = new PropertyValue<List<CodeLine>>(nameof(CodeDiscussionSnippetPlainSnippet), nameof(Lines));
        
        [Required]
        [JsonPropertyName("lines")]
        public List<CodeLine> Lines
        {
            get { return _lines.GetValue(); }
            set { _lines.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _lines.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
