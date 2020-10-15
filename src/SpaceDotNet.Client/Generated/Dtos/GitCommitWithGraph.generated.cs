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
    public sealed class GitCommitWithGraph
         : IPropagatePropertyAccessPath
    {
        public GitCommitWithGraph() { }
        
        public GitCommitWithGraph(string repositoryName, GitCommitInfo commit, List<CodeReviewRecord> reviews, bool unreachable, GitGraphLayoutLine? layout = null)
        {
            RepositoryName = repositoryName;
            Commit = commit;
            Reviews = reviews;
            Layout = layout;
            IsUnreachable = unreachable;
        }
        
        private PropertyValue<string> _repositoryName = new PropertyValue<string>(nameof(GitCommitWithGraph), nameof(RepositoryName));
        
        [Required]
        [JsonPropertyName("repositoryName")]
        public string RepositoryName
        {
            get { return _repositoryName.GetValue(); }
            set { _repositoryName.SetValue(value); }
        }
    
        private PropertyValue<GitCommitInfo> _commit = new PropertyValue<GitCommitInfo>(nameof(GitCommitWithGraph), nameof(Commit));
        
        [Required]
        [JsonPropertyName("commit")]
        public GitCommitInfo Commit
        {
            get { return _commit.GetValue(); }
            set { _commit.SetValue(value); }
        }
    
        private PropertyValue<List<CodeReviewRecord>> _reviews = new PropertyValue<List<CodeReviewRecord>>(nameof(GitCommitWithGraph), nameof(Reviews));
        
        [Required]
        [JsonPropertyName("reviews")]
        public List<CodeReviewRecord> Reviews
        {
            get { return _reviews.GetValue(); }
            set { _reviews.SetValue(value); }
        }
    
        private PropertyValue<GitGraphLayoutLine?> _layout = new PropertyValue<GitGraphLayoutLine?>(nameof(GitCommitWithGraph), nameof(Layout));
        
        [JsonPropertyName("layout")]
        public GitGraphLayoutLine? Layout
        {
            get { return _layout.GetValue(); }
            set { _layout.SetValue(value); }
        }
    
        private PropertyValue<bool> _unreachable = new PropertyValue<bool>(nameof(GitCommitWithGraph), nameof(IsUnreachable));
        
        [Required]
        [JsonPropertyName("unreachable")]
        public bool IsUnreachable
        {
            get { return _unreachable.GetValue(); }
            set { _unreachable.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _repositoryName.SetAccessPath(path, validateHasBeenSet);
            _commit.SetAccessPath(path, validateHasBeenSet);
            _reviews.SetAccessPath(path, validateHasBeenSet);
            _layout.SetAccessPath(path, validateHasBeenSet);
            _unreachable.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
