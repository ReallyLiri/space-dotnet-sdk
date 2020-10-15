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

namespace SpaceDotNet.Client
{
    public sealed class OIDCDiscoverySuccess
         : OIDCDiscovery, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "OIDCDiscovery.Success";
        
        public OIDCDiscoverySuccess() { }
        
        public OIDCDiscoverySuccess(string issuer, string authorizationEndpoint, string deviceAuthorizationEndpoint, string tokenEndpoint, string userinfoEndpoint, string revocationEndpoint, string jwksUri)
        {
            Issuer = issuer;
            AuthorizationEndpoint = authorizationEndpoint;
            DeviceAuthorizationEndpoint = deviceAuthorizationEndpoint;
            TokenEndpoint = tokenEndpoint;
            UserinfoEndpoint = userinfoEndpoint;
            RevocationEndpoint = revocationEndpoint;
            JwksUri = jwksUri;
        }
        
        private PropertyValue<string> _issuer = new PropertyValue<string>(nameof(OIDCDiscoverySuccess), nameof(Issuer));
        
        [Required]
        [JsonPropertyName("issuer")]
        public string Issuer
        {
            get { return _issuer.GetValue(); }
            set { _issuer.SetValue(value); }
        }
    
        private PropertyValue<string> _authorizationEndpoint = new PropertyValue<string>(nameof(OIDCDiscoverySuccess), nameof(AuthorizationEndpoint));
        
        [Required]
        [JsonPropertyName("authorizationEndpoint")]
        public string AuthorizationEndpoint
        {
            get { return _authorizationEndpoint.GetValue(); }
            set { _authorizationEndpoint.SetValue(value); }
        }
    
        private PropertyValue<string> _deviceAuthorizationEndpoint = new PropertyValue<string>(nameof(OIDCDiscoverySuccess), nameof(DeviceAuthorizationEndpoint));
        
        [Required]
        [JsonPropertyName("deviceAuthorizationEndpoint")]
        public string DeviceAuthorizationEndpoint
        {
            get { return _deviceAuthorizationEndpoint.GetValue(); }
            set { _deviceAuthorizationEndpoint.SetValue(value); }
        }
    
        private PropertyValue<string> _tokenEndpoint = new PropertyValue<string>(nameof(OIDCDiscoverySuccess), nameof(TokenEndpoint));
        
        [Required]
        [JsonPropertyName("tokenEndpoint")]
        public string TokenEndpoint
        {
            get { return _tokenEndpoint.GetValue(); }
            set { _tokenEndpoint.SetValue(value); }
        }
    
        private PropertyValue<string> _userinfoEndpoint = new PropertyValue<string>(nameof(OIDCDiscoverySuccess), nameof(UserinfoEndpoint));
        
        [Required]
        [JsonPropertyName("userinfoEndpoint")]
        public string UserinfoEndpoint
        {
            get { return _userinfoEndpoint.GetValue(); }
            set { _userinfoEndpoint.SetValue(value); }
        }
    
        private PropertyValue<string> _revocationEndpoint = new PropertyValue<string>(nameof(OIDCDiscoverySuccess), nameof(RevocationEndpoint));
        
        [Required]
        [JsonPropertyName("revocationEndpoint")]
        public string RevocationEndpoint
        {
            get { return _revocationEndpoint.GetValue(); }
            set { _revocationEndpoint.SetValue(value); }
        }
    
        private PropertyValue<string> _jwksUri = new PropertyValue<string>(nameof(OIDCDiscoverySuccess), nameof(JwksUri));
        
        [Required]
        [JsonPropertyName("jwksUri")]
        public string JwksUri
        {
            get { return _jwksUri.GetValue(); }
            set { _jwksUri.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _issuer.SetAccessPath(path, validateHasBeenSet);
            _authorizationEndpoint.SetAccessPath(path, validateHasBeenSet);
            _deviceAuthorizationEndpoint.SetAccessPath(path, validateHasBeenSet);
            _tokenEndpoint.SetAccessPath(path, validateHasBeenSet);
            _userinfoEndpoint.SetAccessPath(path, validateHasBeenSet);
            _revocationEndpoint.SetAccessPath(path, validateHasBeenSet);
            _jwksUri.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
