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

namespace SpaceDotNet.Client.TDLocationEquipmentTypePartialBuilder
{
    public static class TDLocationEquipmentTypePartialExtensions
    {
        public static Partial<TDLocationEquipmentType> WithName(this Partial<TDLocationEquipmentType> it)
            => it.AddFieldName("name");
        
        public static Partial<TDLocationEquipmentType> WithIsArchived(this Partial<TDLocationEquipmentType> it)
            => it.AddFieldName("archived");
        
    }
    
}
