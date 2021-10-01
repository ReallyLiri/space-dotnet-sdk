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
    public class CustomFieldsV2ForEntityTypeFieldsForCustomFieldEnumValuesBulkUpdatePostRequest
         : IPropagatePropertyAccessPath
    {
        public CustomFieldsV2ForEntityTypeFieldsForCustomFieldEnumValuesBulkUpdatePostRequest() { }
        
        public CustomFieldsV2ForEntityTypeFieldsForCustomFieldEnumValuesBulkUpdatePostRequest(List<CFEnumValueModification> enumValueModifications)
        {
            EnumValueModifications = enumValueModifications;
        }
        
        private PropertyValue<List<CFEnumValueModification>> _enumValueModifications = new PropertyValue<List<CFEnumValueModification>>(nameof(CustomFieldsV2ForEntityTypeFieldsForCustomFieldEnumValuesBulkUpdatePostRequest), nameof(EnumValueModifications), new List<CFEnumValueModification>());
        
        [Required]
        [JsonPropertyName("enumValueModifications")]
        public List<CFEnumValueModification> EnumValueModifications
        {
            get => _enumValueModifications.GetValue();
            set => _enumValueModifications.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _enumValueModifications.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}