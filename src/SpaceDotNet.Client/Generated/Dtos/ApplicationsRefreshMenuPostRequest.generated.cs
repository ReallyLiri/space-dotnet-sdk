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
    public class ApplicationsRefreshMenuPostRequest
         : IPropagatePropertyAccessPath
    {
        public ApplicationsRefreshMenuPostRequest() { }
        
        public ApplicationsRefreshMenuPostRequest(string? id = null)
        {
            Id = id;
        }
        
        private PropertyValue<string?> _id = new PropertyValue<string?>(nameof(ApplicationsRefreshMenuPostRequest), nameof(Id));
        
        [JsonPropertyName("id")]
        public string? Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
