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

namespace JetBrains.Space.Client.AllReactionsToItemRecordPartialBuilder;

public static class AllReactionsToItemRecordPartialExtensions
{
    public static Partial<AllReactionsToItemRecord> WithId(this Partial<AllReactionsToItemRecord> it)
        => it.AddFieldName("id");
    
    public static Partial<AllReactionsToItemRecord> WithReactions(this Partial<AllReactionsToItemRecord> it)
        => it.AddFieldName("reactions");
    
    public static Partial<AllReactionsToItemRecord> WithReactions(this Partial<AllReactionsToItemRecord> it, Func<Partial<CertainReactionToItemRecord>, Partial<CertainReactionToItemRecord>> partialBuilder)
        => it.AddFieldName("reactions", partialBuilder(new Partial<CertainReactionToItemRecord>(it)));
    
    public static Partial<AllReactionsToItemRecord> WithEmojiReactions(this Partial<AllReactionsToItemRecord> it)
        => it.AddFieldName("emojiReactions");
    
    public static Partial<AllReactionsToItemRecord> WithEmojiReactions(this Partial<AllReactionsToItemRecord> it, Func<Partial<EmojiReactionRecord>, Partial<EmojiReactionRecord>> partialBuilder)
        => it.AddFieldName("emojiReactions", partialBuilder(new Partial<EmojiReactionRecord>(it)));
    
}

