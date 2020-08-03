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
    public sealed class SecretParameterRecordDto
         : IPropagatePropertyAccessPath
    {
        public SecretParameterRecordDto() { }
        
        public SecretParameterRecordDto(string id, bool archived, string bundleId, string key)
        {
            Id = id;
            Archived = archived;
            BundleId = bundleId;
            Key = key;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(SecretParameterRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(SecretParameterRecordDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<string> _bundleId = new PropertyValue<string>(nameof(SecretParameterRecordDto), nameof(BundleId));
        
        [Required]
        [JsonPropertyName("bundleId")]
        public string BundleId
        {
            get { return _bundleId.GetValue(); }
            set { _bundleId.SetValue(value); }
        }
    
        private PropertyValue<string> _key = new PropertyValue<string>(nameof(SecretParameterRecordDto), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public string Key
        {
            get { return _key.GetValue(); }
            set { _key.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _bundleId.SetAccessPath(path, validateHasBeenSet);
            _key.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}