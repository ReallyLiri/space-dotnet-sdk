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

namespace SpaceDotNet.Client.GitGraphLayoutLinePartialBuilder
{
    public static class GitGraphLayoutLinePartialExtensions
    {
        public static Partial<GitGraphLayoutLine> WithNodes(this Partial<GitGraphLayoutLine> it)
            => it.AddFieldName("nodes");
        
        public static Partial<GitGraphLayoutLine> WithNodes(this Partial<GitGraphLayoutLine> it, Func<Partial<GitGraphLayoutNode>, Partial<GitGraphLayoutNode>> partialBuilder)
            => it.AddFieldName("nodes", partialBuilder(new Partial<GitGraphLayoutNode>(it)));
        
        public static Partial<GitGraphLayoutLine> WithEdges(this Partial<GitGraphLayoutLine> it)
            => it.AddFieldName("edges");
        
        public static Partial<GitGraphLayoutLine> WithEdges(this Partial<GitGraphLayoutLine> it, Func<Partial<GitGraphLayoutEdge>, Partial<GitGraphLayoutEdge>> partialBuilder)
            => it.AddFieldName("edges", partialBuilder(new Partial<GitGraphLayoutEdge>(it)));
        
    }
    
}
