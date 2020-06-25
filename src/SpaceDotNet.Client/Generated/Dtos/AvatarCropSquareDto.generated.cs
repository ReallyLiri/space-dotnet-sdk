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
    public sealed class AvatarCropSquareDto
         : IPropagatePropertyAccessPath
    {
        public AvatarCropSquareDto() { }
        
        public AvatarCropSquareDto(int x, int y, int length)
        {
            X = x;
            Y = y;
            Length = length;
        }
        
        private PropertyValue<int> _x = new PropertyValue<int>(nameof(AvatarCropSquareDto), nameof(X));
        
        [Required]
        [JsonPropertyName("x")]
        public int X
        {
            get { return _x.GetValue(); }
            set { _x.SetValue(value); }
        }
    
        private PropertyValue<int> _y = new PropertyValue<int>(nameof(AvatarCropSquareDto), nameof(Y));
        
        [Required]
        [JsonPropertyName("y")]
        public int Y
        {
            get { return _y.GetValue(); }
            set { _y.SetValue(value); }
        }
    
        private PropertyValue<int> _length = new PropertyValue<int>(nameof(AvatarCropSquareDto), nameof(Length));
        
        [Required]
        [JsonPropertyName("length")]
        public int Length
        {
            get { return _length.GetValue(); }
            set { _length.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _x.SetAccessPath(path, validateHasBeenSet);
            _y.SetAccessPath(path, validateHasBeenSet);
            _length.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
