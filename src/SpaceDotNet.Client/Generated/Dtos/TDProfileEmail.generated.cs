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
    public sealed class TDProfileEmail
         : IPropagatePropertyAccessPath
    {
        public TDProfileEmail() { }
        
        public TDProfileEmail(string id, string email)
        {
            Id = id;
            Email = email;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(TDProfileEmail), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _email = new PropertyValue<string>(nameof(TDProfileEmail), nameof(Email));
        
        [Required]
        [JsonPropertyName("email")]
        public string Email
        {
            get { return _email.GetValue(); }
            set { _email.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _email.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
