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

public sealed class MembersAddedItemDetails
     : M2ItemContentDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "MembersAddedItemDetails";
    
    public MembersAddedItemDetails() { }
    
    public MembersAddedItemDetails(List<CPrincipal> principals, List<string> othersDisplayNames)
    {
        Principals = principals;
        OthersDisplayNames = othersDisplayNames;
    }
    
    private PropertyValue<List<CPrincipal>> _principals = new PropertyValue<List<CPrincipal>>(nameof(MembersAddedItemDetails), nameof(Principals), new List<CPrincipal>());
    
    [Required]
    [JsonPropertyName("principals")]
    public List<CPrincipal> Principals
    {
        get => _principals.GetValue();
        set => _principals.SetValue(value);
    }

    private PropertyValue<List<string>> _othersDisplayNames = new PropertyValue<List<string>>(nameof(MembersAddedItemDetails), nameof(OthersDisplayNames), new List<string>());
    
    [Required]
    [JsonPropertyName("othersDisplayNames")]
    public List<string> OthersDisplayNames
    {
        get => _othersDisplayNames.GetValue();
        set => _othersDisplayNames.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _principals.SetAccessPath(path, validateHasBeenSet);
        _othersDisplayNames.SetAccessPath(path, validateHasBeenSet);
    }

}

