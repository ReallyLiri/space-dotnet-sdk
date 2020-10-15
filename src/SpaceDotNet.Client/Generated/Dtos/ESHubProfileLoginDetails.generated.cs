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
    public sealed class ESHubProfileLoginDetails
         : ESProfileLoginDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "ES_HubProfileLoginDetails";
        
        public ESHubProfileLoginDetails() { }
        
        public ESHubProfileLoginDetails(bool emailVerified, string? login = null, string? hubAuthModuleLogin = null, string? firstName = null, string? lastName = null, string? email = null, string? avatarUrl = null)
        {
            Login = login;
            HubAuthModuleLogin = hubAuthModuleLogin;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            IsEmailVerified = emailVerified;
            AvatarUrl = avatarUrl;
        }
        
        private PropertyValue<string?> _login = new PropertyValue<string?>(nameof(ESHubProfileLoginDetails), nameof(Login));
        
        [JsonPropertyName("login")]
        public string? Login
        {
            get { return _login.GetValue(); }
            set { _login.SetValue(value); }
        }
    
        private PropertyValue<string?> _hubAuthModuleLogin = new PropertyValue<string?>(nameof(ESHubProfileLoginDetails), nameof(HubAuthModuleLogin));
        
        [JsonPropertyName("hubAuthModuleLogin")]
        public string? HubAuthModuleLogin
        {
            get { return _hubAuthModuleLogin.GetValue(); }
            set { _hubAuthModuleLogin.SetValue(value); }
        }
    
        private PropertyValue<string?> _firstName = new PropertyValue<string?>(nameof(ESHubProfileLoginDetails), nameof(FirstName));
        
        [JsonPropertyName("firstName")]
        public string? FirstName
        {
            get { return _firstName.GetValue(); }
            set { _firstName.SetValue(value); }
        }
    
        private PropertyValue<string?> _lastName = new PropertyValue<string?>(nameof(ESHubProfileLoginDetails), nameof(LastName));
        
        [JsonPropertyName("lastName")]
        public string? LastName
        {
            get { return _lastName.GetValue(); }
            set { _lastName.SetValue(value); }
        }
    
        private PropertyValue<string?> _email = new PropertyValue<string?>(nameof(ESHubProfileLoginDetails), nameof(Email));
        
        [JsonPropertyName("email")]
        public string? Email
        {
            get { return _email.GetValue(); }
            set { _email.SetValue(value); }
        }
    
        private PropertyValue<bool> _emailVerified = new PropertyValue<bool>(nameof(ESHubProfileLoginDetails), nameof(IsEmailVerified));
        
        [Required]
        [JsonPropertyName("emailVerified")]
        public bool IsEmailVerified
        {
            get { return _emailVerified.GetValue(); }
            set { _emailVerified.SetValue(value); }
        }
    
        private PropertyValue<string?> _avatarUrl = new PropertyValue<string?>(nameof(ESHubProfileLoginDetails), nameof(AvatarUrl));
        
        [JsonPropertyName("avatarUrl")]
        public string? AvatarUrl
        {
            get { return _avatarUrl.GetValue(); }
            set { _avatarUrl.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _login.SetAccessPath(path, validateHasBeenSet);
            _hubAuthModuleLogin.SetAccessPath(path, validateHasBeenSet);
            _firstName.SetAccessPath(path, validateHasBeenSet);
            _lastName.SetAccessPath(path, validateHasBeenSet);
            _email.SetAccessPath(path, validateHasBeenSet);
            _emailVerified.SetAccessPath(path, validateHasBeenSet);
            _avatarUrl.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
