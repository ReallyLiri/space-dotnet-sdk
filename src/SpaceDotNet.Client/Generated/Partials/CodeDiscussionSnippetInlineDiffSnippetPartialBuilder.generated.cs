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

namespace SpaceDotNet.Client.CodeDiscussionSnippetInlineDiffSnippetPartialBuilder
{
    public static class CodeDiscussionSnippetInlineDiffSnippetPartialExtensions
    {
        public static Partial<CodeDiscussionSnippetInlineDiffSnippet> WithLines(this Partial<CodeDiscussionSnippetInlineDiffSnippet> it)
            => it.AddFieldName("lines");
        
        public static Partial<CodeDiscussionSnippetInlineDiffSnippet> WithLines(this Partial<CodeDiscussionSnippetInlineDiffSnippet> it, Func<Partial<InlineDiffLine>, Partial<InlineDiffLine>> partialBuilder)
            => it.AddFieldName("lines", partialBuilder(new Partial<InlineDiffLine>(it)));
        
    }
    
}
