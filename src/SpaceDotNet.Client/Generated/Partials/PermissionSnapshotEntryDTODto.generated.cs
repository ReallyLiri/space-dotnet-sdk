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

namespace SpaceDotNet.Client.PermissionSnapshotEntryDTODtoExtensions
{
    public static class PermissionSnapshotEntryDTODtoPartialExtensions
    {
        public static Partial<PermissionSnapshotEntryDTODto> WithPrincipalIndex(this Partial<PermissionSnapshotEntryDTODto> it)    => it.AddFieldName("principalIndex");
        
        public static Partial<PermissionSnapshotEntryDTODto> WithRightIndex(this Partial<PermissionSnapshotEntryDTODto> it)    => it.AddFieldName("rightIndex");
        
        public static Partial<PermissionSnapshotEntryDTODto> WithAllTargets(this Partial<PermissionSnapshotEntryDTODto> it)    => it.AddFieldName("allTargets");
        
        public static Partial<PermissionSnapshotEntryDTODto> WithTargetIndices(this Partial<PermissionSnapshotEntryDTODto> it)    => it.AddFieldName("targetIndices");
        
    }
    
}
