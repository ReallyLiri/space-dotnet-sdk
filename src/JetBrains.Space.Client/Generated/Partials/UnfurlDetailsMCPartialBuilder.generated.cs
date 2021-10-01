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

namespace JetBrains.Space.Client.UnfurlDetailsMCPartialBuilder;

public static class UnfurlDetailsMCPartialExtensions
{
    public static Partial<UnfurlDetailsMC> WithMessage(this Partial<UnfurlDetailsMC> it)
        => it.AddFieldName("message");
    
    public static Partial<UnfurlDetailsMC> WithMessage(this Partial<UnfurlDetailsMC> it, Func<Partial<MCMessage>, Partial<MCMessage>> partialBuilder)
        => it.AddFieldName("message", partialBuilder(new Partial<MCMessage>(it)));
    
    public static Partial<UnfurlDetailsMC> WithInlineUnfurls(this Partial<UnfurlDetailsMC> it)
        => it.AddFieldName("inlineUnfurls");
    
    public static Partial<UnfurlDetailsMC> WithInlineUnfurls(this Partial<UnfurlDetailsMC> it, Func<Partial<AttachmentInfo>, Partial<AttachmentInfo>> partialBuilder)
        => it.AddFieldName("inlineUnfurls", partialBuilder(new Partial<AttachmentInfo>(it)));
    
}

