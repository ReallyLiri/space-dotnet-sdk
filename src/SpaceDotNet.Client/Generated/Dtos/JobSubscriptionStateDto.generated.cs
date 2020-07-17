// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class JobSubscriptionStateDto
         : IPropagatePropertyAccessPath
    {
        public JobSubscriptionStateDto() { }
        
        public JobSubscriptionStateDto(JobSubscriptionType type, bool containsMyCommit, bool runByMe)
        {
            Type = type;
            ContainsMyCommit = containsMyCommit;
            RunByMe = runByMe;
        }
        
        private PropertyValue<JobSubscriptionType> _type = new PropertyValue<JobSubscriptionType>(nameof(JobSubscriptionStateDto), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public JobSubscriptionType Type
        {
            get { return _type.GetValue(); }
            set { _type.SetValue(value); }
        }
    
        private PropertyValue<bool> _containsMyCommit = new PropertyValue<bool>(nameof(JobSubscriptionStateDto), nameof(ContainsMyCommit));
        
        [Required]
        [JsonPropertyName("containsMyCommit")]
        public bool ContainsMyCommit
        {
            get { return _containsMyCommit.GetValue(); }
            set { _containsMyCommit.SetValue(value); }
        }
    
        private PropertyValue<bool> _runByMe = new PropertyValue<bool>(nameof(JobSubscriptionStateDto), nameof(RunByMe));
        
        [Required]
        [JsonPropertyName("runByMe")]
        public bool RunByMe
        {
            get { return _runByMe.GetValue(); }
            set { _runByMe.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _type.SetAccessPath(path, validateHasBeenSet);
            _containsMyCommit.SetAccessPath(path, validateHasBeenSet);
            _runByMe.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
