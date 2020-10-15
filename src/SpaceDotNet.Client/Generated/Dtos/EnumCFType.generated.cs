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
    public sealed class EnumCFType
         : CFType, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "EnumCFType";
        
        public EnumCFType() { }
        
        public EnumCFType(List<EnumValueData> values)
        {
            Values = values;
        }
        
        private PropertyValue<List<EnumValueData>> _values = new PropertyValue<List<EnumValueData>>(nameof(EnumCFType), nameof(Values));
        
        [Required]
        [JsonPropertyName("values")]
        public List<EnumValueData> Values
        {
            get { return _values.GetValue(); }
            set { _values.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _values.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
