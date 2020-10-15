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
    public class TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest() { }
        
        public TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest(string language, string? firstName = null, string? lastName = null)
        {
            Language = language;
            FirstName = firstName;
            LastName = lastName;
        }
        
        private PropertyValue<string> _language = new PropertyValue<string>(nameof(TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest), nameof(Language));
        
        [Required]
        [JsonPropertyName("language")]
        public string Language
        {
            get { return _language.GetValue(); }
            set { _language.SetValue(value); }
        }
    
        private PropertyValue<string?> _firstName = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest), nameof(FirstName));
        
        [JsonPropertyName("firstName")]
        public string? FirstName
        {
            get { return _firstName.GetValue(); }
            set { _firstName.SetValue(value); }
        }
    
        private PropertyValue<string?> _lastName = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest), nameof(LastName));
        
        [JsonPropertyName("lastName")]
        public string? LastName
        {
            get { return _lastName.GetValue(); }
            set { _lastName.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _language.SetAccessPath(path, validateHasBeenSet);
            _firstName.SetAccessPath(path, validateHasBeenSet);
            _lastName.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
