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
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class GitMergeResultHttp
         : IPropagatePropertyAccessPath
    {
        public GitMergeResultHttp() { }
        
        public GitMergeResultHttp(GitMergeStatusHttp status, string? resultCommitId = null)
        {
            Status = status;
            ResultCommitId = resultCommitId;
        }
        
        private PropertyValue<GitMergeStatusHttp> _status = new PropertyValue<GitMergeStatusHttp>(nameof(GitMergeResultHttp), nameof(Status));
        
        [Required]
        [JsonPropertyName("status")]
        public GitMergeStatusHttp Status
        {
            get => _status.GetValue();
            set => _status.SetValue(value);
        }
    
        private PropertyValue<string?> _resultCommitId = new PropertyValue<string?>(nameof(GitMergeResultHttp), nameof(ResultCommitId));
        
        [JsonPropertyName("resultCommitId")]
        public string? ResultCommitId
        {
            get => _resultCommitId.GetValue();
            set => _resultCommitId.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _status.SetAccessPath(path, validateHasBeenSet);
            _resultCommitId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
