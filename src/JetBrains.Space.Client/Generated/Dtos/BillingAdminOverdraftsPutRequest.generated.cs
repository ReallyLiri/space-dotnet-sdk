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

public class BillingAdminOverdraftsPutRequest
     : IPropagatePropertyAccessPath
{
    public BillingAdminOverdraftsPutRequest() { }
    
    public BillingAdminOverdraftsPutRequest(int storage, int bandwidth, int ciCredits)
    {
        Storage = storage;
        Bandwidth = bandwidth;
        CiCredits = ciCredits;
    }
    
    private PropertyValue<int> _storage = new PropertyValue<int>(nameof(BillingAdminOverdraftsPutRequest), nameof(Storage));
    
    [Required]
    [JsonPropertyName("storage")]
    public int Storage
    {
        get => _storage.GetValue();
        set => _storage.SetValue(value);
    }

    private PropertyValue<int> _bandwidth = new PropertyValue<int>(nameof(BillingAdminOverdraftsPutRequest), nameof(Bandwidth));
    
    [Required]
    [JsonPropertyName("bandwidth")]
    public int Bandwidth
    {
        get => _bandwidth.GetValue();
        set => _bandwidth.SetValue(value);
    }

    private PropertyValue<int> _ciCredits = new PropertyValue<int>(nameof(BillingAdminOverdraftsPutRequest), nameof(CiCredits));
    
    [Required]
    [JsonPropertyName("ciCredits")]
    public int CiCredits
    {
        get => _ciCredits.GetValue();
        set => _ciCredits.SetValue(value);
    }

    public virtual void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _storage.SetAccessPath(path, validateHasBeenSet);
        _bandwidth.SetAccessPath(path, validateHasBeenSet);
        _ciCredits.SetAccessPath(path, validateHasBeenSet);
    }

}

