// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.2542259+00:00
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    [JsonConverter(typeof(EnumerationConverter))]
    public sealed class CodeReviewStateFilter : Enumeration
    {
        private CodeReviewStateFilter(string value) : base(value) { }
        
        public static readonly CodeReviewStateFilter Opened = new CodeReviewStateFilter("Opened");
        public static readonly CodeReviewStateFilter Closed = new CodeReviewStateFilter("Closed");
        public static readonly CodeReviewStateFilter RequiresAuthorAttention = new CodeReviewStateFilter("RequiresAuthorAttention");
        public static readonly CodeReviewStateFilter NeedsReview = new CodeReviewStateFilter("NeedsReview");
    }
    
}
