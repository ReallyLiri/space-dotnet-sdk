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

public interface ChannelContactThread
     : M2ChannelContactInfo, IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static M2ChannelContactThread M2(M2ChannelRecord parent, string? text = null, string? messageId = null, TDMemberProfile? author = null, CPrincipal? messageAuthor = null, string? attachments = null)
        => new M2ChannelContactThread(parent: parent, text: text, messageId: messageId, author: author, messageAuthor: messageAuthor, attachments: attachments);
    
    public static M2ChannelContentCodeDiscussionInReview M2ChannelContentCodeDiscussionInReview(ChannelSpecificDefaults notificationDefaults, CodeDiscussionRecord codeDiscussion, M2ChannelRecord parent, string messageId)
        => new M2ChannelContentCodeDiscussionInReview(notificationDefaults: notificationDefaults, codeDiscussion: codeDiscussion, parent: parent, messageId: messageId);
    
}

