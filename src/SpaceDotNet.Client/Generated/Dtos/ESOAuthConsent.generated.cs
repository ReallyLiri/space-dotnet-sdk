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
    public sealed class ESOAuthConsent
         : IPropagatePropertyAccessPath
    {
        public ESOAuthConsent() { }
        
        public ESOAuthConsent(ESService clientService, List<ESApprovedScope> approvedScopes, List<ESRefreshToken> refreshTokens)
        {
            ClientService = clientService;
            ApprovedScopes = approvedScopes;
            RefreshTokens = refreshTokens;
        }
        
        private PropertyValue<ESService> _clientService = new PropertyValue<ESService>(nameof(ESOAuthConsent), nameof(ClientService));
        
        [Required]
        [JsonPropertyName("clientService")]
        public ESService ClientService
        {
            get { return _clientService.GetValue(); }
            set { _clientService.SetValue(value); }
        }
    
        private PropertyValue<List<ESApprovedScope>> _approvedScopes = new PropertyValue<List<ESApprovedScope>>(nameof(ESOAuthConsent), nameof(ApprovedScopes));
        
        [Required]
        [JsonPropertyName("approvedScopes")]
        public List<ESApprovedScope> ApprovedScopes
        {
            get { return _approvedScopes.GetValue(); }
            set { _approvedScopes.SetValue(value); }
        }
    
        private PropertyValue<List<ESRefreshToken>> _refreshTokens = new PropertyValue<List<ESRefreshToken>>(nameof(ESOAuthConsent), nameof(RefreshTokens));
        
        [Required]
        [JsonPropertyName("refreshTokens")]
        public List<ESRefreshToken> RefreshTokens
        {
            get { return _refreshTokens.GetValue(); }
            set { _refreshTokens.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _clientService.SetAccessPath(path, validateHasBeenSet);
            _approvedScopes.SetAccessPath(path, validateHasBeenSet);
            _refreshTokens.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
