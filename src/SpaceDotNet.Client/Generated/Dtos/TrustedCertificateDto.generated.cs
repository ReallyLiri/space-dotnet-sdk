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
    public sealed class TrustedCertificateDto
         : IPropagatePropertyAccessPath
    {
        public TrustedCertificateDto() { }
        
        public TrustedCertificateDto(string id, string alias, string data, CertificateInfoDto info, bool archived)
        {
            Id = id;
            Alias = alias;
            Data = data;
            Info = info;
            Archived = archived;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(TrustedCertificateDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _alias = new PropertyValue<string>(nameof(TrustedCertificateDto), nameof(Alias));
        
        [Required]
        [JsonPropertyName("alias")]
        public string Alias
        {
            get { return _alias.GetValue(); }
            set { _alias.SetValue(value); }
        }
    
        private PropertyValue<string> _data = new PropertyValue<string>(nameof(TrustedCertificateDto), nameof(Data));
        
        [Required]
        [JsonPropertyName("data")]
        public string Data
        {
            get { return _data.GetValue(); }
            set { _data.SetValue(value); }
        }
    
        private PropertyValue<CertificateInfoDto> _info = new PropertyValue<CertificateInfoDto>(nameof(TrustedCertificateDto), nameof(Info));
        
        [Required]
        [JsonPropertyName("info")]
        public CertificateInfoDto Info
        {
            get { return _info.GetValue(); }
            set { _info.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(TrustedCertificateDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _alias.SetAccessPath(path, validateHasBeenSet);
            _data.SetAccessPath(path, validateHasBeenSet);
            _info.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
