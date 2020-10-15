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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class SettingsValue
         : IPropagatePropertyAccessPath
    {
        public SettingsValue() { }
        
        public SettingsValue(bool emailNotificationsEnabled, Weekday firstDayOfWeek, string? themeName = null, string? calendarView = null, TDProfileEmail? notificationEmail = null, DraftDocumentType? draftType = null, bool? todoFilters = null)
        {
            IsEmailNotificationsEnabled = emailNotificationsEnabled;
            FirstDayOfWeek = firstDayOfWeek;
            ThemeName = themeName;
            CalendarView = calendarView;
            NotificationEmail = notificationEmail;
            DraftType = draftType;
            IsTodoFilters = todoFilters;
        }
        
        private PropertyValue<bool> _emailNotificationsEnabled = new PropertyValue<bool>(nameof(SettingsValue), nameof(IsEmailNotificationsEnabled));
        
        [Required]
        [JsonPropertyName("emailNotificationsEnabled")]
        public bool IsEmailNotificationsEnabled
        {
            get { return _emailNotificationsEnabled.GetValue(); }
            set { _emailNotificationsEnabled.SetValue(value); }
        }
    
        private PropertyValue<Weekday> _firstDayOfWeek = new PropertyValue<Weekday>(nameof(SettingsValue), nameof(FirstDayOfWeek));
        
        [Required]
        [JsonPropertyName("firstDayOfWeek")]
        public Weekday FirstDayOfWeek
        {
            get { return _firstDayOfWeek.GetValue(); }
            set { _firstDayOfWeek.SetValue(value); }
        }
    
        private PropertyValue<string?> _themeName = new PropertyValue<string?>(nameof(SettingsValue), nameof(ThemeName));
        
        [JsonPropertyName("themeName")]
        public string? ThemeName
        {
            get { return _themeName.GetValue(); }
            set { _themeName.SetValue(value); }
        }
    
        private PropertyValue<string?> _calendarView = new PropertyValue<string?>(nameof(SettingsValue), nameof(CalendarView));
        
        [JsonPropertyName("calendarView")]
        public string? CalendarView
        {
            get { return _calendarView.GetValue(); }
            set { _calendarView.SetValue(value); }
        }
    
        private PropertyValue<TDProfileEmail?> _notificationEmail = new PropertyValue<TDProfileEmail?>(nameof(SettingsValue), nameof(NotificationEmail));
        
        [JsonPropertyName("notificationEmail")]
        public TDProfileEmail? NotificationEmail
        {
            get { return _notificationEmail.GetValue(); }
            set { _notificationEmail.SetValue(value); }
        }
    
        private PropertyValue<DraftDocumentType?> _draftType = new PropertyValue<DraftDocumentType?>(nameof(SettingsValue), nameof(DraftType));
        
        [JsonPropertyName("draftType")]
        public DraftDocumentType? DraftType
        {
            get { return _draftType.GetValue(); }
            set { _draftType.SetValue(value); }
        }
    
        private PropertyValue<bool?> _todoFilters = new PropertyValue<bool?>(nameof(SettingsValue), nameof(IsTodoFilters));
        
        [JsonPropertyName("todoFilters")]
        public bool? IsTodoFilters
        {
            get { return _todoFilters.GetValue(); }
            set { _todoFilters.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _emailNotificationsEnabled.SetAccessPath(path, validateHasBeenSet);
            _firstDayOfWeek.SetAccessPath(path, validateHasBeenSet);
            _themeName.SetAccessPath(path, validateHasBeenSet);
            _calendarView.SetAccessPath(path, validateHasBeenSet);
            _notificationEmail.SetAccessPath(path, validateHasBeenSet);
            _draftType.SetAccessPath(path, validateHasBeenSet);
            _todoFilters.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
