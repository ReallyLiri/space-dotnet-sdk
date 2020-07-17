// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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

namespace SpaceDotNet.Client.NuGetDependencyGroupDtoPartialBuilder
{
    public static class NuGetDependencyGroupDtoPartialExtensions
    {
        public static Partial<NuGetDependencyGroupDto> WithTargetFramework(this Partial<NuGetDependencyGroupDto> it)
            => it.AddFieldName("targetFramework");
        
        public static Partial<NuGetDependencyGroupDto> WithDependencies(this Partial<NuGetDependencyGroupDto> it)
            => it.AddFieldName("dependencies");
        
        public static Partial<NuGetDependencyGroupDto> WithDependencies(this Partial<NuGetDependencyGroupDto> it, Func<Partial<NuGetDependencyDto>, Partial<NuGetDependencyDto>> partialBuilder)
            => it.AddFieldName("dependencies", partialBuilder(new Partial<NuGetDependencyDto>(it)));
        
    }
    
}
