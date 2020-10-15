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
    public sealed class ListCommandsPayload
         : ApplicationPayload, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "ListCommandsPayload";
        
        public ListCommandsPayload() { }
        
        public ListCommandsPayload(string accessToken, string? verificationToken = null, string? userId = null)
        {
            AccessToken = accessToken;
            VerificationToken = verificationToken;
            UserId = userId;
        }
        
        private PropertyValue<string> _accessToken = new PropertyValue<string>(nameof(ListCommandsPayload), nameof(AccessToken));
        
        [Required]
        [JsonPropertyName("accessToken")]
        public string AccessToken
        {
            get { return _accessToken.GetValue(); }
            set { _accessToken.SetValue(value); }
        }
    
        private PropertyValue<string?> _verificationToken = new PropertyValue<string?>(nameof(ListCommandsPayload), nameof(VerificationToken));
        
        [JsonPropertyName("verificationToken")]
        public string? VerificationToken
        {
            get { return _verificationToken.GetValue(); }
            set { _verificationToken.SetValue(value); }
        }
    
        private PropertyValue<string?> _userId = new PropertyValue<string?>(nameof(ListCommandsPayload), nameof(UserId));
        
        [JsonPropertyName("userId")]
        public string? UserId
        {
            get { return _userId.GetValue(); }
            set { _userId.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _accessToken.SetAccessPath(path, validateHasBeenSet);
            _verificationToken.SetAccessPath(path, validateHasBeenSet);
            _userId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
