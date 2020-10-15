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

namespace SpaceDotNet.Client.RevisionAuthorInfoPartialBuilder
{
    public static class RevisionAuthorInfoPartialExtensions
    {
        public static Partial<RevisionAuthorInfo> WithRevisionInfo(this Partial<RevisionAuthorInfo> it)
            => it.AddFieldName("revisionInfo");
        
        public static Partial<RevisionAuthorInfo> WithRevisionInfo(this Partial<RevisionAuthorInfo> it, Func<Partial<RevisionInfo>, Partial<RevisionInfo>> partialBuilder)
            => it.AddFieldName("revisionInfo", partialBuilder(new Partial<RevisionInfo>(it)));
        
        public static Partial<RevisionAuthorInfo> WithAuthor(this Partial<RevisionAuthorInfo> it)
            => it.AddFieldName("author");
        
        public static Partial<RevisionAuthorInfo> WithAuthor(this Partial<RevisionAuthorInfo> it, Func<Partial<RevisionAuthor>, Partial<RevisionAuthor>> partialBuilder)
            => it.AddFieldName("author", partialBuilder(new Partial<RevisionAuthor>(it)));
        
    }
    
}
