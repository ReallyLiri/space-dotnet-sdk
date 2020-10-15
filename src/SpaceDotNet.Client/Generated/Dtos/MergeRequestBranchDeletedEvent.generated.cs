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
    public sealed class MergeRequestBranchDeletedEvent
         : FeedEvent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MergeRequestBranchDeletedEvent";
        
        public MergeRequestBranchDeletedEvent() { }
        
        public MergeRequestBranchDeletedEvent(string repository, string branch, MergeRequestBranchType branchType)
        {
            Repository = repository;
            Branch = branch;
            BranchType = branchType;
        }
        
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(MergeRequestBranchDeletedEvent), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get { return _repository.GetValue(); }
            set { _repository.SetValue(value); }
        }
    
        private PropertyValue<string> _branch = new PropertyValue<string>(nameof(MergeRequestBranchDeletedEvent), nameof(Branch));
        
        [Required]
        [JsonPropertyName("branch")]
        public string Branch
        {
            get { return _branch.GetValue(); }
            set { _branch.SetValue(value); }
        }
    
        private PropertyValue<MergeRequestBranchType> _branchType = new PropertyValue<MergeRequestBranchType>(nameof(MergeRequestBranchDeletedEvent), nameof(BranchType));
        
        [Required]
        [JsonPropertyName("branchType")]
        public MergeRequestBranchType BranchType
        {
            get { return _branchType.GetValue(); }
            set { _branchType.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _repository.SetAccessPath(path, validateHasBeenSet);
            _branch.SetAccessPath(path, validateHasBeenSet);
            _branchType.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
