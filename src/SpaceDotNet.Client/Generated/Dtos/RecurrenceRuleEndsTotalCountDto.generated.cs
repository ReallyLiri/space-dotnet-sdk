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
    public sealed class RecurrenceRuleEndsTotalCountDto
         : RecurrenceRuleEndsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "RecurrenceRuleEnds.TotalCount";
        
        public RecurrenceRuleEndsTotalCountDto() { }
        
        public RecurrenceRuleEndsTotalCountDto(int count)
        {
            Count = count;
        }
        
        private PropertyValue<int> _count = new PropertyValue<int>(nameof(RecurrenceRuleEndsTotalCountDto), nameof(Count));
        
        [Required]
        [JsonPropertyName("count")]
        public int Count
        {
            get { return _count.GetValue(); }
            set { _count.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _count.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
