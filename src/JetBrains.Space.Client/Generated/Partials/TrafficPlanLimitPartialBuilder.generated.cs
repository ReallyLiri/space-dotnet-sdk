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
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.TrafficPlanLimitPartialBuilder
{
    public static class TrafficPlanLimitPartialExtensions
    {
        public static Partial<TrafficPlanLimit> WithDataTransfer(this Partial<TrafficPlanLimit> it)
            => it.AddFieldName("dataTransfer");
        
        public static Partial<TrafficPlanLimit> WithDataTransfer(this Partial<TrafficPlanLimit> it, Func<Partial<PlanLimit>, Partial<PlanLimit>> partialBuilder)
            => it.AddFieldName("dataTransfer", partialBuilder(new Partial<PlanLimit>(it)));
        
        public static Partial<TrafficPlanLimit> WithFiles(this Partial<TrafficPlanLimit> it)
            => it.AddFieldName("files");
        
        public static Partial<TrafficPlanLimit> WithFiles(this Partial<TrafficPlanLimit> it, Func<Partial<PlanLimit>, Partial<PlanLimit>> partialBuilder)
            => it.AddFieldName("files", partialBuilder(new Partial<PlanLimit>(it)));
        
        public static Partial<TrafficPlanLimit> WithPackages(this Partial<TrafficPlanLimit> it)
            => it.AddFieldName("packages");
        
        public static Partial<TrafficPlanLimit> WithPackages(this Partial<TrafficPlanLimit> it, Func<Partial<PlanLimit>, Partial<PlanLimit>> partialBuilder)
            => it.AddFieldName("packages", partialBuilder(new Partial<PlanLimit>(it)));
        
        public static Partial<TrafficPlanLimit> WithGit(this Partial<TrafficPlanLimit> it)
            => it.AddFieldName("git");
        
        public static Partial<TrafficPlanLimit> WithGit(this Partial<TrafficPlanLimit> it, Func<Partial<PlanLimit>, Partial<PlanLimit>> partialBuilder)
            => it.AddFieldName("git", partialBuilder(new Partial<PlanLimit>(it)));
        
    }
    
}