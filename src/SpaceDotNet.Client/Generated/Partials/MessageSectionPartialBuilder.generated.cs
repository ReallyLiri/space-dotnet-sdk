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

namespace SpaceDotNet.Client.MessageSectionPartialBuilder
{
    public static class MessageSectionPartialExtensions
    {
        public static Partial<MessageSection> WithHeader(this Partial<MessageSection> it)
            => it.AddFieldName("header");
        
        public static Partial<MessageSection> WithElements(this Partial<MessageSection> it)
            => it.AddFieldName("elements");
        
        public static Partial<MessageSection> WithElements(this Partial<MessageSection> it, Func<Partial<MessageElement>, Partial<MessageElement>> partialBuilder)
            => it.AddFieldName("elements", partialBuilder(new Partial<MessageElement>(it)));
        
        public static Partial<MessageSection> WithFooter(this Partial<MessageSection> it)
            => it.AddFieldName("footer");
        
    }
    
}
