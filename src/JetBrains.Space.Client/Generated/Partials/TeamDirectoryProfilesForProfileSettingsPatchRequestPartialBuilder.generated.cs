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

namespace JetBrains.Space.Client.TeamDirectoryProfilesForProfileSettingsPatchRequestPartialBuilder;

public static class TeamDirectoryProfilesForProfileSettingsPatchRequestPartialExtensions
{
    public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithDarkTheme(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
        => it.AddFieldName("darkTheme");
    
    public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithDarkTheme(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it, Func<Partial<DarkTheme>, Partial<DarkTheme>> partialBuilder)
        => it.AddFieldName("darkTheme", partialBuilder(new Partial<DarkTheme>(it)));
    
    public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithThemeName(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
        => it.AddFieldName("themeName");
    
    public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithFirstDayOfWeek(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
        => it.AddFieldName("firstDayOfWeek");
    
    public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithFirstDayOfWeek(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it, Func<Partial<Weekday>, Partial<Weekday>> partialBuilder)
        => it.AddFieldName("firstDayOfWeek", partialBuilder(new Partial<Weekday>(it)));
    
    public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithDraftType(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
        => it.AddFieldName("draftType");
    
    public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithDraftType(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it, Func<Partial<DraftDocumentType>, Partial<DraftDocumentType>> partialBuilder)
        => it.AddFieldName("draftType", partialBuilder(new Partial<DraftDocumentType>(it)));
    
    public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithIsFontLigaturesEnabled(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
        => it.AddFieldName("fontLigaturesEnabled");
    
    public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithIsTodoFilters(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
        => it.AddFieldName("todoFilters");
    
    public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithCalendarView(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
        => it.AddFieldName("calendarView");
    
    public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithIsEmailNotificationsEnabled(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
        => it.AddFieldName("emailNotificationsEnabled");
    
    public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithNotificationEmail(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
        => it.AddFieldName("notificationEmail");
    
    public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithPreferredLanguage(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
        => it.AddFieldName("preferredLanguage");
    
    public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithDefaultProject(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
        => it.AddFieldName("defaultProject");
    
    public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithDefaultProject(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it, Func<Partial<ProjectIdentifier>, Partial<ProjectIdentifier>> partialBuilder)
        => it.AddFieldName("defaultProject", partialBuilder(new Partial<ProjectIdentifier>(it)));
    
}

