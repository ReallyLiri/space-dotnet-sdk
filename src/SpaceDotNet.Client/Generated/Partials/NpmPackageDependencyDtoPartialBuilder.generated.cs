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

namespace SpaceDotNet.Client.NpmPackageDependencyDtoPartialBuilder
{
    public static class NpmPackageDependencyDtoPartialExtensions
    {
        public static Partial<NpmPackageDependencyDto> WithName(this Partial<NpmPackageDependencyDto> it)
            => it.AddFieldName("name");
        
        public static Partial<NpmPackageDependencyDto> WithVersion(this Partial<NpmPackageDependencyDto> it)
            => it.AddFieldName("version");
        
        public static Partial<NpmPackageDependencyDto> WithType(this Partial<NpmPackageDependencyDto> it)
            => it.AddFieldName("type");
        
    }
    
}
