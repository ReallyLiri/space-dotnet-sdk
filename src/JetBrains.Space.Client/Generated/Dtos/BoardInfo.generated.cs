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
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class BoardInfo
         : IPropagatePropertyAccessPath
    {
        public BoardInfo() { }
        
        public BoardInfo(BoardOwners owners, BoardColumns columns, string? description = null)
        {
            Owners = owners;
            Columns = columns;
            Description = description;
        }
        
        private PropertyValue<BoardOwners> _owners = new PropertyValue<BoardOwners>(nameof(BoardInfo), nameof(Owners));
        
        [Required]
        [JsonPropertyName("owners")]
        public BoardOwners Owners
        {
            get => _owners.GetValue();
            set => _owners.SetValue(value);
        }
    
        private PropertyValue<BoardColumns> _columns = new PropertyValue<BoardColumns>(nameof(BoardInfo), nameof(Columns));
        
        [Required]
        [JsonPropertyName("columns")]
        public BoardColumns Columns
        {
            get => _columns.GetValue();
            set => _columns.SetValue(value);
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(BoardInfo), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _owners.SetAccessPath(path, validateHasBeenSet);
            _columns.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}