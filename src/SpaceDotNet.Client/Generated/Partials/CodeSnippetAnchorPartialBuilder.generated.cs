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

namespace SpaceDotNet.Client.CodeSnippetAnchorPartialBuilder
{
    public static class CodeSnippetAnchorPartialExtensions
    {
        public static Partial<CodeSnippetAnchor> WithProjectKey(this Partial<CodeSnippetAnchor> it)
            => it.AddFieldName("projectKey");
        
        public static Partial<CodeSnippetAnchor> WithProjectKey(this Partial<CodeSnippetAnchor> it, Func<Partial<ProjectKey>, Partial<ProjectKey>> partialBuilder)
            => it.AddFieldName("projectKey", partialBuilder(new Partial<ProjectKey>(it)));
        
        public static Partial<CodeSnippetAnchor> WithRepository(this Partial<CodeSnippetAnchor> it)
            => it.AddFieldName("repository");
        
        public static Partial<CodeSnippetAnchor> WithRevision(this Partial<CodeSnippetAnchor> it)
            => it.AddFieldName("revision");
        
        public static Partial<CodeSnippetAnchor> WithFilename(this Partial<CodeSnippetAnchor> it)
            => it.AddFieldName("filename");
        
        public static Partial<CodeSnippetAnchor> WithLineIndex(this Partial<CodeSnippetAnchor> it)
            => it.AddFieldName("lineIndex");
        
        public static Partial<CodeSnippetAnchor> WithLineStart(this Partial<CodeSnippetAnchor> it)
            => it.AddFieldName("lineStart");
        
        public static Partial<CodeSnippetAnchor> WithLineEnd(this Partial<CodeSnippetAnchor> it)
            => it.AddFieldName("lineEnd");
        
    }
    
}
