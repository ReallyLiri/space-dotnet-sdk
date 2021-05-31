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
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public class ApplicationsForApplicationIdPermanentTokensForTokenIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public ApplicationsForApplicationIdPermanentTokensForTokenIdPatchRequest() { }
        
        public ApplicationsForApplicationIdPermanentTokensForTokenIdPatchRequest(string? name = null, string? scope = null, DateTime? expires = null)
        {
            Name = name;
            Scope = scope;
            Expires = expires;
        }
        
        private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(ApplicationsForApplicationIdPermanentTokensForTokenIdPatchRequest), nameof(Name));
        
        [JsonPropertyName("name")]
        public string? Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string?> _scope = new PropertyValue<string?>(nameof(ApplicationsForApplicationIdPermanentTokensForTokenIdPatchRequest), nameof(Scope));
        
        [JsonPropertyName("scope")]
        public string? Scope
        {
            get => _scope.GetValue();
            set => _scope.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _expires = new PropertyValue<DateTime?>(nameof(ApplicationsForApplicationIdPermanentTokensForTokenIdPatchRequest), nameof(Expires));
        
        [JsonPropertyName("expires")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? Expires
        {
            get => _expires.GetValue();
            set => _expires.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _scope.SetAccessPath(path, validateHasBeenSet);
            _expires.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
