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
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class PersonalSubscriptionTarget
         : IPropagatePropertyAccessPath
    {
        public PersonalSubscriptionTarget() { }
        
        public PersonalSubscriptionTarget(string subjectCode, string targetCode, string description, List<PersonalSubscriptionEvent> events)
        {
            SubjectCode = subjectCode;
            TargetCode = targetCode;
            Description = description;
            Events = events;
        }
        
        private PropertyValue<string> _subjectCode = new PropertyValue<string>(nameof(PersonalSubscriptionTarget), nameof(SubjectCode));
        
        [Required]
        [JsonPropertyName("subjectCode")]
        public string SubjectCode
        {
            get => _subjectCode.GetValue();
            set => _subjectCode.SetValue(value);
        }
    
        private PropertyValue<string> _targetCode = new PropertyValue<string>(nameof(PersonalSubscriptionTarget), nameof(TargetCode));
        
        [Required]
        [JsonPropertyName("targetCode")]
        public string TargetCode
        {
            get => _targetCode.GetValue();
            set => _targetCode.SetValue(value);
        }
    
        private PropertyValue<string> _description = new PropertyValue<string>(nameof(PersonalSubscriptionTarget), nameof(Description));
        
        [Required]
        [JsonPropertyName("description")]
        public string Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<List<PersonalSubscriptionEvent>> _events = new PropertyValue<List<PersonalSubscriptionEvent>>(nameof(PersonalSubscriptionTarget), nameof(Events), new List<PersonalSubscriptionEvent>());
        
        [Required]
        [JsonPropertyName("events")]
        public List<PersonalSubscriptionEvent> Events
        {
            get => _events.GetValue();
            set => _events.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _subjectCode.SetAccessPath(path, validateHasBeenSet);
            _targetCode.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _events.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}