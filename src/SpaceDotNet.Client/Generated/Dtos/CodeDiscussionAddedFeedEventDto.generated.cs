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
    public sealed class CodeDiscussionAddedFeedEventDto
         : FeedEventDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "CodeDiscussionAddedFeedEvent";
        
        public CodeDiscussionAddedFeedEventDto() { }
        
        public CodeDiscussionAddedFeedEventDto(CodeDiscussionRecordDto codeDiscussion, CodeReviewRecordDto codeReview)
        {
            CodeDiscussion = codeDiscussion;
            CodeReview = codeReview;
        }
        
        private PropertyValue<CodeDiscussionRecordDto> _codeDiscussion = new PropertyValue<CodeDiscussionRecordDto>(nameof(CodeDiscussionAddedFeedEventDto), nameof(CodeDiscussion));
        
        [Required]
        [JsonPropertyName("codeDiscussion")]
        public CodeDiscussionRecordDto CodeDiscussion
        {
            get { return _codeDiscussion.GetValue(); }
            set { _codeDiscussion.SetValue(value); }
        }
    
        private PropertyValue<CodeReviewRecordDto> _codeReview = new PropertyValue<CodeReviewRecordDto>(nameof(CodeDiscussionAddedFeedEventDto), nameof(CodeReview));
        
        [Required]
        [JsonPropertyName("codeReview")]
        public CodeReviewRecordDto CodeReview
        {
            get { return _codeReview.GetValue(); }
            set { _codeReview.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _codeDiscussion.SetAccessPath(path, validateHasBeenSet);
            _codeReview.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
