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
    public sealed class CPrincipal
         : IPropagatePropertyAccessPath
    {
        public CPrincipal() { }
        
        public CPrincipal(string name, CPrincipalDetails? details = null)
        {
            Name = name;
            Details = details;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(CPrincipal), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<CPrincipalDetails?> _details = new PropertyValue<CPrincipalDetails?>(nameof(CPrincipal), nameof(Details));
        
        [JsonPropertyName("details")]
        public CPrincipalDetails? Details
        {
            get { return _details.GetValue(); }
            set { _details.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _details.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
