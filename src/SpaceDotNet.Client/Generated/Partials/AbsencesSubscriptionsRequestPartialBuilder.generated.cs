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

namespace SpaceDotNet.Client.AbsencesSubscriptionsRequestPartialBuilder
{
    public static class AbsencesSubscriptionsRequestPartialExtensions
    {
        public static Partial<AbsencesSubscriptionsRequest> WithLocationId(this Partial<AbsencesSubscriptionsRequest> it)
            => it.AddFieldName("locationId");
        
        public static Partial<AbsencesSubscriptionsRequest> WithTeamId(this Partial<AbsencesSubscriptionsRequest> it)
            => it.AddFieldName("teamId");
        
        public static Partial<AbsencesSubscriptionsRequest> WithReasonId(this Partial<AbsencesSubscriptionsRequest> it)
            => it.AddFieldName("reasonId");
        
    }
    
}