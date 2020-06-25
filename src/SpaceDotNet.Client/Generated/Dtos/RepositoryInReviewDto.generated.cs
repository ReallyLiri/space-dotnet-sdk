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
    public sealed class RepositoryInReviewDto
         : IPropagatePropertyAccessPath
    {
        public RepositoryInReviewDto() { }
        
        public RepositoryInReviewDto(string name, bool deleted)
        {
            Name = name;
            Deleted = deleted;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(RepositoryInReviewDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<bool> _deleted = new PropertyValue<bool>(nameof(RepositoryInReviewDto), nameof(Deleted));
        
        [Required]
        [JsonPropertyName("deleted")]
        public bool Deleted
        {
            get { return _deleted.GetValue(); }
            set { _deleted.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _deleted.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
