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

public sealed class TDMemberLocation
     : IPropagatePropertyAccessPath
{
    public TDMemberLocation() { }
    
    public TDMemberLocation(string id, TDLocation location, TDMemberProfile member, bool archived, List<TDLocationMapPoint>? locationMapPoints = null, DateTime? since = null, DateTime? till = null)
    {
        Id = id;
        Location = location;
        LocationMapPoints = locationMapPoints;
        Since = since;
        Till = till;
        Member = member;
        IsArchived = archived;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(TDMemberLocation), nameof(Id));
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<TDLocation> _location = new PropertyValue<TDLocation>(nameof(TDMemberLocation), nameof(Location));
    
    [Required]
    [JsonPropertyName("location")]
    public TDLocation Location
    {
        get => _location.GetValue();
        set => _location.SetValue(value);
    }

    private PropertyValue<List<TDLocationMapPoint>?> _locationMapPoints = new PropertyValue<List<TDLocationMapPoint>?>(nameof(TDMemberLocation), nameof(LocationMapPoints));
    
    [JsonPropertyName("locationMapPoints")]
    public List<TDLocationMapPoint>? LocationMapPoints
    {
        get => _locationMapPoints.GetValue();
        set => _locationMapPoints.SetValue(value);
    }

    private PropertyValue<DateTime?> _since = new PropertyValue<DateTime?>(nameof(TDMemberLocation), nameof(Since));
    
    [JsonPropertyName("since")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime? Since
    {
        get => _since.GetValue();
        set => _since.SetValue(value);
    }

    private PropertyValue<DateTime?> _till = new PropertyValue<DateTime?>(nameof(TDMemberLocation), nameof(Till));
    
    [JsonPropertyName("till")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime? Till
    {
        get => _till.GetValue();
        set => _till.SetValue(value);
    }

    private PropertyValue<TDMemberProfile> _member = new PropertyValue<TDMemberProfile>(nameof(TDMemberLocation), nameof(Member));
    
    [Required]
    [JsonPropertyName("member")]
    public TDMemberProfile Member
    {
        get => _member.GetValue();
        set => _member.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(TDMemberLocation), nameof(IsArchived));
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue();
        set => _archived.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _id.SetAccessPath(path, validateHasBeenSet);
        _location.SetAccessPath(path, validateHasBeenSet);
        _locationMapPoints.SetAccessPath(path, validateHasBeenSet);
        _since.SetAccessPath(path, validateHasBeenSet);
        _till.SetAccessPath(path, validateHasBeenSet);
        _member.SetAccessPath(path, validateHasBeenSet);
        _archived.SetAccessPath(path, validateHasBeenSet);
    }

}

