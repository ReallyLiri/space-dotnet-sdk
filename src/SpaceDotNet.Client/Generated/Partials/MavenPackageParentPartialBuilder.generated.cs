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

namespace SpaceDotNet.Client.MavenPackageParentPartialBuilder
{
    public static class MavenPackageParentPartialExtensions
    {
        public static Partial<MavenPackageParent> WithGroup(this Partial<MavenPackageParent> it)
            => it.AddFieldName("group");
        
        public static Partial<MavenPackageParent> WithArtifact(this Partial<MavenPackageParent> it)
            => it.AddFieldName("artifact");
        
        public static Partial<MavenPackageParent> WithVersion(this Partial<MavenPackageParent> it)
            => it.AddFieldName("version");
        
    }
    
}
