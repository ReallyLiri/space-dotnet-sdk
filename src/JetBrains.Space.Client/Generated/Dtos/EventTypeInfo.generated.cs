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
    public sealed class EventTypeInfo
         : IPropagatePropertyAccessPath
    {
        public EventTypeInfo() { }
        
        public EventTypeInfo(string code, string name, string description, List<CRight> rights, int sortOrder, string? featureFlag = null)
        {
            Code = code;
            Name = name;
            Description = description;
            Rights = rights;
            FeatureFlag = featureFlag;
            SortOrder = sortOrder;
        }
        
        private PropertyValue<string> _code = new PropertyValue<string>(nameof(EventTypeInfo), nameof(Code));
        
        [Required]
        [JsonPropertyName("code")]
        public string Code
        {
            get => _code.GetValue();
            set => _code.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(EventTypeInfo), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _description = new PropertyValue<string>(nameof(EventTypeInfo), nameof(Description));
        
        [Required]
        [JsonPropertyName("description")]
        public string Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<List<CRight>> _rights = new PropertyValue<List<CRight>>(nameof(EventTypeInfo), nameof(Rights), new List<CRight>());
        
        [Required]
        [JsonPropertyName("rights")]
        public List<CRight> Rights
        {
            get => _rights.GetValue();
            set => _rights.SetValue(value);
        }
    
        private PropertyValue<string?> _featureFlag = new PropertyValue<string?>(nameof(EventTypeInfo), nameof(FeatureFlag));
        
        [JsonPropertyName("featureFlag")]
        public string? FeatureFlag
        {
            get => _featureFlag.GetValue();
            set => _featureFlag.SetValue(value);
        }
    
        private PropertyValue<int> _sortOrder = new PropertyValue<int>(nameof(EventTypeInfo), nameof(SortOrder));
        
        [Required]
        [JsonPropertyName("sortOrder")]
        public int SortOrder
        {
            get => _sortOrder.GetValue();
            set => _sortOrder.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _code.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _rights.SetAccessPath(path, validateHasBeenSet);
            _featureFlag.SetAccessPath(path, validateHasBeenSet);
            _sortOrder.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
