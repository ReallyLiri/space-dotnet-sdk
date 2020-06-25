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

namespace SpaceDotNet.Client
{
    public sealed class PackagesSettingsDto
         : IPropagatePropertyAccessPath
    {
        public PackagesSettingsDto() { }
        
        public PackagesSettingsDto(long organizationId, long principalId, string principalName, string principalInfo, List<MapEntry<string, PackageRepositorySettingsDto>> repositories, DTOLimitDto? storageLimit = null, DTOLimitDto? downloadLimit = null, DTOLimitDto? uploadLimit = null)
        {
            OrganizationId = organizationId;
            PrincipalId = principalId;
            PrincipalName = principalName;
            PrincipalInfo = principalInfo;
            Repositories = repositories;
            StorageLimit = storageLimit;
            DownloadLimit = downloadLimit;
            UploadLimit = uploadLimit;
        }
        
        private PropertyValue<long> _organizationId = new PropertyValue<long>(nameof(PackagesSettingsDto), nameof(OrganizationId));
        
        [Required]
        [JsonPropertyName("organizationId")]
        public long OrganizationId
        {
            get { return _organizationId.GetValue(); }
            set { _organizationId.SetValue(value); }
        }
    
        private PropertyValue<long> _principalId = new PropertyValue<long>(nameof(PackagesSettingsDto), nameof(PrincipalId));
        
        [Required]
        [JsonPropertyName("principalId")]
        public long PrincipalId
        {
            get { return _principalId.GetValue(); }
            set { _principalId.SetValue(value); }
        }
    
        private PropertyValue<string> _principalName = new PropertyValue<string>(nameof(PackagesSettingsDto), nameof(PrincipalName));
        
        [Required]
        [JsonPropertyName("principalName")]
        public string PrincipalName
        {
            get { return _principalName.GetValue(); }
            set { _principalName.SetValue(value); }
        }
    
        private PropertyValue<string> _principalInfo = new PropertyValue<string>(nameof(PackagesSettingsDto), nameof(PrincipalInfo));
        
        [Required]
        [JsonPropertyName("principalInfo")]
        public string PrincipalInfo
        {
            get { return _principalInfo.GetValue(); }
            set { _principalInfo.SetValue(value); }
        }
    
        private PropertyValue<List<MapEntry<string, PackageRepositorySettingsDto>>> _repositories = new PropertyValue<List<MapEntry<string, PackageRepositorySettingsDto>>>(nameof(PackagesSettingsDto), nameof(Repositories));
        
        [Required]
        [JsonPropertyName("repositories")]
        public List<MapEntry<string, PackageRepositorySettingsDto>> Repositories
        {
            get { return _repositories.GetValue(); }
            set { _repositories.SetValue(value); }
        }
    
        private PropertyValue<DTOLimitDto?> _storageLimit = new PropertyValue<DTOLimitDto?>(nameof(PackagesSettingsDto), nameof(StorageLimit));
        
        [JsonPropertyName("storageLimit")]
        public DTOLimitDto? StorageLimit
        {
            get { return _storageLimit.GetValue(); }
            set { _storageLimit.SetValue(value); }
        }
    
        private PropertyValue<DTOLimitDto?> _downloadLimit = new PropertyValue<DTOLimitDto?>(nameof(PackagesSettingsDto), nameof(DownloadLimit));
        
        [JsonPropertyName("downloadLimit")]
        public DTOLimitDto? DownloadLimit
        {
            get { return _downloadLimit.GetValue(); }
            set { _downloadLimit.SetValue(value); }
        }
    
        private PropertyValue<DTOLimitDto?> _uploadLimit = new PropertyValue<DTOLimitDto?>(nameof(PackagesSettingsDto), nameof(UploadLimit));
        
        [JsonPropertyName("uploadLimit")]
        public DTOLimitDto? UploadLimit
        {
            get { return _uploadLimit.GetValue(); }
            set { _uploadLimit.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _organizationId.SetAccessPath(path, validateHasBeenSet);
            _principalId.SetAccessPath(path, validateHasBeenSet);
            _principalName.SetAccessPath(path, validateHasBeenSet);
            _principalInfo.SetAccessPath(path, validateHasBeenSet);
            _repositories.SetAccessPath(path, validateHasBeenSet);
            _storageLimit.SetAccessPath(path, validateHasBeenSet);
            _downloadLimit.SetAccessPath(path, validateHasBeenSet);
            _uploadLimit.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
