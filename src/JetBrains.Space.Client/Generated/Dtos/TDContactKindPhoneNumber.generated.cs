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

namespace JetBrains.Space.Client
{
    public sealed class TDContactKindPhoneNumber
         : TDContactKind, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "TD_ContactKind.PhoneNumber";
        
        public TDContactKindPhoneNumber() { }
        
        public TDContactKindPhoneNumber(string type)
        {
            Type = type;
        }
        
        private PropertyValue<string> _type = new PropertyValue<string>(nameof(TDContactKindPhoneNumber), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public string Type
        {
            get => _type.GetValue();
            set => _type.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _type.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}