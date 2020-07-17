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
    public sealed class PackageVersionDataDto
         : IPropagatePropertyAccessPath
    {
        public PackageVersionDataDto() { }
        
        public PackageVersionDataDto(PackageTypeDto type, string repository, string name, string version, List<string>? tags = null, long? created = null, long? updated = null, long? downloads = null)
        {
            Type = type;
            Repository = repository;
            Name = name;
            Version = version;
            Tags = tags;
            Created = created;
            Updated = updated;
            Downloads = downloads;
        }
        
        private PropertyValue<PackageTypeDto> _type = new PropertyValue<PackageTypeDto>(nameof(PackageVersionDataDto), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public PackageTypeDto Type
        {
            get { return _type.GetValue(); }
            set { _type.SetValue(value); }
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(PackageVersionDataDto), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get { return _repository.GetValue(); }
            set { _repository.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(PackageVersionDataDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string> _version = new PropertyValue<string>(nameof(PackageVersionDataDto), nameof(Version));
        
        [Required]
        [JsonPropertyName("version")]
        public string Version
        {
            get { return _version.GetValue(); }
            set { _version.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _tags = new PropertyValue<List<string>?>(nameof(PackageVersionDataDto), nameof(Tags));
        
        [JsonPropertyName("tags")]
        public List<string>? Tags
        {
            get { return _tags.GetValue(); }
            set { _tags.SetValue(value); }
        }
    
        private PropertyValue<long?> _created = new PropertyValue<long?>(nameof(PackageVersionDataDto), nameof(Created));
        
        [JsonPropertyName("created")]
        public long? Created
        {
            get { return _created.GetValue(); }
            set { _created.SetValue(value); }
        }
    
        private PropertyValue<long?> _updated = new PropertyValue<long?>(nameof(PackageVersionDataDto), nameof(Updated));
        
        [JsonPropertyName("updated")]
        public long? Updated
        {
            get { return _updated.GetValue(); }
            set { _updated.SetValue(value); }
        }
    
        private PropertyValue<long?> _downloads = new PropertyValue<long?>(nameof(PackageVersionDataDto), nameof(Downloads));
        
        [JsonPropertyName("downloads")]
        public long? Downloads
        {
            get { return _downloads.GetValue(); }
            set { _downloads.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _type.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _version.SetAccessPath(path, validateHasBeenSet);
            _tags.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _updated.SetAccessPath(path, validateHasBeenSet);
            _downloads.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
