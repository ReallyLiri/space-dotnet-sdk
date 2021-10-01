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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
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
    public class CustomFieldsV2ForEntityTypeFieldsForCustomFieldEnumValuesPatchRequest
         : IPropagatePropertyAccessPath
    {
        public CustomFieldsV2ForEntityTypeFieldsForCustomFieldEnumValuesPatchRequest() { }
        
        public CustomFieldsV2ForEntityTypeFieldsForCustomFieldEnumValuesPatchRequest(CFEnumValueIdentifier enumValueToUpdate, string newName)
        {
            EnumValueToUpdate = enumValueToUpdate;
            NewName = newName;
        }
        
        private PropertyValue<CFEnumValueIdentifier> _enumValueToUpdate = new PropertyValue<CFEnumValueIdentifier>(nameof(CustomFieldsV2ForEntityTypeFieldsForCustomFieldEnumValuesPatchRequest), nameof(EnumValueToUpdate));
        
        [Required]
        [JsonPropertyName("enumValueToUpdate")]
        public CFEnumValueIdentifier EnumValueToUpdate
        {
            get => _enumValueToUpdate.GetValue();
            set => _enumValueToUpdate.SetValue(value);
        }
    
        private PropertyValue<string> _newName = new PropertyValue<string>(nameof(CustomFieldsV2ForEntityTypeFieldsForCustomFieldEnumValuesPatchRequest), nameof(NewName));
        
        [Required]
        [JsonPropertyName("newName")]
        public string NewName
        {
            get => _newName.GetValue();
            set => _newName.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _enumValueToUpdate.SetAccessPath(path, validateHasBeenSet);
            _newName.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}