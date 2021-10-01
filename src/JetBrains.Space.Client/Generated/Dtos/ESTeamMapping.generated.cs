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

public sealed class ESTeamMapping
     : IPropagatePropertyAccessPath
{
    public ESTeamMapping() { }
    
    public ESTeamMapping(string teamId, string externalGroupName)
    {
        TeamId = teamId;
        ExternalGroupName = externalGroupName;
    }
    
    private PropertyValue<string> _teamId = new PropertyValue<string>(nameof(ESTeamMapping), nameof(TeamId));
    
    [Required]
    [JsonPropertyName("teamId")]
    public string TeamId
    {
        get => _teamId.GetValue();
        set => _teamId.SetValue(value);
    }

    private PropertyValue<string> _externalGroupName = new PropertyValue<string>(nameof(ESTeamMapping), nameof(ExternalGroupName));
    
    [Required]
    [JsonPropertyName("externalGroupName")]
    public string ExternalGroupName
    {
        get => _externalGroupName.GetValue();
        set => _externalGroupName.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _teamId.SetAccessPath(path, validateHasBeenSet);
        _externalGroupName.SetAccessPath(path, validateHasBeenSet);
    }

}

