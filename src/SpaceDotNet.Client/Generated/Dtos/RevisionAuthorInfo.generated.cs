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
    public sealed class RevisionAuthorInfo
         : IPropagatePropertyAccessPath
    {
        public RevisionAuthorInfo() { }
        
        public RevisionAuthorInfo(RevisionInfo revisionInfo, RevisionAuthor author)
        {
            RevisionInfo = revisionInfo;
            Author = author;
        }
        
        private PropertyValue<RevisionInfo> _revisionInfo = new PropertyValue<RevisionInfo>(nameof(RevisionAuthorInfo), nameof(RevisionInfo));
        
        [Required]
        [JsonPropertyName("revisionInfo")]
        public RevisionInfo RevisionInfo
        {
            get { return _revisionInfo.GetValue(); }
            set { _revisionInfo.SetValue(value); }
        }
    
        private PropertyValue<RevisionAuthor> _author = new PropertyValue<RevisionAuthor>(nameof(RevisionAuthorInfo), nameof(Author));
        
        [Required]
        [JsonPropertyName("author")]
        public RevisionAuthor Author
        {
            get { return _author.GetValue(); }
            set { _author.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _revisionInfo.SetAccessPath(path, validateHasBeenSet);
            _author.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
