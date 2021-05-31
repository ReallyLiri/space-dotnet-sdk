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
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
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
    public sealed class KBBook
         : IPropagatePropertyAccessPath
    {
        public KBBook() { }
        
        public KBBook(string id, bool archived, string name, string summary, long updated, string alias, List<KBBookContext> contexts, KBFolder rootFolder, CPrincipal? updatedBy = null)
        {
            Id = id;
            IsArchived = archived;
            Name = name;
            Summary = summary;
            Updated = updated;
            UpdatedBy = updatedBy;
            Alias = alias;
            Contexts = contexts;
            RootFolder = rootFolder;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(KBBook), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(KBBook), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(KBBook), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _summary = new PropertyValue<string>(nameof(KBBook), nameof(Summary));
        
        [Required]
        [JsonPropertyName("summary")]
        public string Summary
        {
            get => _summary.GetValue();
            set => _summary.SetValue(value);
        }
    
        private PropertyValue<long> _updated = new PropertyValue<long>(nameof(KBBook), nameof(Updated));
        
        [Required]
        [JsonPropertyName("updated")]
        public long Updated
        {
            get => _updated.GetValue();
            set => _updated.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _updatedBy = new PropertyValue<CPrincipal?>(nameof(KBBook), nameof(UpdatedBy));
        
        [JsonPropertyName("updatedBy")]
        public CPrincipal? UpdatedBy
        {
            get => _updatedBy.GetValue();
            set => _updatedBy.SetValue(value);
        }
    
        private PropertyValue<string> _alias = new PropertyValue<string>(nameof(KBBook), nameof(Alias));
        
        [Required]
        [JsonPropertyName("alias")]
        public string Alias
        {
            get => _alias.GetValue();
            set => _alias.SetValue(value);
        }
    
        private PropertyValue<List<KBBookContext>> _contexts = new PropertyValue<List<KBBookContext>>(nameof(KBBook), nameof(Contexts), new List<KBBookContext>());
        
        [Required]
        [JsonPropertyName("contexts")]
        public List<KBBookContext> Contexts
        {
            get => _contexts.GetValue();
            set => _contexts.SetValue(value);
        }
    
        private PropertyValue<KBFolder> _rootFolder = new PropertyValue<KBFolder>(nameof(KBBook), nameof(RootFolder));
        
        [Required]
        [JsonPropertyName("rootFolder")]
        public KBFolder RootFolder
        {
            get => _rootFolder.GetValue();
            set => _rootFolder.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _summary.SetAccessPath(path, validateHasBeenSet);
            _updated.SetAccessPath(path, validateHasBeenSet);
            _updatedBy.SetAccessPath(path, validateHasBeenSet);
            _alias.SetAccessPath(path, validateHasBeenSet);
            _contexts.SetAccessPath(path, validateHasBeenSet);
            _rootFolder.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
