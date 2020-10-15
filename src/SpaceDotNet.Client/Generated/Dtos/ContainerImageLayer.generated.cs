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
    public sealed class ContainerImageLayer
         : IPropagatePropertyAccessPath
    {
        public ContainerImageLayer() { }
        
        public ContainerImageLayer(string id, string statement, string command, long? created = null, long? size = null)
        {
            Id = id;
            Created = created;
            Statement = statement;
            Command = command;
            Size = size;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ContainerImageLayer), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<long?> _created = new PropertyValue<long?>(nameof(ContainerImageLayer), nameof(Created));
        
        [JsonPropertyName("created")]
        public long? Created
        {
            get { return _created.GetValue(); }
            set { _created.SetValue(value); }
        }
    
        private PropertyValue<string> _statement = new PropertyValue<string>(nameof(ContainerImageLayer), nameof(Statement));
        
        [Required]
        [JsonPropertyName("statement")]
        public string Statement
        {
            get { return _statement.GetValue(); }
            set { _statement.SetValue(value); }
        }
    
        private PropertyValue<string> _command = new PropertyValue<string>(nameof(ContainerImageLayer), nameof(Command));
        
        [Required]
        [JsonPropertyName("command")]
        public string Command
        {
            get { return _command.GetValue(); }
            set { _command.SetValue(value); }
        }
    
        private PropertyValue<long?> _size = new PropertyValue<long?>(nameof(ContainerImageLayer), nameof(Size));
        
        [JsonPropertyName("size")]
        public long? Size
        {
            get { return _size.GetValue(); }
            set { _size.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _statement.SetAccessPath(path, validateHasBeenSet);
            _command.SetAccessPath(path, validateHasBeenSet);
            _size.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
