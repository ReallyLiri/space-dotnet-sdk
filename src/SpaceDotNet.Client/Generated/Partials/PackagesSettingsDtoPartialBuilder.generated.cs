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

namespace SpaceDotNet.Client.PackagesSettingsDtoPartialBuilder
{
    public static class PackagesSettingsDtoPartialExtensions
    {
        public static Partial<PackagesSettingsDto> WithOrganizationId(this Partial<PackagesSettingsDto> it)
            => it.AddFieldName("organizationId");
        
        public static Partial<PackagesSettingsDto> WithPrincipalId(this Partial<PackagesSettingsDto> it)
            => it.AddFieldName("principalId");
        
        public static Partial<PackagesSettingsDto> WithPrincipalName(this Partial<PackagesSettingsDto> it)
            => it.AddFieldName("principalName");
        
        public static Partial<PackagesSettingsDto> WithPrincipalInfo(this Partial<PackagesSettingsDto> it)
            => it.AddFieldName("principalInfo");
        
        public static Partial<PackagesSettingsDto> WithRepositories(this Partial<PackagesSettingsDto> it)
            => it.AddFieldName("repositories");
        
        public static Partial<PackagesSettingsDto> WithRepositories(this Partial<PackagesSettingsDto> it, Func<Partial<MapEntry<string, PackageRepositorySettingsDto>>, Partial<MapEntry<string, PackageRepositorySettingsDto>>> partialBuilder)
            => it.AddFieldName("repositories", partialBuilder(new Partial<MapEntry<string, PackageRepositorySettingsDto>>(it)));
        
        public static Partial<PackagesSettingsDto> WithStorageLimit(this Partial<PackagesSettingsDto> it)
            => it.AddFieldName("storageLimit");
        
        public static Partial<PackagesSettingsDto> WithStorageLimit(this Partial<PackagesSettingsDto> it, Func<Partial<DTOLimitDto>, Partial<DTOLimitDto>> partialBuilder)
            => it.AddFieldName("storageLimit", partialBuilder(new Partial<DTOLimitDto>(it)));
        
        public static Partial<PackagesSettingsDto> WithDownloadLimit(this Partial<PackagesSettingsDto> it)
            => it.AddFieldName("downloadLimit");
        
        public static Partial<PackagesSettingsDto> WithDownloadLimit(this Partial<PackagesSettingsDto> it, Func<Partial<DTOLimitDto>, Partial<DTOLimitDto>> partialBuilder)
            => it.AddFieldName("downloadLimit", partialBuilder(new Partial<DTOLimitDto>(it)));
        
        public static Partial<PackagesSettingsDto> WithUploadLimit(this Partial<PackagesSettingsDto> it)
            => it.AddFieldName("uploadLimit");
        
        public static Partial<PackagesSettingsDto> WithUploadLimit(this Partial<PackagesSettingsDto> it, Func<Partial<DTOLimitDto>, Partial<DTOLimitDto>> partialBuilder)
            => it.AddFieldName("uploadLimit", partialBuilder(new Partial<DTOLimitDto>(it)));
        
    }
    
}