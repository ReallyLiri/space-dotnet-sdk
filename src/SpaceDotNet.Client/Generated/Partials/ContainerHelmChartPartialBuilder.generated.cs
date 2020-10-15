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

namespace SpaceDotNet.Client.ContainerHelmChartPartialBuilder
{
    public static class ContainerHelmChartPartialExtensions
    {
        public static Partial<ContainerHelmChart> WithName(this Partial<ContainerHelmChart> it)
            => it.AddFieldName("name");
        
        public static Partial<ContainerHelmChart> WithDescription(this Partial<ContainerHelmChart> it)
            => it.AddFieldName("description");
        
        public static Partial<ContainerHelmChart> WithTags(this Partial<ContainerHelmChart> it)
            => it.AddFieldName("tags");
        
        public static Partial<ContainerHelmChart> WithProjectUrl(this Partial<ContainerHelmChart> it)
            => it.AddFieldName("projectUrl");
        
        public static Partial<ContainerHelmChart> WithSourceUrl(this Partial<ContainerHelmChart> it)
            => it.AddFieldName("sourceUrl");
        
        public static Partial<ContainerHelmChart> WithVersion(this Partial<ContainerHelmChart> it)
            => it.AddFieldName("version");
        
        public static Partial<ContainerHelmChart> WithApiVersion(this Partial<ContainerHelmChart> it)
            => it.AddFieldName("apiVersion");
        
        public static Partial<ContainerHelmChart> WithAppVersion(this Partial<ContainerHelmChart> it)
            => it.AddFieldName("appVersion");
        
        public static Partial<ContainerHelmChart> WithDependencies(this Partial<ContainerHelmChart> it)
            => it.AddFieldName("dependencies");
        
        public static Partial<ContainerHelmChart> WithDependencies(this Partial<ContainerHelmChart> it, Func<Partial<ContainerHelmChartDependency>, Partial<ContainerHelmChartDependency>> partialBuilder)
            => it.AddFieldName("dependencies", partialBuilder(new Partial<ContainerHelmChartDependency>(it)));
        
        public static Partial<ContainerHelmChart> WithType(this Partial<ContainerHelmChart> it)
            => it.AddFieldName("type");
        
    }
    
}
