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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.CodeDiscussionAddedFeedEventPartialBuilder;

public static class CodeDiscussionAddedFeedEventPartialExtensions
{
    public static Partial<CodeDiscussionAddedFeedEvent> WithCodeDiscussion(this Partial<CodeDiscussionAddedFeedEvent> it)
        => it.AddFieldName("codeDiscussion");
    
    public static Partial<CodeDiscussionAddedFeedEvent> WithCodeDiscussion(this Partial<CodeDiscussionAddedFeedEvent> it, Func<Partial<CodeDiscussionRecord>, Partial<CodeDiscussionRecord>> partialBuilder)
        => it.AddFieldName("codeDiscussion", partialBuilder(new Partial<CodeDiscussionRecord>(it)));
    
    public static Partial<CodeDiscussionAddedFeedEvent> WithCodeReview(this Partial<CodeDiscussionAddedFeedEvent> it)
        => it.AddFieldName("codeReview");
    
    public static Partial<CodeDiscussionAddedFeedEvent> WithCodeReview(this Partial<CodeDiscussionAddedFeedEvent> it, Func<Partial<CodeReviewRecord>, Partial<CodeReviewRecord>> partialBuilder)
        => it.AddFieldName("codeReview", partialBuilder(new Partial<CodeReviewRecord>(it)));
    
}

