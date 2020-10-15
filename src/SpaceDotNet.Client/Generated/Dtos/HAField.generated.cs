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
    public sealed class HAField
         : IPropagatePropertyAccessPath
    {
        public HAField() { }
        
        public HAField(string name, HAType type, bool optional, HADefaultValue? defaultValue = null, HADeprecation? deprecation = null)
        {
            Name = name;
            Type = type;
            DefaultValue = defaultValue;
            IsOptional = optional;
            Deprecation = deprecation;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(HAField), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<HAType> _type = new PropertyValue<HAType>(nameof(HAField), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public HAType Type
        {
            get { return _type.GetValue(); }
            set { _type.SetValue(value); }
        }
    
        private PropertyValue<HADefaultValue?> _defaultValue = new PropertyValue<HADefaultValue?>(nameof(HAField), nameof(DefaultValue));
        
        [JsonPropertyName("defaultValue")]
        public HADefaultValue? DefaultValue
        {
            get { return _defaultValue.GetValue(); }
            set { _defaultValue.SetValue(value); }
        }
    
        private PropertyValue<bool> _optional = new PropertyValue<bool>(nameof(HAField), nameof(IsOptional));
        
        [Required]
        [JsonPropertyName("optional")]
        public bool IsOptional
        {
            get { return _optional.GetValue(); }
            set { _optional.SetValue(value); }
        }
    
        private PropertyValue<HADeprecation?> _deprecation = new PropertyValue<HADeprecation?>(nameof(HAField), nameof(Deprecation));
        
        [JsonPropertyName("deprecation")]
        public HADeprecation? Deprecation
        {
            get { return _deprecation.GetValue(); }
            set { _deprecation.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _type.SetAccessPath(path, validateHasBeenSet);
            _defaultValue.SetAccessPath(path, validateHasBeenSet);
            _optional.SetAccessPath(path, validateHasBeenSet);
            _deprecation.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
