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
    public sealed class BGDates
         : IPropagatePropertyAccessPath
    {
        public BGDates() { }
        
        public BGDates(DateTime first, DateTime last)
        {
            First = first;
            Last = last;
        }
        
        private PropertyValue<DateTime> _first = new PropertyValue<DateTime>(nameof(BGDates), nameof(First));
        
        [Required]
        [JsonPropertyName("first")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime First
        {
            get { return _first.GetValue(); }
            set { _first.SetValue(value); }
        }
    
        private PropertyValue<DateTime> _last = new PropertyValue<DateTime>(nameof(BGDates), nameof(Last));
        
        [Required]
        [JsonPropertyName("last")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Last
        {
            get { return _last.GetValue(); }
            set { _last.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _first.SetAccessPath(path, validateHasBeenSet);
            _last.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
