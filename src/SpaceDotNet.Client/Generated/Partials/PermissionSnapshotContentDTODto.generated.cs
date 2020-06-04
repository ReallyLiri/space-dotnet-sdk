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

namespace SpaceDotNet.Client.PermissionSnapshotContentDTODtoExtensions
{
    public static class PermissionSnapshotContentDTODtoPartialExtensions
    {
        public static Partial<PermissionSnapshotContentDTODto> WithEntries(this Partial<PermissionSnapshotContentDTODto> it)    => it.AddFieldName("entries");
        
        public static Partial<PermissionSnapshotContentDTODto> WithEntries(this Partial<PermissionSnapshotContentDTODto> it, Func<Partial<PermissionSnapshotEntryDTODto>, Partial<PermissionSnapshotEntryDTODto>> partialBuilder)    => it.AddFieldName("entries", partialBuilder(new Partial<PermissionSnapshotEntryDTODto>()));
        
        public static Partial<PermissionSnapshotContentDTODto> WithPrincipals(this Partial<PermissionSnapshotContentDTODto> it)    => it.AddFieldName("principals");
        
        public static Partial<PermissionSnapshotContentDTODto> WithPrincipals(this Partial<PermissionSnapshotContentDTODto> it, Func<Partial<PermissionSnapshotPrincipalDTODto>, Partial<PermissionSnapshotPrincipalDTODto>> partialBuilder)    => it.AddFieldName("principals", partialBuilder(new Partial<PermissionSnapshotPrincipalDTODto>()));
        
        public static Partial<PermissionSnapshotContentDTODto> WithRights(this Partial<PermissionSnapshotContentDTODto> it)    => it.AddFieldName("rights");
        
        public static Partial<PermissionSnapshotContentDTODto> WithRights(this Partial<PermissionSnapshotContentDTODto> it, Func<Partial<PermissionSnapshotRightDTODto>, Partial<PermissionSnapshotRightDTODto>> partialBuilder)    => it.AddFieldName("rights", partialBuilder(new Partial<PermissionSnapshotRightDTODto>()));
        
        public static Partial<PermissionSnapshotContentDTODto> WithTargets(this Partial<PermissionSnapshotContentDTODto> it)    => it.AddFieldName("targets");
        
        public static Partial<PermissionSnapshotContentDTODto> WithTargets(this Partial<PermissionSnapshotContentDTODto> it, Func<Partial<PermissionSnapshotTargetDTODto>, Partial<PermissionSnapshotTargetDTODto>> partialBuilder)    => it.AddFieldName("targets", partialBuilder(new Partial<PermissionSnapshotTargetDTODto>()));
        
    }
    
}
