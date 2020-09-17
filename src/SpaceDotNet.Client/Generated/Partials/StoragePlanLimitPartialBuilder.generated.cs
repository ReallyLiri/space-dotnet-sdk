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

namespace SpaceDotNet.Client.StoragePlanLimitPartialBuilder
{
    public static class StoragePlanLimitPartialExtensions
    {
        public static Partial<StoragePlanLimit> WithFiles(this Partial<StoragePlanLimit> it)
            => it.AddFieldName("files");
        
        public static Partial<StoragePlanLimit> WithFiles(this Partial<StoragePlanLimit> it, Func<Partial<PlanLimit>, Partial<PlanLimit>> partialBuilder)
            => it.AddFieldName("files", partialBuilder(new Partial<PlanLimit>(it)));
        
        public static Partial<StoragePlanLimit> WithPackages(this Partial<StoragePlanLimit> it)
            => it.AddFieldName("packages");
        
        public static Partial<StoragePlanLimit> WithPackages(this Partial<StoragePlanLimit> it, Func<Partial<PlanLimit>, Partial<PlanLimit>> partialBuilder)
            => it.AddFieldName("packages", partialBuilder(new Partial<PlanLimit>(it)));
        
        public static Partial<StoragePlanLimit> WithGit(this Partial<StoragePlanLimit> it)
            => it.AddFieldName("git");
        
        public static Partial<StoragePlanLimit> WithGit(this Partial<StoragePlanLimit> it, Func<Partial<PlanLimit>, Partial<PlanLimit>> partialBuilder)
            => it.AddFieldName("git", partialBuilder(new Partial<PlanLimit>(it)));
        
    }
    
}