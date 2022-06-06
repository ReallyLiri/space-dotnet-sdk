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
public abstract class DashboardIdentifier : IUrlParameter
{
    public static DashboardIdentifier Id(string id)
        => new DashboardIdentifierId(id);
    
    public static DashboardIdentifier Personal(ProfileIdentifier profile)
        => new DashboardIdentifierPersonal(profile);
    
    public static DashboardIdentifier Project(ProjectIdentifier project, ProfileIdentifier profile)
        => new DashboardIdentifierProject(project, profile);
    
    public class DashboardIdentifierId : DashboardIdentifier
    {
        [Required]
        [JsonPropertyName("id")]
#if NET6_0_OR_GREATER
        public string Id { get; init; }
#else
        public string Id { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
#pragma warning disable CS8618
        public DashboardIdentifierId() { }
#pragma warning restore CS8618
#endif
        
        public DashboardIdentifierId(string id)
        {
            Id = id;
        }
        
        public override string ToString()
            => $"id:{Id}";
    }
    
    public class DashboardIdentifierPersonal : DashboardIdentifier
    {
        [Required]
        [JsonPropertyName("profile")]
#if NET6_0_OR_GREATER
        public ProfileIdentifier Profile { get; init; }
#else
        public ProfileIdentifier Profile { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
#pragma warning disable CS8618
        public DashboardIdentifierPersonal() { }
#pragma warning restore CS8618
#endif
        
        public DashboardIdentifierPersonal(ProfileIdentifier profile)
        {
            Profile = profile;
        }
        
        public override string ToString()
            => $"profile:{Profile}";
    }
    
    public class DashboardIdentifierProject : DashboardIdentifier
    {
        [Required]
        [JsonPropertyName("project")]
#if NET6_0_OR_GREATER
        public ProjectIdentifier Project { get; init; }
#else
        public ProjectIdentifier Project { get; set; }
#endif
        
        [Required]
        [JsonPropertyName("profile")]
#if NET6_0_OR_GREATER
        public ProfileIdentifier Profile { get; init; }
#else
        public ProfileIdentifier Profile { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
#pragma warning disable CS8618
        public DashboardIdentifierProject() { }
#pragma warning restore CS8618
#endif
        
        public DashboardIdentifierProject(ProjectIdentifier project, ProfileIdentifier profile)
        {
            Project = project;
            Profile = profile;
        }
        
        public override string ToString()
            => $"{{project:{Project},profile:{Profile}}}";
    }
    
}
