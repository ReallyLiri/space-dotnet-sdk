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
    public sealed class GitCommitterProfile
         : IPropagatePropertyAccessPath
    {
        public GitCommitterProfile() { }
        
        public GitCommitterProfile(string author, string email, TDMemberProfile? profile = null)
        {
            Author = author;
            Email = email;
            Profile = profile;
        }
        
        private PropertyValue<string> _author = new PropertyValue<string>(nameof(GitCommitterProfile), nameof(Author));
        
        [Required]
        [JsonPropertyName("author")]
        public string Author
        {
            get { return _author.GetValue(); }
            set { _author.SetValue(value); }
        }
    
        private PropertyValue<string> _email = new PropertyValue<string>(nameof(GitCommitterProfile), nameof(Email));
        
        [Required]
        [JsonPropertyName("email")]
        public string Email
        {
            get { return _email.GetValue(); }
            set { _email.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfile?> _profile = new PropertyValue<TDMemberProfile?>(nameof(GitCommitterProfile), nameof(Profile));
        
        [JsonPropertyName("profile")]
        public TDMemberProfile? Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _author.SetAccessPath(path, validateHasBeenSet);
            _email.SetAccessPath(path, validateHasBeenSet);
            _profile.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
