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
    public sealed class MavenPackageDependencyDto
         : IPropagatePropertyAccessPath
    {
        public MavenPackageDependencyDto() { }
        
        public MavenPackageDependencyDto(string scope, string group, string artifact, string? version = null)
        {
            Scope = scope;
            Group = group;
            Artifact = artifact;
            Version = version;
        }
        
        private PropertyValue<string> _scope = new PropertyValue<string>(nameof(MavenPackageDependencyDto), nameof(Scope));
        
        [Required]
        [JsonPropertyName("scope")]
        public string Scope
        {
            get { return _scope.GetValue(); }
            set { _scope.SetValue(value); }
        }
    
        private PropertyValue<string> _group = new PropertyValue<string>(nameof(MavenPackageDependencyDto), nameof(Group));
        
        [Required]
        [JsonPropertyName("group")]
        public string Group
        {
            get { return _group.GetValue(); }
            set { _group.SetValue(value); }
        }
    
        private PropertyValue<string> _artifact = new PropertyValue<string>(nameof(MavenPackageDependencyDto), nameof(Artifact));
        
        [Required]
        [JsonPropertyName("artifact")]
        public string Artifact
        {
            get { return _artifact.GetValue(); }
            set { _artifact.SetValue(value); }
        }
    
        private PropertyValue<string?> _version = new PropertyValue<string?>(nameof(MavenPackageDependencyDto), nameof(Version));
        
        [JsonPropertyName("version")]
        public string? Version
        {
            get { return _version.GetValue(); }
            set { _version.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _scope.SetAccessPath(path, validateHasBeenSet);
            _group.SetAccessPath(path, validateHasBeenSet);
            _artifact.SetAccessPath(path, validateHasBeenSet);
            _version.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
