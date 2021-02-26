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
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class CodeDiscussionRecord
         : IPropagatePropertyAccessPath
    {
        public CodeDiscussionRecord() { }
        
        public CodeDiscussionRecord(string id, string projectId, CodeDiscussionAnchor anchor, DateTime created, M2ChannelRecord channel, bool resolved, bool archived, PRProject? project = null, bool? resolvable = null, CodeDiscussionSnippet? snippet = null, bool? pending = null, CodeReviewRecord? review = null, string? feedItemId = null, List<CodeReviewRecord>? reviews = null)
        {
            Id = id;
            ProjectId = projectId;
            Project = project;
            Anchor = anchor;
            Created = created;
            Channel = channel;
            IsResolvable = resolvable;
            IsResolved = resolved;
            Snippet = snippet;
            IsPending = pending;
            Review = review;
            FeedItemId = feedItemId;
            Reviews = reviews;
            IsArchived = archived;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(CodeDiscussionRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<string> _projectId = new PropertyValue<string>(nameof(CodeDiscussionRecord), nameof(ProjectId));
        
        [Required]
        [Obsolete("Use project instead (since 2020-01-18)")]
        [JsonPropertyName("projectId")]
        public string ProjectId
        {
            get => _projectId.GetValue();
            set => _projectId.SetValue(value);
        }
    
        private PropertyValue<PRProject?> _project = new PropertyValue<PRProject?>(nameof(CodeDiscussionRecord), nameof(Project));
        
        [JsonPropertyName("project")]
        public PRProject? Project
        {
            get => _project.GetValue();
            set => _project.SetValue(value);
        }
    
        private PropertyValue<CodeDiscussionAnchor> _anchor = new PropertyValue<CodeDiscussionAnchor>(nameof(CodeDiscussionRecord), nameof(Anchor));
        
        [Required]
        [JsonPropertyName("anchor")]
        public CodeDiscussionAnchor Anchor
        {
            get => _anchor.GetValue();
            set => _anchor.SetValue(value);
        }
    
        private PropertyValue<DateTime> _created = new PropertyValue<DateTime>(nameof(CodeDiscussionRecord), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Created
        {
            get => _created.GetValue();
            set => _created.SetValue(value);
        }
    
        private PropertyValue<M2ChannelRecord> _channel = new PropertyValue<M2ChannelRecord>(nameof(CodeDiscussionRecord), nameof(Channel));
        
        [Required]
        [JsonPropertyName("channel")]
        public M2ChannelRecord Channel
        {
            get => _channel.GetValue();
            set => _channel.SetValue(value);
        }
    
        private PropertyValue<bool?> _resolvable = new PropertyValue<bool?>(nameof(CodeDiscussionRecord), nameof(IsResolvable));
        
        [JsonPropertyName("resolvable")]
        public bool? IsResolvable
        {
            get => _resolvable.GetValue();
            set => _resolvable.SetValue(value);
        }
    
        private PropertyValue<bool> _resolved = new PropertyValue<bool>(nameof(CodeDiscussionRecord), nameof(IsResolved));
        
        [Required]
        [JsonPropertyName("resolved")]
        public bool IsResolved
        {
            get => _resolved.GetValue();
            set => _resolved.SetValue(value);
        }
    
        private PropertyValue<CodeDiscussionSnippet?> _snippet = new PropertyValue<CodeDiscussionSnippet?>(nameof(CodeDiscussionRecord), nameof(Snippet));
        
        [JsonPropertyName("snippet")]
        public CodeDiscussionSnippet? Snippet
        {
            get => _snippet.GetValue();
            set => _snippet.SetValue(value);
        }
    
        private PropertyValue<bool?> _pending = new PropertyValue<bool?>(nameof(CodeDiscussionRecord), nameof(IsPending));
        
        [JsonPropertyName("pending")]
        public bool? IsPending
        {
            get => _pending.GetValue();
            set => _pending.SetValue(value);
        }
    
        private PropertyValue<CodeReviewRecord?> _review = new PropertyValue<CodeReviewRecord?>(nameof(CodeDiscussionRecord), nameof(Review));
        
        [JsonPropertyName("review")]
        public CodeReviewRecord? Review
        {
            get => _review.GetValue();
            set => _review.SetValue(value);
        }
    
        private PropertyValue<string?> _feedItemId = new PropertyValue<string?>(nameof(CodeDiscussionRecord), nameof(FeedItemId));
        
        [JsonPropertyName("feedItemId")]
        public string? FeedItemId
        {
            get => _feedItemId.GetValue();
            set => _feedItemId.SetValue(value);
        }
    
        private PropertyValue<List<CodeReviewRecord>?> _reviews = new PropertyValue<List<CodeReviewRecord>?>(nameof(CodeDiscussionRecord), nameof(Reviews));
        
        [JsonPropertyName("reviews")]
        public List<CodeReviewRecord>? Reviews
        {
            get => _reviews.GetValue();
            set => _reviews.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(CodeDiscussionRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _projectId.SetAccessPath(path, validateHasBeenSet);
            _project.SetAccessPath(path, validateHasBeenSet);
            _anchor.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _channel.SetAccessPath(path, validateHasBeenSet);
            _resolvable.SetAccessPath(path, validateHasBeenSet);
            _resolved.SetAccessPath(path, validateHasBeenSet);
            _snippet.SetAccessPath(path, validateHasBeenSet);
            _pending.SetAccessPath(path, validateHasBeenSet);
            _review.SetAccessPath(path, validateHasBeenSet);
            _feedItemId.SetAccessPath(path, validateHasBeenSet);
            _reviews.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
