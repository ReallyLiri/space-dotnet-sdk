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

namespace SpaceDotNet.Client.M2ChannelIssueInfoPartialBuilder
{
    public static class M2ChannelIssueInfoPartialExtensions
    {
        public static Partial<M2ChannelIssueInfo> WithProjectKey(this Partial<M2ChannelIssueInfo> it)
            => it.AddFieldName("projectKey");
        
        public static Partial<M2ChannelIssueInfo> WithProjectKey(this Partial<M2ChannelIssueInfo> it, Func<Partial<ProjectKey>, Partial<ProjectKey>> partialBuilder)
            => it.AddFieldName("projectKey", partialBuilder(new Partial<ProjectKey>(it)));
        
        public static Partial<M2ChannelIssueInfo> WithIssue(this Partial<M2ChannelIssueInfo> it)
            => it.AddFieldName("issue");
        
        public static Partial<M2ChannelIssueInfo> WithIssue(this Partial<M2ChannelIssueInfo> it, Func<Partial<Issue>, Partial<Issue>> partialBuilder)
            => it.AddFieldName("issue", partialBuilder(new Partial<Issue>(it)));
        
        public static Partial<M2ChannelIssueInfo> WithNotificationDefaults(this Partial<M2ChannelIssueInfo> it)
            => it.AddFieldName("notificationDefaults");
        
        public static Partial<M2ChannelIssueInfo> WithNotificationDefaults(this Partial<M2ChannelIssueInfo> it, Func<Partial<ChannelSpecificDefaults>, Partial<ChannelSpecificDefaults>> partialBuilder)
            => it.AddFieldName("notificationDefaults", partialBuilder(new Partial<ChannelSpecificDefaults>(it)));
        
    }
    
}
