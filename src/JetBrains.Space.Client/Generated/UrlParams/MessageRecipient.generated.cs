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

[JsonConverter(typeof(UrlParameterConverter))]
public abstract class MessageRecipient : IUrlParameter
{
    public static MessageRecipient Channel(ChatChannel channel)
        => new MessageRecipientChannel(channel);
    
    public static MessageRecipient CodeReview(string codeReview)
        => new MessageRecipientCodeReview(codeReview);
    
    public static MessageRecipient Issue(string issue)
        => new MessageRecipientIssue(issue);
    
    public static MessageRecipient Member(ProfileIdentifier member)
        => new MessageRecipientMember(member);
    
    private class MessageRecipientChannel : MessageRecipient
    {
        private readonly ChatChannel _channel;
        
        public MessageRecipientChannel(ChatChannel channel)
        {
            _channel = channel;
        }
        
        public override string ToString()
            => $"channel:{_channel}";
    }
    
    private class MessageRecipientCodeReview : MessageRecipient
    {
        private readonly string _codeReview;
        
        public MessageRecipientCodeReview(string codeReview)
        {
            _codeReview = codeReview;
        }
        
        public override string ToString()
            => $"codeReview:{_codeReview}";
    }
    
    private class MessageRecipientIssue : MessageRecipient
    {
        private readonly string _issue;
        
        public MessageRecipientIssue(string issue)
        {
            _issue = issue;
        }
        
        public override string ToString()
            => $"issue:{_issue}";
    }
    
    private class MessageRecipientMember : MessageRecipient
    {
        private readonly ProfileIdentifier _member;
        
        public MessageRecipientMember(ProfileIdentifier member)
        {
            _member = member;
        }
        
        public override string ToString()
            => $"member:{_member}";
    }
    
}

