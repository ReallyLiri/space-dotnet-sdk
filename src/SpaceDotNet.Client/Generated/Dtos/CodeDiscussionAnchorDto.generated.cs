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
    public sealed class CodeDiscussionAnchorDto
         : IPropagatePropertyAccessPath
    {
        public CodeDiscussionAnchorDto() { }
        
        public CodeDiscussionAnchorDto(ProjectKeyDto project, string repository, string revision, string? filename = null, int? line = null, int? oldLine = null, InterpolatedLineState? interpolatedLineState = null)
        {
            Project = project;
            Repository = repository;
            Revision = revision;
            Filename = filename;
            Line = line;
            OldLine = oldLine;
            InterpolatedLineState = interpolatedLineState;
        }
        
        private PropertyValue<ProjectKeyDto> _project = new PropertyValue<ProjectKeyDto>(nameof(CodeDiscussionAnchorDto), nameof(Project));
        
        [Required]
        [JsonPropertyName("project")]
        public ProjectKeyDto Project
        {
            get { return _project.GetValue(); }
            set { _project.SetValue(value); }
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(CodeDiscussionAnchorDto), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get { return _repository.GetValue(); }
            set { _repository.SetValue(value); }
        }
    
        private PropertyValue<string> _revision = new PropertyValue<string>(nameof(CodeDiscussionAnchorDto), nameof(Revision));
        
        [Required]
        [JsonPropertyName("revision")]
        public string Revision
        {
            get { return _revision.GetValue(); }
            set { _revision.SetValue(value); }
        }
    
        private PropertyValue<string?> _filename = new PropertyValue<string?>(nameof(CodeDiscussionAnchorDto), nameof(Filename));
        
        [JsonPropertyName("filename")]
        public string? Filename
        {
            get { return _filename.GetValue(); }
            set { _filename.SetValue(value); }
        }
    
        private PropertyValue<int?> _line = new PropertyValue<int?>(nameof(CodeDiscussionAnchorDto), nameof(Line));
        
        [JsonPropertyName("line")]
        public int? Line
        {
            get { return _line.GetValue(); }
            set { _line.SetValue(value); }
        }
    
        private PropertyValue<int?> _oldLine = new PropertyValue<int?>(nameof(CodeDiscussionAnchorDto), nameof(OldLine));
        
        [JsonPropertyName("oldLine")]
        public int? OldLine
        {
            get { return _oldLine.GetValue(); }
            set { _oldLine.SetValue(value); }
        }
    
        private PropertyValue<InterpolatedLineState?> _interpolatedLineState = new PropertyValue<InterpolatedLineState?>(nameof(CodeDiscussionAnchorDto), nameof(InterpolatedLineState));
        
        [JsonPropertyName("interpolatedLineState")]
        public InterpolatedLineState? InterpolatedLineState
        {
            get { return _interpolatedLineState.GetValue(); }
            set { _interpolatedLineState.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _project.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _revision.SetAccessPath(path, validateHasBeenSet);
            _filename.SetAccessPath(path, validateHasBeenSet);
            _line.SetAccessPath(path, validateHasBeenSet);
            _oldLine.SetAccessPath(path, validateHasBeenSet);
            _interpolatedLineState.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
