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
    public sealed class ESServiceDto
         : IPropagatePropertyAccessPath
    {
        public ESServiceDto() { }
        
        public ESServiceDto(string id, OAuthServiceType type, string clientId, string name, string redirectURIs, bool archived, TDMemberProfileDto? owner = null, AccessRecordDto? lastClientCredentialsAccess = null, string? endpointURI = null, bool? hasSigningKey = null, bool? hasVerificationToken = null)
        {
            Id = id;
            Owner = owner;
            Type = type;
            ClientId = clientId;
            Name = name;
            RedirectURIs = redirectURIs;
            Archived = archived;
            LastClientCredentialsAccess = lastClientCredentialsAccess;
            EndpointURI = endpointURI;
            HasSigningKey = hasSigningKey;
            HasVerificationToken = hasVerificationToken;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ESServiceDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto?> _owner = new PropertyValue<TDMemberProfileDto?>(nameof(ESServiceDto), nameof(Owner));
        
        [JsonPropertyName("owner")]
        public TDMemberProfileDto? Owner
        {
            get { return _owner.GetValue(); }
            set { _owner.SetValue(value); }
        }
    
        private PropertyValue<OAuthServiceType> _type = new PropertyValue<OAuthServiceType>(nameof(ESServiceDto), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public OAuthServiceType Type
        {
            get { return _type.GetValue(); }
            set { _type.SetValue(value); }
        }
    
        private PropertyValue<string> _clientId = new PropertyValue<string>(nameof(ESServiceDto), nameof(ClientId));
        
        [Required]
        [JsonPropertyName("clientId")]
        public string ClientId
        {
            get { return _clientId.GetValue(); }
            set { _clientId.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(ESServiceDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string> _redirectURIs = new PropertyValue<string>(nameof(ESServiceDto), nameof(RedirectURIs));
        
        [Required]
        [JsonPropertyName("redirectURIs")]
        public string RedirectURIs
        {
            get { return _redirectURIs.GetValue(); }
            set { _redirectURIs.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ESServiceDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<AccessRecordDto?> _lastClientCredentialsAccess = new PropertyValue<AccessRecordDto?>(nameof(ESServiceDto), nameof(LastClientCredentialsAccess));
        
        [JsonPropertyName("lastClientCredentialsAccess")]
        public AccessRecordDto? LastClientCredentialsAccess
        {
            get { return _lastClientCredentialsAccess.GetValue(); }
            set { _lastClientCredentialsAccess.SetValue(value); }
        }
    
        private PropertyValue<string?> _endpointURI = new PropertyValue<string?>(nameof(ESServiceDto), nameof(EndpointURI));
        
        [JsonPropertyName("endpointURI")]
        public string? EndpointURI
        {
            get { return _endpointURI.GetValue(); }
            set { _endpointURI.SetValue(value); }
        }
    
        private PropertyValue<bool?> _hasSigningKey = new PropertyValue<bool?>(nameof(ESServiceDto), nameof(HasSigningKey));
        
        [JsonPropertyName("hasSigningKey")]
        public bool? HasSigningKey
        {
            get { return _hasSigningKey.GetValue(); }
            set { _hasSigningKey.SetValue(value); }
        }
    
        private PropertyValue<bool?> _hasVerificationToken = new PropertyValue<bool?>(nameof(ESServiceDto), nameof(HasVerificationToken));
        
        [JsonPropertyName("hasVerificationToken")]
        public bool? HasVerificationToken
        {
            get { return _hasVerificationToken.GetValue(); }
            set { _hasVerificationToken.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _owner.SetAccessPath(path, validateHasBeenSet);
            _type.SetAccessPath(path, validateHasBeenSet);
            _clientId.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _redirectURIs.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _lastClientCredentialsAccess.SetAccessPath(path, validateHasBeenSet);
            _endpointURI.SetAccessPath(path, validateHasBeenSet);
            _hasSigningKey.SetAccessPath(path, validateHasBeenSet);
            _hasVerificationToken.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
