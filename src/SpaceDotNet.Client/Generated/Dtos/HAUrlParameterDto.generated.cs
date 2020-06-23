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
    public sealed class HAUrlParameterDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(HAUrlParameterDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(HAUrlParameterDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<List<HAUrlParameterOptionDto>> _options = new PropertyValue<List<HAUrlParameterOptionDto>>(nameof(HAUrlParameterDto), nameof(Options));
        
        [Required]
        [JsonPropertyName("options")]
        public List<HAUrlParameterOptionDto> Options
        {
            get { return _options.GetValue(); }
            set { _options.SetValue(value); }
        }
    
        private PropertyValue<HADeprecationDto?> _deprecation = new PropertyValue<HADeprecationDto?>(nameof(HAUrlParameterDto), nameof(Deprecation));
        
        [JsonPropertyName("deprecation")]
        public HADeprecationDto? Deprecation
        {
            get { return _deprecation.GetValue(); }
            set { _deprecation.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path + "->WithId()", validateHasBeenSet);
            _name.SetAccessPath(path + "->WithName()", validateHasBeenSet);
            _options.SetAccessPath(path + "->WithOptions()", validateHasBeenSet);
            _deprecation.SetAccessPath(path + "->WithDeprecation()", validateHasBeenSet);
        }
    
    }
    
}