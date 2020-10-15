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
    public sealed class ImportedIssue
         : IPropagatePropertyAccessPath
    {
        public ImportedIssue() { }
        
        public ImportedIssue(string extId, string title, string description, string assignee, string status, string extLink)
        {
            ExtId = extId;
            Title = title;
            Description = description;
            Assignee = assignee;
            Status = status;
            ExtLink = extLink;
        }
        
        private PropertyValue<string> _extId = new PropertyValue<string>(nameof(ImportedIssue), nameof(ExtId));
        
        [Required]
        [JsonPropertyName("extId")]
        public string ExtId
        {
            get { return _extId.GetValue(); }
            set { _extId.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(ImportedIssue), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<string> _description = new PropertyValue<string>(nameof(ImportedIssue), nameof(Description));
        
        [Required]
        [JsonPropertyName("description")]
        public string Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<string> _assignee = new PropertyValue<string>(nameof(ImportedIssue), nameof(Assignee));
        
        [Required]
        [JsonPropertyName("assignee")]
        public string Assignee
        {
            get { return _assignee.GetValue(); }
            set { _assignee.SetValue(value); }
        }
    
        private PropertyValue<string> _status = new PropertyValue<string>(nameof(ImportedIssue), nameof(Status));
        
        [Required]
        [JsonPropertyName("status")]
        public string Status
        {
            get { return _status.GetValue(); }
            set { _status.SetValue(value); }
        }
    
        private PropertyValue<string> _extLink = new PropertyValue<string>(nameof(ImportedIssue), nameof(ExtLink));
        
        [Required]
        [JsonPropertyName("extLink")]
        public string ExtLink
        {
            get { return _extLink.GetValue(); }
            set { _extLink.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _extId.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _assignee.SetAccessPath(path, validateHasBeenSet);
            _status.SetAccessPath(path, validateHasBeenSet);
            _extLink.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
