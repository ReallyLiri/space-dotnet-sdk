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
    public sealed class MergeRequestBranchPair
         : IPropagatePropertyAccessPath
    {
        public MergeRequestBranchPair() { }
        
        public MergeRequestBranchPair(string repository, string sourceBranch, string targetBranch, string sourceBranchRef, MergeRequestBranch? sourceBranchInfo = null, MergeRequestBranch? targetBranchInfo = null)
        {
            Repository = repository;
            SourceBranch = sourceBranch;
            TargetBranch = targetBranch;
            SourceBranchRef = sourceBranchRef;
            SourceBranchInfo = sourceBranchInfo;
            TargetBranchInfo = targetBranchInfo;
        }
        
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(MergeRequestBranchPair), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get { return _repository.GetValue(); }
            set { _repository.SetValue(value); }
        }
    
        private PropertyValue<string> _sourceBranch = new PropertyValue<string>(nameof(MergeRequestBranchPair), nameof(SourceBranch));
        
        [Required]
        [JsonPropertyName("sourceBranch")]
        public string SourceBranch
        {
            get { return _sourceBranch.GetValue(); }
            set { _sourceBranch.SetValue(value); }
        }
    
        private PropertyValue<string> _targetBranch = new PropertyValue<string>(nameof(MergeRequestBranchPair), nameof(TargetBranch));
        
        [Required]
        [JsonPropertyName("targetBranch")]
        public string TargetBranch
        {
            get { return _targetBranch.GetValue(); }
            set { _targetBranch.SetValue(value); }
        }
    
        private PropertyValue<string> _sourceBranchRef = new PropertyValue<string>(nameof(MergeRequestBranchPair), nameof(SourceBranchRef));
        
        [Required]
        [JsonPropertyName("sourceBranchRef")]
        public string SourceBranchRef
        {
            get { return _sourceBranchRef.GetValue(); }
            set { _sourceBranchRef.SetValue(value); }
        }
    
        private PropertyValue<MergeRequestBranch?> _sourceBranchInfo = new PropertyValue<MergeRequestBranch?>(nameof(MergeRequestBranchPair), nameof(SourceBranchInfo));
        
        [JsonPropertyName("sourceBranchInfo")]
        public MergeRequestBranch? SourceBranchInfo
        {
            get { return _sourceBranchInfo.GetValue(); }
            set { _sourceBranchInfo.SetValue(value); }
        }
    
        private PropertyValue<MergeRequestBranch?> _targetBranchInfo = new PropertyValue<MergeRequestBranch?>(nameof(MergeRequestBranchPair), nameof(TargetBranchInfo));
        
        [JsonPropertyName("targetBranchInfo")]
        public MergeRequestBranch? TargetBranchInfo
        {
            get { return _targetBranchInfo.GetValue(); }
            set { _targetBranchInfo.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _repository.SetAccessPath(path, validateHasBeenSet);
            _sourceBranch.SetAccessPath(path, validateHasBeenSet);
            _targetBranch.SetAccessPath(path, validateHasBeenSet);
            _sourceBranchRef.SetAccessPath(path, validateHasBeenSet);
            _sourceBranchInfo.SetAccessPath(path, validateHasBeenSet);
            _targetBranchInfo.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
