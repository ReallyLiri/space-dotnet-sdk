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

namespace SpaceDotNet.Client.MdMarkupPartialBuilder
{
    public static class MdMarkupPartialExtensions
    {
        public static Partial<MdMarkup> WithUnfurl(this Partial<MdMarkup> it)
            => it.AddFieldName("unfurl");
        
        public static Partial<MdMarkup> WithUnfurl(this Partial<MdMarkup> it, Func<Partial<Unfurl>, Partial<Unfurl>> partialBuilder)
            => it.AddFieldName("unfurl", partialBuilder(new Partial<Unfurl>(it)));
        
    }
    
}
