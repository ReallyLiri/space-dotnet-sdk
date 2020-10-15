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

namespace SpaceDotNet.Client.DailyReportPartialBuilder
{
    public static class DailyReportPartialExtensions
    {
        public static Partial<DailyReport> WithData(this Partial<DailyReport> it)
            => it.AddFieldName("data");
        
        public static Partial<DailyReport> WithData(this Partial<DailyReport> it, Func<Partial<BillingDay>, Partial<BillingDay>> partialBuilder)
            => it.AddFieldName("data", partialBuilder(new Partial<BillingDay>(it)));
        
        public static Partial<DailyReport> WithCustomOverdraftCap(this Partial<DailyReport> it)
            => it.AddFieldName("customOverdraftCap");
        
    }
    
}
