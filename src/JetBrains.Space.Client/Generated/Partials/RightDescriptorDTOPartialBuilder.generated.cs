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

namespace JetBrains.Space.Client.RightDescriptorDTOPartialBuilder;

public static class RightDescriptorDTOPartialExtensions
{
    public static Partial<RightDescriptorDTO> WithRightCode(this Partial<RightDescriptorDTO> it)
        => it.AddFieldName("rightCode");
    
    public static Partial<RightDescriptorDTO> WithName(this Partial<RightDescriptorDTO> it)
        => it.AddFieldName("name");
    
    public static Partial<RightDescriptorDTO> WithGroup(this Partial<RightDescriptorDTO> it)
        => it.AddFieldName("group");
    
    public static Partial<RightDescriptorDTO> WithDescription(this Partial<RightDescriptorDTO> it)
        => it.AddFieldName("description");
    
    public static Partial<RightDescriptorDTO> WithTargetName(this Partial<RightDescriptorDTO> it)
        => it.AddFieldName("targetName");
    
    public static Partial<RightDescriptorDTO> WithDependencies(this Partial<RightDescriptorDTO> it)
        => it.AddFieldName("dependencies");
    
}

