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

namespace SpaceDotNet.Client.CPrincipalPartialBuilder
{
    public static class CPrincipalPartialExtensions
    {
        public static Partial<CPrincipal> WithName(this Partial<CPrincipal> it)
            => it.AddFieldName("name");
        
        public static Partial<CPrincipal> WithDetails(this Partial<CPrincipal> it)
            => it.AddFieldName("details");
        
        public static Partial<CPrincipal> WithDetails(this Partial<CPrincipal> it, Func<Partial<CPrincipalDetails>, Partial<CPrincipalDetails>> partialBuilder)
            => it.AddFieldName("details", partialBuilder(new Partial<CPrincipalDetails>(it)));
        
    }
    
}
