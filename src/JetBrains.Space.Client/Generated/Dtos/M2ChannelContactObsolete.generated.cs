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

public sealed class M2ChannelContactObsolete
     : M2ChannelContactInfo, M2ChannelContentInfo, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "M2ChannelContactObsolete";
    
    public M2ChannelContactObsolete() { }
    
    public M2ChannelContactObsolete(M2ObsoleteCause? cause = null)
    {
        Cause = cause;
    }
    
    private PropertyValue<M2ObsoleteCause?> _cause = new PropertyValue<M2ObsoleteCause?>(nameof(M2ChannelContactObsolete), nameof(Cause));
    
    [JsonPropertyName("cause")]
    public M2ObsoleteCause? Cause
    {
        get => _cause.GetValue();
        set => _cause.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _cause.SetAccessPath(path, validateHasBeenSet);
    }

}

