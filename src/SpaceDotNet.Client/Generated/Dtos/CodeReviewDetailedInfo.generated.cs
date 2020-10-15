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
    public sealed class CodeReviewDetailedInfo
         : IPropagatePropertyAccessPath
    {
        public CodeReviewDetailedInfo() { }
        
        public CodeReviewDetailedInfo(CodeReviewRecord shortInfo, List<RevisionsInReview> commits, CodeReviewDiscussionCounter discussionCounter, List<TrackedBranchesInReview> branches)
        {
            ShortInfo = shortInfo;
            Commits = commits;
            DiscussionCounter = discussionCounter;
            Branches = branches;
        }
        
        private PropertyValue<CodeReviewRecord> _shortInfo = new PropertyValue<CodeReviewRecord>(nameof(CodeReviewDetailedInfo), nameof(ShortInfo));
        
        [Required]
        [JsonPropertyName("shortInfo")]
        public CodeReviewRecord ShortInfo
        {
            get { return _shortInfo.GetValue(); }
            set { _shortInfo.SetValue(value); }
        }
    
        private PropertyValue<List<RevisionsInReview>> _commits = new PropertyValue<List<RevisionsInReview>>(nameof(CodeReviewDetailedInfo), nameof(Commits));
        
        [Required]
        [JsonPropertyName("commits")]
        public List<RevisionsInReview> Commits
        {
            get { return _commits.GetValue(); }
            set { _commits.SetValue(value); }
        }
    
        private PropertyValue<CodeReviewDiscussionCounter> _discussionCounter = new PropertyValue<CodeReviewDiscussionCounter>(nameof(CodeReviewDetailedInfo), nameof(DiscussionCounter));
        
        [Required]
        [JsonPropertyName("discussionCounter")]
        public CodeReviewDiscussionCounter DiscussionCounter
        {
            get { return _discussionCounter.GetValue(); }
            set { _discussionCounter.SetValue(value); }
        }
    
        private PropertyValue<List<TrackedBranchesInReview>> _branches = new PropertyValue<List<TrackedBranchesInReview>>(nameof(CodeReviewDetailedInfo), nameof(Branches));
        
        [Required]
        [JsonPropertyName("branches")]
        public List<TrackedBranchesInReview> Branches
        {
            get { return _branches.GetValue(); }
            set { _branches.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _shortInfo.SetAccessPath(path, validateHasBeenSet);
            _commits.SetAccessPath(path, validateHasBeenSet);
            _discussionCounter.SetAccessPath(path, validateHasBeenSet);
            _branches.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
