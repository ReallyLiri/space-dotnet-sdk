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

namespace JetBrains.Space.Client.MessageTagPartialBuilder;

public static class MessageTagPartialExtensions
{
    public static Partial<MessageTag> WithText(this Partial<MessageTag> it)
        => it.AddFieldName("text");
    
    public static Partial<MessageTag> WithStyle(this Partial<MessageTag> it)
        => it.AddFieldName("style");
    
    public static Partial<MessageTag> WithStyle(this Partial<MessageTag> it, Func<Partial<MessageStyle>, Partial<MessageStyle>> partialBuilder)
        => it.AddFieldName("style", partialBuilder(new Partial<MessageStyle>(it)));
    
}

