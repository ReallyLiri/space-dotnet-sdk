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
    public sealed class BoardWidgetData
         : IPropagatePropertyAccessPath
    {
        public BoardWidgetData() { }
        
        public BoardWidgetData(int max, List<int> perColumns)
        {
            Max = max;
            PerColumns = perColumns;
        }
        
        private PropertyValue<int> _max = new PropertyValue<int>(nameof(BoardWidgetData), nameof(Max));
        
        [Required]
        [JsonPropertyName("max")]
        public int Max
        {
            get { return _max.GetValue(); }
            set { _max.SetValue(value); }
        }
    
        private PropertyValue<List<int>> _perColumns = new PropertyValue<List<int>>(nameof(BoardWidgetData), nameof(PerColumns));
        
        [Required]
        [JsonPropertyName("perColumns")]
        public List<int> PerColumns
        {
            get { return _perColumns.GetValue(); }
            set { _perColumns.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _max.SetAccessPath(path, validateHasBeenSet);
            _perColumns.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
