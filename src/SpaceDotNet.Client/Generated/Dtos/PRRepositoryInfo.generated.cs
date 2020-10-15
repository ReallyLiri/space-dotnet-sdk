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
    public sealed class PRRepositoryInfo
         : IPropagatePropertyAccessPath
    {
        public PRRepositoryInfo() { }
        
        public PRRepositoryInfo(string name, string description, RepositoryState state, string? id = null, DateTime? latestActivity = null, DateTime? proxyPushNotification = null, string? initProgress = null, string? readmeName = null, RepositoryActivity? monthlyActivity = null)
        {
            Id = id;
            Name = name;
            Description = description;
            LatestActivity = latestActivity;
            ProxyPushNotification = proxyPushNotification;
            State = state;
            InitProgress = initProgress;
            ReadmeName = readmeName;
            MonthlyActivity = monthlyActivity;
        }
        
        private PropertyValue<string?> _id = new PropertyValue<string?>(nameof(PRRepositoryInfo), nameof(Id));
        
        [JsonPropertyName("id")]
        public string? Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(PRRepositoryInfo), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string> _description = new PropertyValue<string>(nameof(PRRepositoryInfo), nameof(Description));
        
        [Required]
        [JsonPropertyName("description")]
        public string Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<DateTime?> _latestActivity = new PropertyValue<DateTime?>(nameof(PRRepositoryInfo), nameof(LatestActivity));
        
        [JsonPropertyName("latestActivity")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? LatestActivity
        {
            get { return _latestActivity.GetValue(); }
            set { _latestActivity.SetValue(value); }
        }
    
        private PropertyValue<DateTime?> _proxyPushNotification = new PropertyValue<DateTime?>(nameof(PRRepositoryInfo), nameof(ProxyPushNotification));
        
        [JsonPropertyName("proxyPushNotification")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? ProxyPushNotification
        {
            get { return _proxyPushNotification.GetValue(); }
            set { _proxyPushNotification.SetValue(value); }
        }
    
        private PropertyValue<RepositoryState> _state = new PropertyValue<RepositoryState>(nameof(PRRepositoryInfo), nameof(State));
        
        [Required]
        [JsonPropertyName("state")]
        public RepositoryState State
        {
            get { return _state.GetValue(); }
            set { _state.SetValue(value); }
        }
    
        private PropertyValue<string?> _initProgress = new PropertyValue<string?>(nameof(PRRepositoryInfo), nameof(InitProgress));
        
        [JsonPropertyName("initProgress")]
        public string? InitProgress
        {
            get { return _initProgress.GetValue(); }
            set { _initProgress.SetValue(value); }
        }
    
        private PropertyValue<string?> _readmeName = new PropertyValue<string?>(nameof(PRRepositoryInfo), nameof(ReadmeName));
        
        [JsonPropertyName("readmeName")]
        public string? ReadmeName
        {
            get { return _readmeName.GetValue(); }
            set { _readmeName.SetValue(value); }
        }
    
        private PropertyValue<RepositoryActivity?> _monthlyActivity = new PropertyValue<RepositoryActivity?>(nameof(PRRepositoryInfo), nameof(MonthlyActivity));
        
        [JsonPropertyName("monthlyActivity")]
        public RepositoryActivity? MonthlyActivity
        {
            get { return _monthlyActivity.GetValue(); }
            set { _monthlyActivity.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _latestActivity.SetAccessPath(path, validateHasBeenSet);
            _proxyPushNotification.SetAccessPath(path, validateHasBeenSet);
            _state.SetAccessPath(path, validateHasBeenSet);
            _initProgress.SetAccessPath(path, validateHasBeenSet);
            _readmeName.SetAccessPath(path, validateHasBeenSet);
            _monthlyActivity.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
