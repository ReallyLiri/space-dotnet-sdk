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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

[JsonConverter(typeof(UrlParameterConverter))]
public abstract class TimeTrackingSubjectIdentifier : IUrlParameter
{
    public static TimeTrackingSubjectIdentifier Issue(IssueIdentifier issue)
        => new TimeTrackingSubjectIdentifierIssue(issue);
    
    public class TimeTrackingSubjectIdentifierIssue : TimeTrackingSubjectIdentifier
    {
        [Required]
        [JsonPropertyName("issue")]
#if NET6_0_OR_GREATER
        public IssueIdentifier Issue { get; init; }
#else
        public IssueIdentifier Issue { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
#pragma warning disable CS8618
        public TimeTrackingSubjectIdentifierIssue() { }
#pragma warning restore CS8618
#endif
        
        public TimeTrackingSubjectIdentifierIssue(IssueIdentifier issue)
        {
            Issue = issue;
        }
        
        public override string ToString()
            => $"issue:{Issue}";
    }
    
}

