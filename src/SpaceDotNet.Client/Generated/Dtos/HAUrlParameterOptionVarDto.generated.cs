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
    public sealed class HAUrlParameterOptionVarDto
         : HAUrlParameterOptionDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        private PropertyValue<HAFieldDto> _parameter = new PropertyValue<HAFieldDto>(nameof(HAUrlParameterOptionVarDto), nameof(Parameter));
        
        [Required]
        [JsonPropertyName("parameter")]
        public HAFieldDto Parameter
        {
            get { return _parameter.GetValue(); }
            set { _parameter.SetValue(value); }
        }
    
        private PropertyValue<bool> _prefixRequired = new PropertyValue<bool>(nameof(HAUrlParameterOptionVarDto), nameof(PrefixRequired));
        
        [Required]
        [JsonPropertyName("prefixRequired")]
        public bool PrefixRequired
        {
            get { return _prefixRequired.GetValue(); }
            set { _prefixRequired.SetValue(value); }
        }
    
        private PropertyValue<string> _optionName = new PropertyValue<string>(nameof(HAUrlParameterOptionVarDto), nameof(OptionName));
        
        [Required]
        [JsonPropertyName("optionName")]
        public string OptionName
        {
            get { return _optionName.GetValue(); }
            set { _optionName.SetValue(value); }
        }
    
        private PropertyValue<HADeprecationDto?> _deprecation = new PropertyValue<HADeprecationDto?>(nameof(HAUrlParameterOptionVarDto), nameof(Deprecation));
        
        [JsonPropertyName("deprecation")]
        public HADeprecationDto? Deprecation
        {
            get { return _deprecation.GetValue(); }
            set { _deprecation.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _parameter.SetAccessPath(path + "->WithParameter()", validateHasBeenSet);
            _prefixRequired.SetAccessPath(path + "->WithPrefixRequired()", validateHasBeenSet);
            _optionName.SetAccessPath(path + "->WithOptionName()", validateHasBeenSet);
            _deprecation.SetAccessPath(path + "->WithDeprecation()", validateHasBeenSet);
        }
    
    }
    
}
