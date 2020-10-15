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
    public sealed class ImageAttachmentVariantsMeta
         : IPropagatePropertyAccessPath
    {
        public ImageAttachmentVariantsMeta() { }
        
        public ImageAttachmentVariantsMeta(string id, string name, int width, int height)
        {
            Id = id;
            Name = name;
            Width = width;
            Height = height;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ImageAttachmentVariantsMeta), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(ImageAttachmentVariantsMeta), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<int> _width = new PropertyValue<int>(nameof(ImageAttachmentVariantsMeta), nameof(Width));
        
        [Required]
        [JsonPropertyName("width")]
        public int Width
        {
            get { return _width.GetValue(); }
            set { _width.SetValue(value); }
        }
    
        private PropertyValue<int> _height = new PropertyValue<int>(nameof(ImageAttachmentVariantsMeta), nameof(Height));
        
        [Required]
        [JsonPropertyName("height")]
        public int Height
        {
            get { return _height.GetValue(); }
            set { _height.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _width.SetAccessPath(path, validateHasBeenSet);
            _height.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
