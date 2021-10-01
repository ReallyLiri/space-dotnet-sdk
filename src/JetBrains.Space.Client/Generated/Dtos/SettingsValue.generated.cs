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

public sealed class SettingsValue
     : IPropagatePropertyAccessPath
{
    public SettingsValue() { }
    
    public SettingsValue(bool emailNotificationsEnabled, Weekday firstDayOfWeek, DarkTheme? darkTheme = null, string? themeName = null, string? calendarView = null, TDProfileEmail? notificationEmail = null, DraftDocumentType? draftType = null, bool? todoFilters = null, PRProject? defaultProject = null)
    {
        IsEmailNotificationsEnabled = emailNotificationsEnabled;
        FirstDayOfWeek = firstDayOfWeek;
        DarkTheme = darkTheme;
        ThemeName = themeName;
        CalendarView = calendarView;
        NotificationEmail = notificationEmail;
        DraftType = draftType;
        IsTodoFilters = todoFilters;
        DefaultProject = defaultProject;
    }
    
    private PropertyValue<bool> _emailNotificationsEnabled = new PropertyValue<bool>(nameof(SettingsValue), nameof(IsEmailNotificationsEnabled));
    
    [Required]
    [JsonPropertyName("emailNotificationsEnabled")]
    public bool IsEmailNotificationsEnabled
    {
        get => _emailNotificationsEnabled.GetValue();
        set => _emailNotificationsEnabled.SetValue(value);
    }

    private PropertyValue<Weekday> _firstDayOfWeek = new PropertyValue<Weekday>(nameof(SettingsValue), nameof(FirstDayOfWeek));
    
    [Required]
    [JsonPropertyName("firstDayOfWeek")]
    public Weekday FirstDayOfWeek
    {
        get => _firstDayOfWeek.GetValue();
        set => _firstDayOfWeek.SetValue(value);
    }

    private PropertyValue<DarkTheme?> _darkTheme = new PropertyValue<DarkTheme?>(nameof(SettingsValue), nameof(DarkTheme));
    
    [JsonPropertyName("darkTheme")]
    public DarkTheme? DarkTheme
    {
        get => _darkTheme.GetValue();
        set => _darkTheme.SetValue(value);
    }

    private PropertyValue<string?> _themeName = new PropertyValue<string?>(nameof(SettingsValue), nameof(ThemeName));
    
    [JsonPropertyName("themeName")]
    public string? ThemeName
    {
        get => _themeName.GetValue();
        set => _themeName.SetValue(value);
    }

    private PropertyValue<string?> _calendarView = new PropertyValue<string?>(nameof(SettingsValue), nameof(CalendarView));
    
    [JsonPropertyName("calendarView")]
    public string? CalendarView
    {
        get => _calendarView.GetValue();
        set => _calendarView.SetValue(value);
    }

    private PropertyValue<TDProfileEmail?> _notificationEmail = new PropertyValue<TDProfileEmail?>(nameof(SettingsValue), nameof(NotificationEmail));
    
    [JsonPropertyName("notificationEmail")]
    public TDProfileEmail? NotificationEmail
    {
        get => _notificationEmail.GetValue();
        set => _notificationEmail.SetValue(value);
    }

    private PropertyValue<DraftDocumentType?> _draftType = new PropertyValue<DraftDocumentType?>(nameof(SettingsValue), nameof(DraftType));
    
    [JsonPropertyName("draftType")]
    public DraftDocumentType? DraftType
    {
        get => _draftType.GetValue();
        set => _draftType.SetValue(value);
    }

    private PropertyValue<bool?> _todoFilters = new PropertyValue<bool?>(nameof(SettingsValue), nameof(IsTodoFilters));
    
    [JsonPropertyName("todoFilters")]
    public bool? IsTodoFilters
    {
        get => _todoFilters.GetValue();
        set => _todoFilters.SetValue(value);
    }

    private PropertyValue<PRProject?> _defaultProject = new PropertyValue<PRProject?>(nameof(SettingsValue), nameof(DefaultProject));
    
    [JsonPropertyName("defaultProject")]
    public PRProject? DefaultProject
    {
        get => _defaultProject.GetValue();
        set => _defaultProject.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _emailNotificationsEnabled.SetAccessPath(path, validateHasBeenSet);
        _firstDayOfWeek.SetAccessPath(path, validateHasBeenSet);
        _darkTheme.SetAccessPath(path, validateHasBeenSet);
        _themeName.SetAccessPath(path, validateHasBeenSet);
        _calendarView.SetAccessPath(path, validateHasBeenSet);
        _notificationEmail.SetAccessPath(path, validateHasBeenSet);
        _draftType.SetAccessPath(path, validateHasBeenSet);
        _todoFilters.SetAccessPath(path, validateHasBeenSet);
        _defaultProject.SetAccessPath(path, validateHasBeenSet);
    }

}

