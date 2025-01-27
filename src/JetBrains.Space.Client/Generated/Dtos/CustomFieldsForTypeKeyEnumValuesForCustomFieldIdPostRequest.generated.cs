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

namespace JetBrains.Space.Client;

public class CustomFieldsForTypeKeyEnumValuesForCustomFieldIdPostRequest
     : IPropagatePropertyAccessPath
{
    public CustomFieldsForTypeKeyEnumValuesForCustomFieldIdPostRequest() { }
    
    public CustomFieldsForTypeKeyEnumValuesForCustomFieldIdPostRequest(List<EnumValueData> valuesToAdd, ExtendedTypeScope scope)
    {
        ValuesToAdd = valuesToAdd;
        Scope = scope;
    }
    
    private PropertyValue<List<EnumValueData>> _valuesToAdd = new PropertyValue<List<EnumValueData>>(nameof(CustomFieldsForTypeKeyEnumValuesForCustomFieldIdPostRequest), nameof(ValuesToAdd), "valuesToAdd", new List<EnumValueData>());
    
    [Required]
    [JsonPropertyName("valuesToAdd")]
    public List<EnumValueData> ValuesToAdd
    {
        get => _valuesToAdd.GetValue(InlineErrors);
        set => _valuesToAdd.SetValue(value);
    }

    private PropertyValue<ExtendedTypeScope> _scope = new PropertyValue<ExtendedTypeScope>(nameof(CustomFieldsForTypeKeyEnumValuesForCustomFieldIdPostRequest), nameof(Scope), "scope");
    
    [Required]
    [JsonPropertyName("scope")]
    public ExtendedTypeScope Scope
    {
        get => _scope.GetValue(InlineErrors);
        set => _scope.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _valuesToAdd.SetAccessPath(parentChainPath, validateHasBeenSet);
        _scope.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

