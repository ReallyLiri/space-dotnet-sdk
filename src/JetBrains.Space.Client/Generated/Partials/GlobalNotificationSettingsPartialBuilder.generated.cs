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

namespace JetBrains.Space.Client.GlobalNotificationSettingsPartialBuilder;

public static class GlobalNotificationSettingsPartialExtensions
{
    public static Partial<GlobalNotificationSettings> WithIsEmailNotificationsEnabled(this Partial<GlobalNotificationSettings> it)
        => it.AddFieldName("emailNotificationsEnabled");
    
    public static Partial<GlobalNotificationSettings> WithNotificationEmail(this Partial<GlobalNotificationSettings> it)
        => it.AddFieldName("notificationEmail");
    
    public static Partial<GlobalNotificationSettings> WithNotificationEmail(this Partial<GlobalNotificationSettings> it, Func<Partial<TDProfileEmail>, Partial<TDProfileEmail>> partialBuilder)
        => it.AddFieldName("notificationEmail", partialBuilder(new Partial<TDProfileEmail>(it)));
    
    public static Partial<GlobalNotificationSettings> WithIsPushNotificationEnabled(this Partial<GlobalNotificationSettings> it)
        => it.AddFieldName("pushNotificationEnabled");
    
    public static Partial<GlobalNotificationSettings> WithDesktopInactivityTimeout(this Partial<GlobalNotificationSettings> it)
        => it.AddFieldName("desktopInactivityTimeout");
    
    public static Partial<GlobalNotificationSettings> WithIsMultiClientEnabled(this Partial<GlobalNotificationSettings> it)
        => it.AddFieldName("multiClientEnabled");
    
}

