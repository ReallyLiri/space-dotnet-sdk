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

namespace SpaceDotNet.Client.UnfurlDetailsDateTimeRangePartialBuilder
{
    public static class UnfurlDetailsDateTimeRangePartialExtensions
    {
        public static Partial<UnfurlDetailsDateTimeRange> WithSince(this Partial<UnfurlDetailsDateTimeRange> it)
            => it.AddFieldName("since");
        
        public static Partial<UnfurlDetailsDateTimeRange> WithTill(this Partial<UnfurlDetailsDateTimeRange> it)
            => it.AddFieldName("till");
        
        public static Partial<UnfurlDetailsDateTimeRange> WithParams(this Partial<UnfurlDetailsDateTimeRange> it)
            => it.AddFieldName("params");
        
        public static Partial<UnfurlDetailsDateTimeRange> WithParams(this Partial<UnfurlDetailsDateTimeRange> it, Func<Partial<DateTimeViewParams>, Partial<DateTimeViewParams>> partialBuilder)
            => it.AddFieldName("params", partialBuilder(new Partial<DateTimeViewParams>(it)));
        
    }
    
}