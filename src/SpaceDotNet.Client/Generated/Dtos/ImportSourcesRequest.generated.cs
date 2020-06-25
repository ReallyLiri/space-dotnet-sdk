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
    public class ImportSourcesRequest
         : IPropagatePropertyAccessPath
    {
        public ImportSourcesRequest() { }
        
        public ImportSourcesRequest(string name, string? importerPrincipal = null)
        {
            Name = name;
            ImporterPrincipal = importerPrincipal;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(ImportSourcesRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string?> _importerPrincipal = new PropertyValue<string?>(nameof(ImportSourcesRequest), nameof(ImporterPrincipal));
        
        [JsonPropertyName("importerPrincipal")]
        public string? ImporterPrincipal
        {
            get { return _importerPrincipal.GetValue(); }
            set { _importerPrincipal.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _importerPrincipal.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
