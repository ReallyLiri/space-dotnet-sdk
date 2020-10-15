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
    public sealed class TrafficPlanLimit
         : IPropagatePropertyAccessPath
    {
        public TrafficPlanLimit() { }
        
        public TrafficPlanLimit(PlanLimit dataTransfer, PlanLimit files, PlanLimit packages, PlanLimit git)
        {
            DataTransfer = dataTransfer;
            Files = files;
            Packages = packages;
            Git = git;
        }
        
        private PropertyValue<PlanLimit> _dataTransfer = new PropertyValue<PlanLimit>(nameof(TrafficPlanLimit), nameof(DataTransfer));
        
        [Required]
        [JsonPropertyName("dataTransfer")]
        public PlanLimit DataTransfer
        {
            get { return _dataTransfer.GetValue(); }
            set { _dataTransfer.SetValue(value); }
        }
    
        private PropertyValue<PlanLimit> _files = new PropertyValue<PlanLimit>(nameof(TrafficPlanLimit), nameof(Files));
        
        [Required]
        [JsonPropertyName("files")]
        public PlanLimit Files
        {
            get { return _files.GetValue(); }
            set { _files.SetValue(value); }
        }
    
        private PropertyValue<PlanLimit> _packages = new PropertyValue<PlanLimit>(nameof(TrafficPlanLimit), nameof(Packages));
        
        [Required]
        [JsonPropertyName("packages")]
        public PlanLimit Packages
        {
            get { return _packages.GetValue(); }
            set { _packages.SetValue(value); }
        }
    
        private PropertyValue<PlanLimit> _git = new PropertyValue<PlanLimit>(nameof(TrafficPlanLimit), nameof(Git));
        
        [Required]
        [JsonPropertyName("git")]
        public PlanLimit Git
        {
            get { return _git.GetValue(); }
            set { _git.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _dataTransfer.SetAccessPath(path, validateHasBeenSet);
            _files.SetAccessPath(path, validateHasBeenSet);
            _packages.SetAccessPath(path, validateHasBeenSet);
            _git.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
