// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
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

namespace SpaceDotNet.Client.JobPartialBuilder
{
    public static class JobPartialExtensions
    {
        public static Partial<Job> WithId(this Partial<Job> it)
            => it.AddFieldName("id");
        
        public static Partial<Job> WithName(this Partial<Job> it)
            => it.AddFieldName("name");
        
        public static Partial<Job> WithRepoName(this Partial<Job> it)
            => it.AddFieldName("repoName");
        
        public static Partial<Job> WithIsArchive(this Partial<Job> it)
            => it.AddFieldName("archive");
        
    }
    
}