// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
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

namespace SpaceDotNet.Client.TeamDirectoryLocationsPostRequestPartialBuilder
{
    public static class TeamDirectoryLocationsPostRequestPartialExtensions
    {
        public static Partial<TeamDirectoryLocationsPostRequest> WithName(this Partial<TeamDirectoryLocationsPostRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<TeamDirectoryLocationsPostRequest> WithTimezone(this Partial<TeamDirectoryLocationsPostRequest> it)
            => it.AddFieldName("timezone");
        
        public static Partial<TeamDirectoryLocationsPostRequest> WithWorkdays(this Partial<TeamDirectoryLocationsPostRequest> it)
            => it.AddFieldName("workdays");
        
        public static Partial<TeamDirectoryLocationsPostRequest> WithPhones(this Partial<TeamDirectoryLocationsPostRequest> it)
            => it.AddFieldName("phones");
        
        public static Partial<TeamDirectoryLocationsPostRequest> WithEmails(this Partial<TeamDirectoryLocationsPostRequest> it)
            => it.AddFieldName("emails");
        
        public static Partial<TeamDirectoryLocationsPostRequest> WithEquipment(this Partial<TeamDirectoryLocationsPostRequest> it)
            => it.AddFieldName("equipment");
        
        public static Partial<TeamDirectoryLocationsPostRequest> WithDescription(this Partial<TeamDirectoryLocationsPostRequest> it)
            => it.AddFieldName("description");
        
        public static Partial<TeamDirectoryLocationsPostRequest> WithAddress(this Partial<TeamDirectoryLocationsPostRequest> it)
            => it.AddFieldName("address");
        
        public static Partial<TeamDirectoryLocationsPostRequest> WithType(this Partial<TeamDirectoryLocationsPostRequest> it)
            => it.AddFieldName("type");
        
        public static Partial<TeamDirectoryLocationsPostRequest> WithParentId(this Partial<TeamDirectoryLocationsPostRequest> it)
            => it.AddFieldName("parentId");
        
        public static Partial<TeamDirectoryLocationsPostRequest> WithCapacity(this Partial<TeamDirectoryLocationsPostRequest> it)
            => it.AddFieldName("capacity");
        
    }
    
}
