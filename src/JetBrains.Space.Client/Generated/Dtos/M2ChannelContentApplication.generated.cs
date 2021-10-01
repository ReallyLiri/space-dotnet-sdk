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

public sealed class M2ChannelContentApplication
     : M2ChannelContactInfo, M2ChannelContentInfo, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "M2ChannelContentApplication";
    
    public M2ChannelContentApplication() { }
    
    public M2ChannelContentApplication(ESApp app, ChannelSpecificDefaults notificationDefaults)
    {
        App = app;
        NotificationDefaults = notificationDefaults;
    }
    
    private PropertyValue<ESApp> _app = new PropertyValue<ESApp>(nameof(M2ChannelContentApplication), nameof(App));
    
    [Required]
    [JsonPropertyName("app")]
    public ESApp App
    {
        get => _app.GetValue();
        set => _app.SetValue(value);
    }

    private PropertyValue<ChannelSpecificDefaults> _notificationDefaults = new PropertyValue<ChannelSpecificDefaults>(nameof(M2ChannelContentApplication), nameof(NotificationDefaults));
    
    [Required]
    [JsonPropertyName("notificationDefaults")]
    public ChannelSpecificDefaults NotificationDefaults
    {
        get => _notificationDefaults.GetValue();
        set => _notificationDefaults.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _app.SetAccessPath(path, validateHasBeenSet);
        _notificationDefaults.SetAccessPath(path, validateHasBeenSet);
    }

}

