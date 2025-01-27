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

public class TeamDirectoryLocationMapMemberPointsPostRequest
     : IPropagatePropertyAccessPath
{
    public TeamDirectoryLocationMapMemberPointsPostRequest() { }
    
    public TeamDirectoryLocationMapMemberPointsPostRequest(string memberLocationId, int x, int y, string mapId)
    {
        MemberLocationId = memberLocationId;
        X = x;
        Y = y;
        MapId = mapId;
    }
    
    private PropertyValue<string> _memberLocationId = new PropertyValue<string>(nameof(TeamDirectoryLocationMapMemberPointsPostRequest), nameof(MemberLocationId), "memberLocationId");
    
    [Required]
    [JsonPropertyName("memberLocationId")]
    public string MemberLocationId
    {
        get => _memberLocationId.GetValue(InlineErrors);
        set => _memberLocationId.SetValue(value);
    }

    private PropertyValue<int> _x = new PropertyValue<int>(nameof(TeamDirectoryLocationMapMemberPointsPostRequest), nameof(X), "x");
    
    [Required]
    [JsonPropertyName("x")]
    public int X
    {
        get => _x.GetValue(InlineErrors);
        set => _x.SetValue(value);
    }

    private PropertyValue<int> _y = new PropertyValue<int>(nameof(TeamDirectoryLocationMapMemberPointsPostRequest), nameof(Y), "y");
    
    [Required]
    [JsonPropertyName("y")]
    public int Y
    {
        get => _y.GetValue(InlineErrors);
        set => _y.SetValue(value);
    }

    private PropertyValue<string> _mapId = new PropertyValue<string>(nameof(TeamDirectoryLocationMapMemberPointsPostRequest), nameof(MapId), "mapId");
    
    [Required]
    [JsonPropertyName("mapId")]
    public string MapId
    {
        get => _mapId.GetValue(InlineErrors);
        set => _mapId.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _memberLocationId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _x.SetAccessPath(parentChainPath, validateHasBeenSet);
        _y.SetAccessPath(parentChainPath, validateHasBeenSet);
        _mapId.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

