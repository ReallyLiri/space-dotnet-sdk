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

namespace JetBrains.Space.Client;

public interface ApplicationUnfurlContext
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static ArticleAppUnfurlContext ArticleAppUnfurlContext(string articleId)
        => new ArticleAppUnfurlContext(articleId: articleId);
    
    public static ChatMessageUnfurlContext ChatMessageUnfurlContext(string channel, ChatMessageIdentifier messageId)
        => new ChatMessageUnfurlContext(channel: channel, messageId: messageId);
    
    public static CodeReviewUnfurlContext CodeReviewUnfurlContext(string reviewId)
        => new CodeReviewUnfurlContext(reviewId: reviewId);
    
    public static CommitMessageUnfurlContext CommitMessageUnfurlContext(string projectId, string repo, string commitId)
        => new CommitMessageUnfurlContext(projectId: projectId, repo: repo, commitId: commitId);
    
    public static DocumentAppUnfurlContext DocumentAppUnfurlContext(string documentId)
        => new DocumentAppUnfurlContext(documentId: documentId);
    
    public static IssueUnfurlContext IssueUnfurlContext(string issueId)
        => new IssueUnfurlContext(issueId: issueId);
    
    public static TodoItemUnfurlContext TodoItemUnfurlContext(string userId, string todoItemId)
        => new TodoItemUnfurlContext(userId: userId, todoItemId: todoItemId);
    
}

